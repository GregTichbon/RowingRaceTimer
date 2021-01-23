using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RowingRaceTimer
{
    public partial class Main : Form
    {
        //public string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\toh-dc\RedirectedFolders$\gtichbon\My Documents\Visual Studio 2017\Projects\RowingRaceTimer\RowingRaceTimer\RowingRaceTimer.accdb";
        static string database = @"c:\RowingRaceTimer\RowingRaceTimer.accdb";
        public string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + database;


        public Boolean singlestart;
        public Boolean prognostics;
        public DateTime singlestartdate;
        public int race;
        public int distance;  //meters

        public Main()
        {
            InitializeComponent();
            RegisterHotKey(this.Handle, 1, (int)KeyModifier.None, Keys.F1.GetHashCode());       // Register F1 as global hotkey. 
            RegisterHotKey(this.Handle, 2, (int)KeyModifier.None, Keys.F10.GetHashCode());       // Register F10 as global hotkey. 
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rowingRaceTimerDataSet.Crew' table. You can move, or remove it, as needed.
            this.crewTableAdapter.Fill(this.rowingRaceTimerDataSet.Crew);

            /*
            string[] row = new string[] { "1", "Product 1", "1000" };
            dgPrognostics.Rows.Add(row);
            row = new string[] { "2", "Product 2", "2000" };
            dgPrognostics.Rows.Add(row);
            row = new string[] { "3", "Product 3", "3000" };
            dgPrognostics.Rows.Add(row);
            row = new string[] { "4", "Product 4", "4000" };
            dgPrognostics.Rows.Add(row);
            */

            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "Select Data";
            cmb.Name = "cmb";
            cmb.MaxDropDownItems = 4;
            cmb.Items.Add("True");
            cmb.Items.Add("False");
            dgPrognostics.Columns.Add(cmb);
            //dgPrognostics.Columns[0].

            dgPrognostics.Rows.Add(1);



            //this.crewTableAdapter.Fill(this.rowingRaceTimerDataSet.Crew);  


            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                string queryString = "select ParameterValue from [Parameter] where ParameterName = 'CurrentRace'";

                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                OleDbDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    race = Convert.ToInt16(dataReader["ParameterValue"].ToString());
                }
            }

            string sql = "SELECT Crew.Crew_ID, [BoatAlpha] & [BoatNumber] & \" \" & [club] & \" - \" & [crewname] AS CrewName FROM Crew WHERE Crew.Race_ID = " + race + " ORDER BY Crew.BoatAlpha, Crew.BoatNumber";
            DataTable dt = this.GetDataTable(sql);
            DataGridViewComboBoxColumn dcombostart;
            dcombostart = (DataGridViewComboBoxColumn)dg_starttime.Columns["CrewStart"];
            dcombostart.DataSource = dt;
            dcombostart.Dispose();
            DataGridViewComboBoxColumn dcomboend;
            dcomboend = (DataGridViewComboBoxColumn)dg_endtime.Columns["CrewFinish"];
            dcomboend.DataSource = dt;
            dcomboend.Dispose();

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                string queryString = "select * from [Race] where Race_ID = " + race;

                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                OleDbDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    //string x1 = dataReader["SingleStart"].ToString();
                    //string x2 = dataReader["prognostics"].ToString();

                    singlestart = (Boolean)dataReader["SingleStart"];
                    prognostics = (Boolean)dataReader["prognostics"];
                    distance = Convert.ToInt16(dataReader["distance"].ToString());
                    //distance = (int)dataReader["distance"];

                }
            }

            //this.crewTableAdapter.Fill(this.rowingRaceTimerDataSet.Crew);

            if (!prognostics)
            {
                dg_results.Columns[1].Visible = false;
                dg_results.Columns[2].Visible = false;
                dg_results.Columns[3].Visible = false;
                dg_results.Columns[7].Visible = false;
                dg_results.Columns[8].Visible = false;

            }
            if (singlestart)
            {
                dg_starttime.Visible = false;
                lbl_starttime.Visible = true;
                dg_results.Columns[3].Visible = false;

                using (OleDbConnection connection = new OleDbConnection(ConnectionString))
                {
                    connection.Open();
                    string queryString = "select * from [singleStartTime] where race_id = ?";

                    OleDbCommand command = new OleDbCommand(queryString, connection);
                    command.CommandType = CommandType.Text;

                    command.Parameters.Add("@race_id", OleDbType.Integer);
                    command.Parameters[0].Value = race;

                    OleDbDataReader dataReader = command.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        dataReader.Read();
                        lbl_starttime.Text = "Race started at: " + Convert.ToDateTime(dataReader["starttime"]).ToString("HH:mm:ss.ff");
                        singlestartdate = Convert.ToDateTime(dataReader["starttime"]);

                    }
                }
            }
            else
            {
                using (OleDbConnection connection = new OleDbConnection(ConnectionString))
                {
                    connection.Open();
                    string queryString = "select * from [starttime] where race_id = ? order by [starttime]";

                    OleDbCommand command = new OleDbCommand(queryString, connection);

                    command.Parameters.Add("@race_id", OleDbType.Integer);
                    command.Parameters[0].Value = race;

                    command.CommandType = CommandType.Text;
                    OleDbDataReader dataReader = command.ExecuteReader();
                    int c1 = 0;
                    while (dataReader.Read())
                    {
                        c1++;
                        dg_starttime.Rows.Add(dataReader["starttime_id"], c1, Convert.ToDateTime(dataReader["starttime"]).ToString("HH:mm:ss.ff"), dataReader["crew_id"]);
                        int newrow = dg_starttime.Rows.Count - 2;
                        dg_starttime.Rows[newrow].Cells[3].ReadOnly = false;
                    }
                }
            }

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                string queryString = "select * from [finishtime] where race_id = ? order by [finishtime]";

                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@race_id", OleDbType.Integer);
                command.Parameters[0].Value = race;

                OleDbDataReader dataReader = command.ExecuteReader();
                int c1 = 0;
                while (dataReader.Read())
                {
                    c1++;
                    dg_endtime.Rows.Add(dataReader["finishtime_id"], c1, Convert.ToDateTime(dataReader["finishtime"]).ToString("HH:mm:ss.ff"), dataReader["crew_id"]);
                    int newrow = dg_endtime.Rows.Count - 2;
                    dg_endtime.Rows[newrow].Cells[3].ReadOnly = false;
                }
            }


            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                string queryString = "select * from [Crew] where race_id = ? order by [boatnumber], [boatalpha], prognostic desc";

                OleDbCommand command = new OleDbCommand(queryString, connection);

                command.Parameters.Add("@race_id", OleDbType.Integer);
                command.Parameters[0].Value = race;

                command.CommandType = CommandType.Text;
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    dg_crews.Rows.Add(dataReader["crew_id"], dataReader["boatnumber"], dataReader["boatalpha"], dataReader["club"], dataReader["boattype"], dataReader["crewname"], dataReader["prognostic"]);
                    int newrow = dg_crews.Rows.Count - 2;
                }
            }

            refreshprognosticdata();
        }

    
        private DataTable GetDataTable(string sql)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                cmd.CommandType = CommandType.Text;
                using (OleDbDataAdapter sda = new OleDbDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        return dt;
                    }
                }
                /*
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    dg_crews.Rows.Add(dataReader["crew_id"], dataReader["boatnumber"], dataReader["boatalpha"], dataReader["club"], dataReader["boattype"], dataReader["crewname"], dataReader["prognostic"]);
                    int newrow = dg_crews.Rows.Count - 2;
                }
                */
            }
        }




        private void btn_StartTime_Click(object sender, EventArgs e)
        {
            if (singlestart)
            {
                //timer1.Stop();
                //string starttime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ff");
                DateTime dt_starttime = Convert.ToDateTime(lbl_Timer.Tag);
                //DateTime dt_starttime = Convert.ToDateTime(starttime);
                DialogResult ans = DialogResult.Yes;
                if (lbl_starttime.Text != "")
                {
                    ans = MessageBox.Show("The race has already started, do you wish to override the start time?", "", MessageBoxButtons.YesNo);
                }
                if (ans == DialogResult.Yes)
                {
                    lbl_starttime.Text = "Race started at: " + dt_starttime.ToString("HH:mm:ss.ff");
                    singlestartdate = dt_starttime;

                    using (OleDbConnection connection = new OleDbConnection(ConnectionString))
                    {
                        connection.Open();
                        string queryString = "delete * from SingleStartTime where race_id = ?";// + race.ToString();

                        OleDbCommand command1 = new OleDbCommand(queryString, connection);
                        command1.Parameters.Add("@race_id", OleDbType.Integer);
                        command1.Parameters[0].Value = race;

                        command1.CommandType = CommandType.Text;
                        command1.ExecuteNonQuery();

                        queryString = "insert into SingleStartTime (race_id, StartTime) values (?, ?)";

                        OleDbCommand command2 = new OleDbCommand(queryString, connection);
                        command2.Parameters.Add("@race_ID", OleDbType.Integer);
                        command2.Parameters[0].Value = race;

                        command2.Parameters.Add("@StartTime", OleDbType.Date);
                        command2.Parameters[1].Value = dt_starttime;

                        command2.CommandType = CommandType.Text;
                        command2.ExecuteNonQuery();
                    }
                }
                //timer1.Start();
            }
            else
            {
                recordtime(dg_starttime, 0, "starttime");
            }
        }

        private void recordtime(DataGridView myGrid, int myTab, string myName)
        {
            Console.Beep(5000, 500);
            //timer1.Stop();
            //string starttime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ff");
            DateTime dt_starttime = Convert.ToDateTime(lbl_Timer.Tag);
            //DateTime dt_starttime = Convert.ToDateTime(starttime);
            myGrid.Rows.Add(0, myGrid.Rows.Count, dt_starttime.ToString("HH:mm:ss.ff"));
            //timer1.Start();

            int id = 0;

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                string queryString = "Insert into [" + myName + "] ([" + myName + "], Race_ID) values (?, ?)";

                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.Parameters.Add("@Date", OleDbType.Date);
                command.Parameters[0].Value = dt_starttime;

                command.Parameters.Add("@race_id", OleDbType.Integer);
                command.Parameters[1].Value = race;

                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                command.CommandText = "Select @@Identity";
                id = (int)command.ExecuteScalar();

                //MessageBox.Show(id.ToString());
            }

            tabControl.SelectedIndex = myTab;

            int newrow = myGrid.Rows.Count - 2;
            myGrid.Rows[newrow].Cells[0].Value = id;
            myGrid.Rows[newrow].Cells[3].ReadOnly = false;

            myGrid.FirstDisplayedScrollingRowIndex = myGrid.RowCount - 1;

        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            recordtime(dg_endtime, 1, "finishtime");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lbl_Timer.Tag = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ff");
            lbl_Timer.Text = now.ToString("HH:mm:ss:ff");
        }

        private void btn_MaintToggle_Click(object sender, EventArgs e)
        {
            if (btn_MaintToggle.Text == "Allow Maintenance")
            {
                dg_endtime.AllowUserToAddRows = true;
                dg_endtime.AllowUserToDeleteRows = true;
                btn_MaintToggle.Text = "Disallow Maintenance";

            }
            else
            {
                dg_endtime.AllowUserToAddRows = false;
                dg_endtime.AllowUserToDeleteRows = false;
                btn_MaintToggle.Text = "Allow Maintenance";

            }

        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                // Note that the three lines below are not needed if you only want to register one hotkey.
                //The below lines are useful in case you want to register multiple keys, which you can use a switch with the id as argument, or if you want to know which key/modifier was pressed for some particular reason. 

                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);                  // The key of the hotkey that was pressed.
                KeyModifier modifier = (KeyModifier)((int)m.LParam & 0xFFFF);       // The modifier of the hotkey that was pressed.
                int id = m.WParam.ToInt32();                                        // The id of the hotkey that was pressed.


                //MessageBox.Show(modifier + " " + key +      " has been pressed!");
                switch (id)
                {
                    case 1:
                        {
                            recordtime(dg_starttime, 0, "starttime");
                            break;
                        }
                    case 2:
                        {
                            recordtime(dg_endtime, 1, "finishtime");
                            break;
                        }
                }

            }
        }

        private void dg_starttime_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (dg_starttime.Rows[e.RowIndex].Cells[3].Value != null)
                {
                    string crew_id = dg_starttime.Rows[e.RowIndex].Cells[3].Value.ToString();

                    string time_id = dg_starttime.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (crew_id != "" && time_id != "")
                    {
                        using (OleDbConnection connection = new OleDbConnection(ConnectionString))
                        {
                            connection.Open();
                            string queryString = "update [starttime] set crew_ID = ? where starttime_id = ?";
                            OleDbCommand command = new OleDbCommand(queryString, connection);
                            command.Parameters.Add("@crew_id", OleDbType.BigInt);
                            command.Parameters[0].Value = crew_id;

                            command.Parameters.Add("@starttime_id", OleDbType.BigInt);
                            command.Parameters[1].Value = time_id;

                            command.CommandType = CommandType.Text;
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private void dg_endtime_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (dg_endtime.Rows[e.RowIndex].Cells[3].Value != null)
                {
                    string crew_id = dg_endtime.Rows[e.RowIndex].Cells[3].Value.ToString();

                    string time_id = dg_endtime.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (crew_id != "" && time_id != "")
                    {
                        using (OleDbConnection connection = new OleDbConnection(ConnectionString))
                        {
                            connection.Open();
                            string queryString = "update [finishtime] set crew_ID = ? where finishtime_id = ?";
                            OleDbCommand command = new OleDbCommand(queryString, connection);
                            command.Parameters.Add("@crew_id", OleDbType.BigInt);
                            command.Parameters[0].Value = crew_id;

                            command.Parameters.Add("@finishtime_id", OleDbType.Integer);
                            command.Parameters[1].Value = time_id;

                            command.CommandType = CommandType.Text;
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private void btn_loadresults_Click(object sender, EventArgs e)
        {
            string queryString;

            dg_results.Rows.Clear();
            dg_results.Refresh();

            string ErrorMessage = "";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                queryString = @"SELECT [BoatAlpha] & [Boatnumber] AS Boat
                    FROM StartTime RIGHT JOIN Crew ON StartTime.Crew_ID = Crew.Crew_ID
                    WHERE StartTime.StartTime_ID Is Null AND Crew.Race_ID = " + race.ToString() + @"
                    ORDER BY Crew.BoatAlpha, Crew.BoatNumber";

                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ErrorMessage += "Boat " + dataReader["Boat"] + " has not started" + Environment.NewLine;
                }
            }


            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                queryString = @"SELECT [BoatAlpha] & [Boatnumber] AS Boat
                        FROM StartTime INNER JOIN Crew ON StartTime.Crew_ID = Crew.Crew_ID
                        WHERE StartTime.Race_ID = " + race.ToString() + @" 
                        GROUP BY StartTime.Crew_ID, [BoatAlpha] & [Boatnumber]
                        HAVING Count(StartTime.Crew_ID) > 1";

                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ErrorMessage += "Boat " + dataReader["Boat"] + " has started more than once" + Environment.NewLine;
                }
            }

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                queryString = @"SELECT [BoatAlpha] & [Boatnumber] AS Boat
                        FROM FinishTime INNER JOIN Crew ON FinishTime.Crew_ID = Crew.Crew_ID
                        WHERE FinishTime.Race_ID = " + race.ToString() + @" 
                        GROUP BY FinishTime.Crew_ID, [BoatAlpha] & [Boatnumber]
                        HAVING Count(FinishTime.Crew_ID) > 1";

                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ErrorMessage += "Boat " + dataReader["Boat"] + " has finished more than once" + Environment.NewLine;
                }
            }

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                queryString = @"SELECT [BoatAlpha] & [Boatnumber] AS Boat
                        FROM (StartTime LEFT JOIN FinishTime ON StartTime.Crew_ID = FinishTime.Crew_ID) INNER JOIN Crew ON StartTime.Crew_ID = Crew.Crew_ID
                        WHERE StartTime.Race_ID = " + race.ToString() + @" 
                        GROUP BY [BoatAlpha] & [Boatnumber], StartTime.Crew_ID
                        HAVING Count(FinishTime.Crew_ID) < 1";


                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ErrorMessage += "Boat " + dataReader["Boat"] + " has not finished" + Environment.NewLine;
                }
            }

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                queryString = @"SELECT [BoatAlpha] & [Boatnumber] AS Boat
                        FROM (FinishTime LEFT JOIN StartTime ON FinishTime.Crew_ID = StartTime.Crew_ID) LEFT JOIN Crew ON FinishTime.Crew_ID = Crew.Crew_ID
                        WHERE StartTime.StartTime_ID Is Null AND FinishTime.Race_ID = " + race.ToString();

                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ErrorMessage += "Boat " + dataReader["Boat"] + " has finished but did not start" + Environment.NewLine;
                }
            }

            if (ErrorMessage != "")
            {
                MessageBox.Show(ErrorMessage);
            }

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                //string crewformat = "Right(\"0\" & [Boatnumber],2) & \" \" & [Club].[code]+\" \"+[crewname]";
                string crewformat = " [BoatAlpha] & [BoatNumber] & \" \" & [club] & \" (\" & [crewname] & \")\"";

                if (singlestart)
                {
                    queryString = "SELECT crew.Race_ID, '" + singlestartdate + "' as [StartTime], FinishTime.FinishTime, " + crewformat + " AS Crew, Crew.Prognostic, Crew.Division, Crew.BoatType " +
                                     "FROM FinishTime INNER JOIN (StartTime INNER JOIN Crew ON StartTime.Crew_ID = Crew.Crew_ID) ON FinishTime.Crew_ID = StartTime.Crew_ID " +
                                                  "where finishtime.race_id = " + race.ToString();
                }
                else
                {
                    queryString = "SELECT crew.Race_ID, StartTime.StartTime, FinishTime.FinishTime, " + crewformat + " AS Crew, Crew.Prognostic, Crew.Division, Crew.BoatType " +
                                     "FROM FinishTime INNER JOIN (StartTime INNER JOIN Crew ON StartTime.Crew_ID = Crew.Crew_ID) ON FinishTime.Crew_ID = StartTime.Crew_ID " +
                                     "where finishtime.race_id = " + race.ToString();
                }
                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    DateTime startdate;
                    if (singlestart)
                    {
                        startdate = singlestartdate;
                    }
                    else
                    {
                        startdate = (DateTime)dataReader["starttime"];
                    }
                    DateTime finishtime = (DateTime)dataReader["finishtime"];
                    string Division = dataReader["Division"].ToString();
                    string BoatType = dataReader["BoatType"].ToString();

                    double prognostic = 0;
                    double totalprognostic = 0;
                    string expected = "";
                    double expectedSeconds = 0;


                    if (prognostics)
                    {
                        prognostic = (double)dataReader["prognostic"];
                        totalprognostic = prognostic * (distance / 1000); //distance is in metres
                        TimeSpan expectedspan = TimeSpan.FromSeconds(totalprognostic);
                        expected = expectedspan.ToString(@"hh\:mm\:ss\:ff");
                        expectedSeconds = expectedspan.TotalMilliseconds / 1000;
                    }
                    //string expected = expectedspan.ToString().Substring(3);

                    TimeSpan span = (finishtime - startdate);

                    //string difference = span.Hours.ToString("HH");
                    //string taken = span.ToString().Substring(3);
                    string taken = span.ToString(@"hh\:mm\:ss\:ff");
                    double seconds = span.TotalMilliseconds / 1000;

                    double score = Math.Round(totalprognostic / seconds * 100, 2);
                    dg_results.Rows.Add(dataReader["race_id"], dataReader["crew"], prognostic, expected, expectedSeconds, Convert.ToDateTime(dataReader["starttime"]).ToString("HH:mm:ss.ff"), Convert.ToDateTime(dataReader["finishtime"]).ToString("HH:mm:ss.ff"), taken, seconds, score, Division, BoatType);
                }
            }
        }

        private void btn_exportcsv_Click(object sender, EventArgs e)
        {
            string CsvFpath = @"c:\RowingRaceTimer\RowingRaceTimer.csv";
            try
            {
                System.IO.StreamWriter csvFileWriter = new StreamWriter(CsvFpath, false);
                string columnHeaderText = "";
                int countColumn = dg_results.ColumnCount - 1;
                //if (countColumn >= 0)
                //{
                //columnHeaderText = dg_results.Columns[0].HeaderText;
                //}
                string delim = "";
                for (int i = 0; i <= countColumn; i++)
                {
                    columnHeaderText = columnHeaderText + delim + dg_results.Columns[i].HeaderText;
                    delim = ",";
                }
                csvFileWriter.WriteLine(columnHeaderText);
                foreach (DataGridViewRow dataRowObject in dg_results.Rows)
                {
                    if (!dataRowObject.IsNewRow)
                    {
                        string dataFromGrid = "";
                        delim = "";
                        //dataFromGrid = dataRowObject.Cells[0].Value.ToString();
                        for (int i = 0; i <= countColumn; i++)
                        {
                            dataFromGrid = dataFromGrid + delim + "\"" + dataRowObject.Cells[i].Value.ToString() + "\"";
                            delim = ",";
                        }
                        csvFileWriter.WriteLine(dataFromGrid);
                    }
                }

                csvFileWriter.Flush();
                csvFileWriter.Close();
            }
            catch (Exception exceptionObject)
            {
                MessageBox.Show(exceptionObject.ToString());
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Unregister hotkeys before closing the form. 
            UnregisterHotKey(this.Handle, 0);
            UnregisterHotKey(this.Handle, 1);

        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }

        private void raceCrewsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void rowingRaceTimerDataSet11BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dg_starttime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void raceCrewsBindingSource3_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btn_MaintToggleStart_Click(object sender, EventArgs e)
        {
            {
                if (btn_MaintToggleStart.Text == "Allow Maintenance")
                {
                    dg_starttime.AllowUserToAddRows = true;
                    dg_starttime.AllowUserToDeleteRows = true;
                    btn_MaintToggleStart.Text = "Disallow Maintenance";

                }
                else
                {
                    dg_starttime.AllowUserToAddRows = false;
                    dg_starttime.AllowUserToDeleteRows = false;
                    btn_MaintToggleStart.Text = "Allow Maintenance";

                }

            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            saveresults();


        }

        private void saveresults()
        {
            //string columnHeaderText = "";
            int countColumn = dg_results.ColumnCount - 1;
            //if (countColumn >= 0)
            //{
            //columnHeaderText = dg_results.Columns[0].HeaderText;
            //}
            string delim = "";
            //for (int i = 0; i <= countColumn; i++)
            //{
            //columnHeaderText = columnHeaderText + delim + dg_results.Columns[i].HeaderText;
            // = ",";
            //}

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                string queryString = "DELETE * FROM RaceResults where race_id = " + race.ToString();

                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                int recordsupdated = command.ExecuteNonQuery();


            }


            foreach (DataGridViewRow dataRowObject in dg_results.Rows)
            {
                if (!dataRowObject.IsNewRow)
                {
                    string dataFromGrid = "";
                    delim = "";
                    //dataFromGrid = dataRowObject.Cells[0].Value.ToString();
                    for (int i = 0; i <= countColumn; i++)
                    {
                        dataFromGrid = dataFromGrid + delim + "'" + dataRowObject.Cells[i].Value.ToString().Replace("'", "''") + "'";
                        delim = ",";
                    }
                    string b = dataFromGrid; //TODO

                    using (OleDbConnection connection = new OleDbConnection(ConnectionString))
                    {
                        connection.Open();
                        string queryString = "insert into raceresults (Race_ID,CrewName,Prognostic,Expected,ExpectedSeconds,StartTime,FinishTime,Taken,TakenSeconds,Score,Division,BoatType) values (" + dataFromGrid + ")";

                        OleDbCommand command = new OleDbCommand(queryString, connection);
                        command.CommandType = CommandType.Text;
                        int recordsupdated = command.ExecuteNonQuery();


                    }




                }
            }
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            saveresults();
            var newForm = new RaceResultsReport();
            newForm.Show();
        }

        private void dg_starttime_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void dg_starttime_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            foreach (DataGridViewRow item in this.dg_starttime.SelectedRows)
            {
                string time_id = item.Cells[0].Value.ToString();
                using (OleDbConnection connection = new OleDbConnection(ConnectionString))
                {
                    connection.Open();
                    string queryString = "delete * from [starttime] where starttime_id = " + time_id;
                    OleDbCommand command = new OleDbCommand(queryString, connection);
                    //command.Parameters.Add("@starttime_id", OleDbType.BigInt);
                    //command.Parameters[0].Value = time_id;

                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();

                }
            }
        }

        private void dg_endtime_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            foreach (DataGridViewRow item in this.dg_endtime.SelectedRows)
            {
                string time_id = item.Cells[0].Value.ToString();
                using (OleDbConnection connection = new OleDbConnection(ConnectionString))
                {
                    connection.Open();
                    string queryString = "delete * from [finishtime] where finishtime_id = " + time_id;
                    OleDbCommand command = new OleDbCommand(queryString, connection);
                    //command.Parameters.Add("@starttime_id", OleDbType.BigInt);
                    //command.Parameters[0].Value = time_id;

                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();

                }
            }
        }

        private void maintainRacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Races frmRaces = new Races();
            frmRaces.ShowDialog();
        }

        private void clearResultsForCurrentRaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //public string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\RowingRaceTimer\RowingRaceTimer.accdb";
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                string queryString = "SELECT * from parameter P inner join Race R on R.Race_ID = cint(P.ParameterValue) where P.ParameterName = 'CurrentRace'";

                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                OleDbDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    string race_id =  dataReader["race_id"].ToString();
                    string racename = dataReader["RaceName"].ToString();
                    if (MessageBox.Show("Are you sure you want to clear the start and finish times for the " + racename + " race?", racename, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        OleDbCommand cmd = new OleDbCommand("delete * from starttime where race_id = " + race_id, connection);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        cmd = new OleDbCommand("delete * from finishtime where race_id = " + race_id, connection);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();

                        dg_starttime.Rows.Clear();
                        dg_endtime.Rows.Clear();
                        dg_results.Rows.Clear();
                    }
                }
            }
        }

        private void setCurrentRaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void openDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //c:\RowingRaceTimer\RowingRaceTimer.accdb
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "msaccess.exe"; //not the full application path
            myProcess.StartInfo.Arguments = database;
            myProcess.Start();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPagePrognostics_Click(object sender, EventArgs e)
        {

        }

        public void refreshprognosticdata()
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                string queryString = "select discipline_ctr, discipline from prognostic_discipline order by sequence";

                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                OleDbDataAdapter sda = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                DataRow dr;
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select Discipline--" };
                dt.Rows.InsertAt(dr, 0);
                cmbDiscipline.ValueMember = "discipline_ctr";
                cmbDiscipline.DisplayMember = "discipline";
                cmbDiscipline.DataSource = dt;
            }
          }
        public void refreshprognosticboat(int discipline_ctr)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                string queryString = @"SELECT Prognostic_Boat.Boat_CTR, Prognostic_Boat.Boat
                                FROM Prognostic_Prognostic INNER JOIN Prognostic_Boat ON Prognostic_Prognostic.Boat_CTR = Prognostic_Boat.Boat_CTR
                                WHERE (((Prognostic_Prognostic.Discipline_CTR)=" + discipline_ctr + @"))
                                GROUP BY Prognostic_Boat.Boat_CTR, Prognostic_Boat.Boat, Prognostic_Boat.Sequence
                                ORDER BY Prognostic_Boat.Sequence";

                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                OleDbDataAdapter sda = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                DataRow dr;
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select Boat--" };
                dt.Rows.InsertAt(dr, 0);
                cmbBoat.ValueMember = "boat_ctr";
                cmbBoat.DisplayMember = "boat";
                cmbBoat.DataSource = dt;
            }
        }

        public void refreshprognosticdivision(int discipline_ctr, int boat_ctr)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                string queryString = @"SELECT Prognostic_Division.Division_CTR, Prognostic_Division.Division FROM Prognostic_Prognostic INNER JOIN Prognostic_Division ON Prognostic_Prognostic.Division_CTR = Prognostic_Division.Division_CTR WHERE (((Prognostic_Prognostic.Discipline_CTR)=" + discipline_ctr + @") AND ((Prognostic_Prognostic.Boat_CTR)=" + boat_ctr + @")) GROUP BY Prognostic_Division.Division_CTR, Prognostic_Division.Division, Prognostic_Division.Sequence ORDER BY Prognostic_Division.Sequence";
                //ORDER BY Prognostic_Division.Sequence";

                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                OleDbDataAdapter sda = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                DataRow dr;
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select Division--" };
                dt.Rows.InsertAt(dr, 0);
                cmbDivision.ValueMember = "Division_CTR";
                cmbDivision.DisplayMember = "Division";
                cmbDivision.DataSource = dt;
            }
        }
        public void refreshprognosticgender(int discipline_ctr, int boat_ctr, int division_ctr)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                string queryString = @"SELECT Prognostic_Gender.Gender_Ctr, Prognostic_Gender.Gender FROM Prognostic_Gender INNER JOIN Prognostic_Prognostic ON Prognostic_Gender.Gender_Ctr = Prognostic_Prognostic.Gender_CTR WHERE (((Prognostic_Prognostic.Discipline_CTR)=" + discipline_ctr + @") AND ((Prognostic_Prognostic.Boat_CTR)=" + boat_ctr + @") AND ((Prognostic_Prognostic.Division_CTR)=" + division_ctr + @")) GROUP BY Prognostic_Gender.Gender_Ctr, Prognostic_Gender.Gender, Prognostic_Gender.Sequence ORDER BY Prognostic_Gender.Sequence";
                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                OleDbDataAdapter sda = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                DataRow dr;
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select Gender--" };
                dt.Rows.InsertAt(dr, 0);
                cmbGender.ValueMember = "gender_ctr";
                cmbGender.DisplayMember = "gender";
                cmbGender.DataSource = dt;
            }
        }


        public void refreshprognosticscores(int discipline_ctr, int boat_ctr, int division_ctr, int gender_ctr)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                string queryString = @"SELECT Prognostic_Prognostic.Prognostic_CTR, Prognostic_Prognostic.Description, Prognostic_Prognostic.Code, Prognostic_Boat.Seats, Prognostic_Boat.Coxed, Prognostic_Prognostic.PrognosticTime
