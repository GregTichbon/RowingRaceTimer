namespace RowingRaceTimer
{
    partial class RaceResults
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaceResults));
            this.crv_report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Results1 = new RowingRaceTimer.Results();
            this.SuspendLayout();
            // 
            // crv_report
            // 
            this.crv_report.ActiveViewIndex = 0;
            this.crv_report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_report.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_report.Location = new System.Drawing.Point(0, 0);
            this.crv_report.Name = "crv_report";
            this.crv_report.ReportSource = this.Results1;
            this.crv_report.Size = new System.Drawing.Size(1506, 687);
            this.crv_report.TabIndex = 0;
            this.crv_report.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // RaceResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 687);
            this.Controls.Add(this.crv_report);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RaceResults";
            this.Text = "RaceResults";
            this.Load += new System.EventHandler(this.RaceResults_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_report;
        private Results Results1;
    }
}