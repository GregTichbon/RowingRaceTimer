namespace RowingRaceTimer
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_StartTime = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageStart = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dg_starttime = new System.Windows.Forms.DataGridView();
            this.raceCrewsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageFinish = new System.Windows.Forms.TabPage();
            this.btn_MaintToggle = new System.Windows.Forms.Button();
            this.dg_endtime = new System.Windows.Forms.DataGridView();
            this.tabPageResults = new System.Windows.Forms.TabPage();
            this.btn_loadresults = new System.Windows.Forms.Button();
            this.dg_results = new System.Windows.Forms.DataGridView();
            this.btn_end = new System.Windows.Forms.Button();
            this.rowingRaceTimerDataSet1 = new RowingRaceTimer.RowingRaceTimerDataSet();
            this.raceCrewsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.raceCrewsTableAdapter1 = new RowingRaceTimer.RowingRaceTimerDataSetTableAdapters.RaceCrewsTableAdapter();
            this.StartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crew = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.raceCrewsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.FinishID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CrewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prognostic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_exportcsv = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_starttime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceCrewsBindingSource)).BeginInit();
            this.tabPageFinish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_endtime)).BeginInit();
            this.tabPageResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowingRaceTimerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceCrewsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceCrewsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_StartTime
            // 
            this.btn_StartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StartTime.Location = new System.Drawing.Point(882, 21);
            this.btn_StartTime.Name = "btn_StartTime";
            this.btn_StartTime.Size = new System.Drawing.Size(226, 59);
            this.btn_StartTime.TabIndex = 1;
            this.btn_StartTime.Text = "Start";
            this.btn_StartTime.UseVisualStyleBackColor = true;
            this.btn_StartTime.Click += new System.EventHandler(this.btn_StartTime_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 351;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_Timer
            // 
            this.lbl_Timer.AutoSize = true;
            this.lbl_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Timer.Location = new System.Drawing.Point(604, 21);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(83, 31);
            this.lbl_Timer.TabIndex = 2;
            this.lbl_Timer.Text = "Timer";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageStart);
            this.tabControl.Controls.Add(this.tabPageFinish);
            this.tabControl.Controls.Add(this.tabPageResults);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 99);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1338, 715);
            this.tabControl.TabIndex = 5;
            // 
            // tabPageStart
            // 
            this.tabPageStart.Controls.Add(this.button1);
            this.tabPageStart.Controls.Add(this.dg_starttime);
            this.tabPageStart.Location = new System.Drawing.Point(4, 33);
            this.tabPageStart.Name = "tabPageStart";
            this.tabPageStart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStart.Size = new System.Drawing.Size(1330, 678);
            this.tabPageStart.TabIndex = 0;
            this.tabPageStart.Text = "Start";
            this.tabPageStart.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1098, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Allow Maintenance";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dg_starttime
            // 
            this.dg_starttime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_starttime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_starttime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_starttime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartID,
            this.Time,
            this.Crew});
            this.dg_starttime.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dg_starttime.Location = new System.Drawing.Point(6, 6);
            this.dg_starttime.Name = "dg_starttime";
            this.dg_starttime.RowTemplate.Height = 35;
            this.dg_starttime.Size = new System.Drawing.Size(698, 666);
            this.dg_starttime.TabIndex = 1;
            this.dg_starttime.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_starttime_CellContentClick);
            this.dg_starttime.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_starttime_CellEndEdit);
            // 
            // raceCrewsBindingSource
            // 
            this.raceCrewsBindingSource.DataMember = "RaceCrews";
            // 
            // tabPageFinish
            // 
            this.tabPageFinish.Controls.Add(this.btn_MaintToggle);
            this.tabPageFinish.Controls.Add(this.dg_endtime);
            this.tabPageFinish.Location = new System.Drawing.Point(4, 33);
            this.tabPageFinish.Name = "tabPageFinish";
            this.tabPageFinish.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFinish.Size = new System.Drawing.Size(1330, 678);
            this.tabPageFinish.TabIndex = 1;
            this.tabPageFinish.Text = "Finish";
            this.tabPageFinish.UseVisualStyleBackColor = true;
            // 
            // btn_MaintToggle
            // 
            this.btn_MaintToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MaintToggle.Location = new System.Drawing.Point(1098, 6);
            this.btn_MaintToggle.Name = "btn_MaintToggle";
            this.btn_MaintToggle.Size = new System.Drawing.Size(226, 59);
            this.btn_MaintToggle.TabIndex = 5;
            this.btn_MaintToggle.Text = "Allow Maintenance";
            this.btn_MaintToggle.UseVisualStyleBackColor = true;
            // 
            // dg_endtime
            // 
            this.dg_endtime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_endtime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_endtime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FinishID,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewComboBoxColumn1});
            this.dg_endtime.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dg_endtime.Location = new System.Drawing.Point(6, 6);
            this.dg_endtime.Name = "dg_endtime";
            this.dg_endtime.RowTemplate.Height = 35;
            this.dg_endtime.Size = new System.Drawing.Size(700, 666);
            this.dg_endtime.TabIndex = 2;
            // 
            // tabPageResults
            // 
            this.tabPageResults.Controls.Add(this.btn_exportcsv);
            this.tabPageResults.Controls.Add(this.btn_loadresults);
            this.tabPageResults.Controls.Add(this.dg_results);
            this.tabPageResults.Location = new System.Drawing.Point(4, 33);
            this.tabPageResults.Name = "tabPageResults";
            this.tabPageResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResults.Size = new System.Drawing.Size(1330, 678);
            this.tabPageResults.TabIndex = 2;
            this.tabPageResults.Text = "Results";
            this.tabPageResults.UseVisualStyleBackColor = true;
            // 
            // btn_loadresults
            // 
            this.btn_loadresults.Location = new System.Drawing.Point(1206, 15);
            this.btn_loadresults.Name = "btn_loadresults";
            this.btn_loadresults.Size = new System.Drawing.Size(118, 49);
            this.btn_loadresults.TabIndex = 1;
            this.btn_loadresults.Text = "Load";
            this.btn_loadresults.UseVisualStyleBackColor = true;
            this.btn_loadresults.Click += new System.EventHandler(this.btn_loadresults_Click);
            // 
            // dg_results
            // 
            this.dg_results.AllowUserToAddRows = false;
            this.dg_results.AllowUserToDeleteRows = false;
            this.dg_results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CrewName,
            this.Prognostic,
            this.Expected,
            this.StartTime,
            this.FinishTime,
            this.TimeTaken,
            this.Score});
            this.dg_results.Location = new System.Drawing.Point(6, 6);
            this.dg_results.Name = "dg_results";
            this.dg_results.ReadOnly = true;
            this.dg_results.Size = new System.Drawing.Size(1194, 666);
            this.dg_results.TabIndex = 0;
            // 
            // btn_end
            // 
            this.btn_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_end.Location = new System.Drawing.Point(1114, 21);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(226, 59);
            this.btn_end.TabIndex = 6;
            this.btn_end.Text = "Finish";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // rowingRaceTimerDataSet1
            // 
            this.rowingRaceTimerDataSet1.DataSetName = "RowingRaceTimerDataSet";
            this.rowingRaceTimerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raceCrewsBindingSource1
            // 
            this.raceCrewsBindingSource1.DataMember = "RaceCrews";
            this.raceCrewsBindingSource1.DataSource = this.rowingRaceTimerDataSet1;
            // 
            // raceCrewsTableAdapter1
            // 
            this.raceCrewsTableAdapter1.ClearBeforeFill = true;
            // 
            // StartID
            // 
            this.StartID.HeaderText = "ID";
            this.StartID.Name = "StartID";
            this.StartID.Visible = false;
            this.StartID.Width = 52;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Time.Width = 150;
            // 
            // Crew
            // 
            this.Crew.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Crew.DataSource = this.raceCrewsBindingSource1;
            this.Crew.DisplayMember = "Crew";
            this.Crew.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Crew.HeaderText = "Crew";
            this.Crew.Name = "Crew";
            this.Crew.ReadOnly = true;
            this.Crew.ValueMember = "Crew_ID";
            this.Crew.Width = 500;
            // 
            // raceCrewsBindingSource2
            // 
            this.raceCrewsBindingSource2.DataMember = "RaceCrews";
            this.raceCrewsBindingSource2.DataSource = this.rowingRaceTimerDataSet1;
            // 
            // FinishID
            // 
            this.FinishID.HeaderText = "FinishID";
            this.FinishID.Name = "FinishID";
            this.FinishID.Visible = false;
            this.FinishID.Width = 103;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "Time";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewComboBoxColumn1.DataSource = this.raceCrewsBindingSource2;
            this.dataGridViewComboBoxColumn1.DisplayMember = "Crew";
            this.dataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn1.HeaderText = "Crew";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.ReadOnly = true;
            this.dataGridViewComboBoxColumn1.ValueMember = "Crew_ID";
            this.dataGridViewComboBoxColumn1.Width = 500;
            // 
            // CrewName
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CrewName.DefaultCellStyle = dataGridViewCellStyle1;
            this.CrewName.HeaderText = "Crew Name";
            this.CrewName.Name = "CrewName";
            this.CrewName.ReadOnly = true;
            this.CrewName.Width = 135;
            // 
            // Prognostic
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Prognostic.DefaultCellStyle = dataGridViewCellStyle2;
            this.Prognostic.HeaderText = "Prognostic";
            this.Prognostic.Name = "Prognostic";
            this.Prognostic.ReadOnly = true;
            this.Prognostic.Width = 124;
            // 
            // Expected
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Expected.DefaultCellStyle = dataGridViewCellStyle3;
            this.Expected.HeaderText = "Expected";
            this.Expected.Name = "Expected";
            this.Expected.ReadOnly = true;
            this.Expected.Width = 116;
            // 
            // StartTime
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.StartTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.StartTime.HeaderText = "Start Time";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Width = 119;
            // 
            // FinishTime
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.FinishTime.DefaultCellStyle = dataGridViewCellStyle5;
            this.FinishTime.HeaderText = "Finish Time";
            this.FinishTime.Name = "FinishTime";
            this.FinishTime.ReadOnly = true;
            this.FinishTime.Width = 134;
            // 
            // TimeTaken
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TimeTaken.DefaultCellStyle = dataGridViewCellStyle6;
            this.TimeTaken.HeaderText = "Taken";
            this.TimeTaken.Name = "TimeTaken";
            this.TimeTaken.ReadOnly = true;
            this.TimeTaken.Width = 88;
            // 
            // Score
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.Score.DefaultCellStyle = dataGridViewCellStyle7;
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Width = 85;
            // 
            // btn_exportcsv
            // 
            this.btn_exportcsv.Location = new System.Drawing.Point(1206, 70);
            this.btn_exportcsv.Name = "btn_exportcsv";
            this.btn_exportcsv.Size = new System.Drawing.Size(118, 47);
            this.btn_exportcsv.TabIndex = 2;
            this.btn_exportcsv.Text = "Export";
            this.btn_exportcsv.UseVisualStyleBackColor = true;
            this.btn_exportcsv.Click += new System.EventHandler(this.btn_exportcsv_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 826);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lbl_Timer);
            this.Controls.Add(this.btn_StartTime);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageStart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_starttime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceCrewsBindingSource)).EndInit();
            this.tabPageFinish.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_endtime)).EndInit();
            this.tabPageResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowingRaceTimerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceCrewsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceCrewsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_StartTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dg_starttime;
        private System.Windows.Forms.TabPage tabPageFinish;
        private System.Windows.Forms.Button btn_MaintToggle;
        private System.Windows.Forms.DataGridView dg_endtime;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.TabPage tabPageResults;
        private RowingRaceTimerDataSet rowingRaceTimerDataSet;
        private System.Windows.Forms.BindingSource raceCrewsBindingSource;
        private RowingRaceTimerDataSetTableAdapters.RaceCrewsTableAdapter raceCrewsTableAdapter;
        private System.Windows.Forms.DataGridView dg_results;
        private System.Windows.Forms.Button btn_loadresults;
        private RowingRaceTimerDataSet rowingRaceTimerDataSet1;
        private System.Windows.Forms.BindingSource raceCrewsBindingSource1;
        private RowingRaceTimerDataSetTableAdapters.RaceCrewsTableAdapter raceCrewsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewComboBoxColumn Crew;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.BindingSource raceCrewsBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrewName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prognostic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expected;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeTaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.Button btn_exportcsv;
    }
}