FROM Prognostic_Boat INNER JOIN Prognostic_Prognostic ON Prognostic_Boat.Boat_CTR = Prognostic_Prognostic.Boat_CTR
WHERE (((Prognostic_Prognostic.Discipline_CTR)=" + discipline_ctr + @") AND ((Prognostic_Prognostic.Boat_CTR)=" + boat_ctr + @") AND ((Prognostic_Prognostic.Division_CTR)=" + division_ctr + @") AND ((Prognostic_Prognostic.Gender_CTR)=" + gender_ctr + @"))";

                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                OleDbDataReader dataReader = command.ExecuteReader();
                if (dataReader.HasRows) { 
                dataReader.Read();
                MessageBox.Show(dataReader["PrognosticTime"].ToString());
                }
            }

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDiscipline.SelectedValue.ToString() != null)
            {
                int discipline_ctr = Convert.ToInt32(cmbDiscipline.SelectedValue.ToString());
                refreshprognosticboat(discipline_ctr);
            }
        }
        private void cmbBoat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = cmbBoat.SelectedValue.ToString();
            if (cmbBoat.SelectedValue.ToString() != "")
            {
                int discipline_ctr = Convert.ToInt32(cmbDiscipline.SelectedValue.ToString());
                int boat_ctr = Convert.ToInt32(cmbBoat.SelectedValue.ToString());
                refreshprognosticdivision(discipline_ctr, boat_ctr);
            }
        }
        private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDivision.SelectedValue.ToString() != "")
            {
                int discipline_ctr = Convert.ToInt32(cmbDiscipline.SelectedValue.ToString());
                int boat_ctr = Convert.ToInt32(cmbBoat.SelectedValue.ToString());
                int division_ctr = Convert.ToInt32(cmbDivision.SelectedValue.ToString());
                refreshprognosticgender(discipline_ctr, boat_ctr,division_ctr);
            }
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGender.SelectedValue.ToString() != "")
            {
                int discipline_ctr = Convert.ToInt32(cmbDiscipline.SelectedValue.ToString());
                int boat_ctr = Convert.ToInt32(cmbBoat.SelectedValue.ToString());
                int division_ctr = Convert.ToInt32(cmbDivision.SelectedValue.ToString());
                int gender_ctr = Convert.ToInt32(cmbGender.SelectedValue.ToString());
                refreshprognosticscores(discipline_ctr, boat_ctr, division_ctr, gender_ctr);
            }
        }

        private void crewBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void crewBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {

        }
    }
}
