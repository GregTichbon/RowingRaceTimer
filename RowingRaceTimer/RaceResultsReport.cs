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
            /*
            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\RowingRaceTimer\RowingRaceTimer.accdb";
            DataSet ds = new DataSet();
            */

            ReportDocument rpt = new ReportDocument();
            rpt.Load("C:\\RowingRaceTimer\\results.rpt");

            /*
            OleDbConnection con = new OleDbConnection(ConnectionString);
            string sql = @"SELECT RaceResults.Prognostic, RaceResults.StartTime, RaceResults.FinishTime, RaceResults.Taken, RaceResults.Score, RaceResults.BoatType, Race.RaceName, Race.RaceDateTime, Race.Distance, RaceResults.CrewName
                     FROM RaceResults RaceResults INNER JOIN Race Race ON RaceResults.Race_ID=Race.Race_ID 
                     where RaceResults.race_id = 5
                     ORDER BY RaceResults.Score DESC";
            OleDbCommand cmd = new OleDbCommand(sql);


            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            OleDbDataAdapter adp = new OleDbDataAdapter();
            adp.SelectCommand = cmd;


            adp.Fill(ds);
            
            rpt.SetDataSource(ds.Tables["Table"]);

            //rpt.DataSourceConnections[0].SetConnection("", "C:\\RowingRaceTimer\\RowingRaceTimer.accdbx", false);
            //rpt.DataSourceConnections[1].SetConnection("", "C:\\RowingRaceTimer\\RowingRaceTimer.accdb", false);

            // if password is given then give the password
            // if not give it will ask at runtime
            //rpt.DataSourceConnections[0].SetLogon("", "");
            */

            crv_report.ReportSource = rpt;
            crv_report.Refresh();
        }
    }
}
