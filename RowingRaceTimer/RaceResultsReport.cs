using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RowingRaceTimer
{
    public partial class RaceResultsReport : Form
    {
        public RaceResultsReport()
        {
            InitializeComponent();
        }

        private void RaceResultsReport_Load(object sender, EventArgs e)
        {
            Int16 race = 0;
            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\RowingRaceTimer\RowingRaceTimer.accdb";
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
            

            ReportDocument rpt = new ReportDocument();
            rpt.Load("C:\\RowingRaceTimer\\results.rpt");

            OleDbConnection con = new OleDbConnection(ConnectionString);

            DataSet ds = new DataSet();
            string sql1 = @"SELECT RaceResults.Prognostic, RaceResults.StartTime, RaceResults.FinishTime, RaceResults.Taken, RaceResults.Score, RaceResults.BoatType, RaceResults.CrewName
                     FROM RaceResults 
                     where RaceResults.race_id = " + race.ToString() + @"
                     ORDER BY RaceResults.Score DESC";

            OleDbCommand cmd1 = new OleDbCommand(sql1);

            cmd1.CommandType = CommandType.Text;
            cmd1.Connection = con;
            OleDbDataAdapter adp1 = new OleDbDataAdapter();
            adp1.SelectCommand = cmd1;

            DataTable dataTable1 = new DataTable();
            dataTable1.TableName = "RaceResults";

            adp1.Fill(dataTable1);

            string sql2 = @"SELECT Race.RaceName, Race.RaceDateTime, Race.Distance 
                     FROM Race 
                     where Race.race_id = " + race.ToString();

            OleDbCommand cmd2 = new OleDbCommand(sql2);

            cmd2.CommandType = CommandType.Text;
            cmd2.Connection = con;
            OleDbDataAdapter adp2 = new OleDbDataAdapter();
            adp2.SelectCommand = cmd2;

            DataTable dataTable2 = new DataTable();
            dataTable2.TableName = "Race";

            adp2.Fill(dataTable2);
            int x10 = dataTable2.Rows.Count;

            ds.Tables.Add(dataTable1);
            ds.Tables.Add(dataTable2);

            string x5 = ds.Tables[0].TableName;
            string x6 = ds.Tables[1].TableName;

            rpt.SetDataSource(ds);

            crv_report.ReportSource = rpt;
            crv_report.Refresh();
        }
    }
}
