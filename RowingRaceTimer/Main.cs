﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        public string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\RowingRaceTimer\RowingRaceTimer.accdb";
        public Boolean singlestart = true;
        public Boolean prognostics = false;
        public DateTime singlestartdate;
        public int race = 3;

        public Main()
        {
            InitializeComponent();
            RegisterHotKey(this.Handle, 1, (int)KeyModifier.None, Keys.F1.GetHashCode());       // Register F1 as global hotkey. 
            RegisterHotKey(this.Handle, 2, (int)KeyModifier.None, Keys.F10.GetHashCode());       // Register F10 as global hotkey. 
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.raceCrewsTableAdapter2.Fill(this.rowingRaceTimerDataSet11.RaceCrews);

            if (!prognostics)
            {
             
                dg_results.Columns[1].Visible = false;
                dg_results.Columns[2].Visible = false;
                dg_results.Columns[6].Visible = false;
           
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
                        dg_starttime.Rows[newrow].Cells[2].ReadOnly = false;
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
                dg_starttime.AllowUserToAddRows = true;
                dg_starttime.AllowUserToDeleteRows = true;
                dg_starttime.AllowUserToAddRows = true;
                btn_MaintToggle.Text = "Disallow Maintenance";

            }
            else
            {
                dg_starttime.AllowUserToAddRows = false;
                dg_starttime.AllowUserToDeleteRows = false;
                dg_starttime.AllowUserToAddRows = false;
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
            if (e.ColumnIndex == 2)
            {
                string crew_id = dg_starttime.Rows[e.RowIndex].Cells[2].Value.ToString();

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

        private void dg_endtime_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                string crew_id = dg_endtime.Rows[e.RowIndex].Cells[2].Value.ToString();

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

        private void btn_loadresults_Click(object sender, EventArgs e)
        {
            string queryString;

            dg_results.Rows.Clear();
            dg_results.Refresh();
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                //string crewformat = "Right(\"0\" & [Boatnumber],2) & \" \" & [Club].[code]+\" \"+[crewname]";
                string crewformat = " [BoatAlpha] & [BoatNumber] & \" \" & [crewname] & \" (\" & [clubName] & \")\"";

                if (singlestart)
                {
                    queryString = "SELECT '" + singlestartdate + "' as [StartTime], FinishTime.FinishTime, " + crewformat + " AS Crew, Crew.Prognostic, Crew.Division " +
                                                  "FROM (Club INNER JOIN Crew ON Club.Club_ID = Crew.Club_ID) INNER JOIN FinishTime ON Crew.Crew_ID = FinishTime.Crew_ID " +
                                                  "where finishtime.race_id = " + race.ToString();
                } else {
                    queryString = "SELECT StartTime.StartTime, FinishTime.FinishTime, " + crewformat + " AS Crew, Crew.Prognostic, Crew.Division " +
                                     "FROM Club INNER JOIN(FinishTime INNER JOIN (StartTime INNER JOIN Crew ON StartTime.Crew_ID = Crew.Crew_ID) ON FinishTime.Crew_ID = StartTime.Crew_ID) ON Club.Club_ID = Crew.Club_ID " +
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

                    double prognostic = 0;
                    double totalprognostic = 0;
                    string expected = "";


                    if (prognostics)
                    {
                        prognostic = (double)dataReader["prognostic"];
                        totalprognostic = prognostic * 10;   //needs to change
                        TimeSpan expectedspan = TimeSpan.FromSeconds(totalprognostic);
                        expected = expectedspan.ToString(@"hh\:mm\:ss\:ff");
                    }
                    //string expected = expectedspan.ToString().Substring(3);

                    TimeSpan span = (finishtime - startdate);

                    //string difference = span.Hours.ToString("HH");
                    //string taken = span.ToString().Substring(3);
                    string taken = span.ToString(@"hh\:mm\:ss\:ff");
                    double seconds = span.TotalMilliseconds / 1000;

                    double score = Math.Round(totalprognostic / seconds * 100, 2);
                    dg_results.Rows.Add(dataReader["crew"], prognostic, expected, Convert.ToDateTime(dataReader["starttime"]).ToString("HH:mm:ss.ff"), Convert.ToDateTime(dataReader["finishtime"]).ToString("HH:mm:ss.ff"), taken, score, Division);
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
    }
}
