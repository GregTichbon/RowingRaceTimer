using System;
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

        public Main()
        {
            InitializeComponent();
            RegisterHotKey(this.Handle, 1, (int)KeyModifier.None, Keys.F1.GetHashCode());       // Register F1 as global hotkey. 
            RegisterHotKey(this.Handle, 2, (int)KeyModifier.None, Keys.F10.GetHashCode());       // Register F10 as global hotkey. 

        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rowingRaceTimerDataSet1.RaceCrews' table. You can move, or remove it, as needed.
            this.raceCrewsTableAdapter1.Fill(this.rowingRaceTimerDataSet1.RaceCrews);
            // TODO: This line of code loads data into the 'rowingRaceTimerDataSet.RaceCrews' table. You can move, or remove it, as needed.
            //this.raceCrewsTableAdapter.Fill(this.rowingRaceTimerDataSet.RaceCrews);

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                string queryString = "select * from [starttime] order by [starttime]";

                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    dg_starttime.Rows.Add(dataReader["starttime_id"], Convert.ToDateTime(dataReader["starttime"]).ToString("HH:mm:ss.ff"), dataReader["crew_id"]);
                    int newrow = dg_starttime.Rows.Count - 2;
                    dg_starttime.Rows[newrow].Cells[2].ReadOnly = false;
                }
            }

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                string queryString = "select * from [finishtime] order by [finishtime]";

                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    dg_endtime.Rows.Add(dataReader["finishtime_id"], Convert.ToDateTime(dataReader["finishtime"]).ToString("HH:mm:ss.ff"), dataReader["crew_id"]);
                    int newrow = dg_endtime.Rows.Count - 2;
                    dg_endtime.Rows[newrow].Cells[2].ReadOnly = false;
                }
            }

            /*
             *using (OleDbConnection connection = new OleDbConnection(ConnectionString))
      {

          DataGridViewComboBoxColumn comboBoxstart = (DataGridViewComboBoxColumn)dg_starttime.Rows[0].Cells[2].OwningColumn;
          DataGridViewComboBoxColumn comboBoxfinsih = (DataGridViewComboBoxColumn)dg_endtime.Rows[0].Cells[2].OwningColumn;

          connection.Open();
          string queryString = "select crew_id, boatnumber, crewname from crew order by boatnumber";

          OleDbCommand command = new OleDbCommand(queryString, connection);
          command.CommandType = CommandType.Text;
          OleDbDataReader dataReader = command.ExecuteReader();
          while (dataReader.Read())
          {
              //comboBoxfinsih.Items.
              comboBoxstart.Items.Add(dataReader["crew_id"]);
              comboBoxfinsih.Items.Add(dataReader["crewname"]);
          }

      }
      */


        }

        private void btn_StartTime_Click(object sender, EventArgs e)
        {
            recordtime(dg_starttime, 0, "starttime");
        }

        public void recordtime(DataGridView myGrid, int myTab, string myName)
        {

            timer1.Stop();
            //string starttime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ff");
            DateTime dt_starttime = Convert.ToDateTime(lbl_Timer.Tag);
            //DateTime dt_starttime = Convert.ToDateTime(starttime);
            myGrid.Rows.Add(0, dt_starttime.ToString("HH:mm:ss.ff"));
            timer1.Start();


            int id = 0;

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                string queryString = "Insert into [" + myName + "] ([" + myName + "]) values (?)";

                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.Parameters.Add("@Date", OleDbType.Date);
                command.Parameters[0].Value = dt_starttime;

                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                command.CommandText = "Select @@Identity";
                id = (int)command.ExecuteScalar();

                //MessageBox.Show(id.ToString());
            }

            tabControl.SelectedIndex = myTab;

            int newrow = myGrid.Rows.Count - 2;
            myGrid.Rows[newrow].Cells[0].Value = id;
            myGrid.Rows[newrow].Cells[2].ReadOnly = false;

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



        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                /* Note that the three lines below are not needed if you only want to register one hotkey.
                 * The below lines are useful in case you want to register multiple keys, which you can use a switch with the id as argument, or if you want to know which key/modifier was pressed for some particular reason. */

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

        private void ExampleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 0);       // Unregister hotkey with id 0 before closing the form. You might want to call this more than once with different id values if you are planning to register more than one hotkey.
        }




        private void dg_starttime_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                //int crew_id = Convert.ToInt16(dg_starttime.Rows[e.RowIndex].Cells[2].Value);
                string crew_id = dg_starttime.Rows[e.RowIndex].Cells[2].Value.ToString();

                //int starttime_id = Convert.ToInt16(dg_starttime.Rows[e.RowIndex].Cells[0].Value) ?? 0;
                string starttime_id = dg_starttime.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (crew_id != "" && starttime_id != "")
                {
                    using (OleDbConnection connection = new OleDbConnection(ConnectionString))
                    {
                        connection.Open();
                        string queryString = "update [starttime] set crew_ID = ? where starttime_id = ?";
                        OleDbCommand command = new OleDbCommand(queryString, connection);
                        command.Parameters.Add("@crew_id", OleDbType.BigInt);
                        command.Parameters[0].Value = crew_id;

                        command.Parameters.Add("@starttime_id", OleDbType.BigInt);
                        command.Parameters[1].Value = starttime_id;

                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }

                }
            }

        }

        private void dg_starttime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_loadresults_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                string queryString = "SELECT StartTime.StartTime, FinishTime.FinishTime, Right(\"0\" & [Boatnumber],2) & \" \" & [Club].[code]+\" \"+[crewname] AS Crew, Crew.Prognostic " +
                                     "FROM Club INNER JOIN(FinishTime INNER JOIN (StartTime INNER JOIN Crew ON StartTime.Crew_ID = Crew.Crew_ID) ON FinishTime.Crew_ID = StartTime.Crew_ID) ON Club.Club_ID = Crew.Club_ID";


                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    DateTime startdate = (DateTime)dataReader["starttime"];
                    DateTime finishtime = (DateTime)dataReader["finishtime"];
                    double prognostic = (double)dataReader["prognostic"];
                    double totalprognostic = prognostic * 10;   //needs to change
                    TimeSpan expectedspan = TimeSpan.FromSeconds(totalprognostic);
                    string expected = expectedspan.ToString(@"hh\:mm\:ss\:ff");
                    //string expected = expectedspan.ToString().Substring(3);

                    TimeSpan span = (finishtime - startdate);


                    //string difference = span.Hours.ToString("HH");
                    //string taken = span.ToString().Substring(3);
                    string taken = span.ToString(@"hh\:mm\:ss\:ff");
                    double seconds = span.TotalMilliseconds / 1000;

                    double score = Math.Round(totalprognostic / seconds * 100, 2);

                    dg_results.Rows.Add(dataReader["crew"], prognostic, expected, Convert.ToDateTime(dataReader["starttime"]).ToString("HH:mm:ss.ff"), Convert.ToDateTime(dataReader["finishtime"]).ToString("HH:mm:ss.ff"), taken, score);
                    //int newrow = dg_starttime.Rows.Count - 2;
                    //dg_starttime.Rows[newrow].Cells[2].ReadOnly = false;
                }
            }
        }
        private void btn_exportcsv_Click(object sender, EventArgs e)
        {
            string CsvFpath = @"CSV-EXPORT.csv";
            try
            {
                System.IO.StreamWriter csvFileWriter = new StreamWriter(CsvFpath,false);
                string columnHeaderText = "";
                int countColumn = dg_results.ColumnCount - 1;
                if (countColumn >= 0)
                {
                    columnHeaderText = dg_results.Columns[0].HeaderText;
                }
                for (int i = 1; i <= countColumn; i++)
                {
                    columnHeaderText = columnHeaderText + ',' + dg_results.Columns[i].HeaderText;
                }
                csvFileWriter.WriteLine(columnHeaderText);
                foreach (DataGridViewRow dataRowObject in dg_results.Rows)
                {
                    if (!dataRowObject.IsNewRow)
                    {
                        string dataFromGrid = "";
                        dataFromGrid = dataRowObject.Cells[0].Value.ToString();
                        for (int i = 1; i <= countColumn; i++)
                        {
                            dataFromGrid = dataFromGrid + ',' + dataRowObject.Cells[i].Value.ToString();
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

       

    }
}
