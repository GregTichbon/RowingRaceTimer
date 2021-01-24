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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_StartTime = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageStart = new System.Windows.Forms.TabPage();
            this.lbl_starttime = new System.Windows.Forms.Label();
            this.btn_MaintToggleStart = new System.Windows.Forms.Button();
            this.dg_starttime = new System.Windows.Forms.DataGridView();
            this.tabPageFinish = new System.Windows.Forms.TabPage();
            this.btn_MaintToggle = new System.Windows.Forms.Button();
            this.dg_endtime = new System.Windows.Forms.DataGridView();
            this.tabPageResults = new System.Windows.Forms.TabPage();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_exportcsv = new System.Windows.Forms.Button();
            this.btn_loadresults = new System.Windows.Forms.Button();
            this.dg_results = new System.Windows.Forms.DataGridView();
            this.tabPageCrews = new System.Windows.Forms.TabPage();
            this.dg_crews = new System.Windows.Forms.DataGridView();
            this.CrewID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoatNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoatAlpha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoatType1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrewName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prognostic1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPagePrognostics = new System.Windows.Forms.TabPage();
            this.dgPrognostics = new System.Windows.Forms.DataGridView();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoat = new System.Windows.Forms.ComboBox();
            this.cmbDiscipline = new System.Windows.Forms.ComboBox();
            this.btn_end = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainRacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setCurrentRaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearResultsForCurrentRaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rowingRaceTimerDataSet = new RowingRaceTimer.RowingRaceTimerDataSet();
            this.crewTableAdapter = new RowingRaceTimer.RowingRaceTimerDataSetTableAdapters.CrewTableAdapter();
            this.StartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrewStart = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FinishID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeFinish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrewFinish = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Race_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prognostic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpectedSeconds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TakenSeconds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Division = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoatType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_prognostic = new System.Windows.Forms.Label();
            this.P_Division = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.P_Gender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.P_PrognosticScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPageStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_starttime)).BeginInit();
            this.tabPageFinish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_endtime)).BeginInit();
            this.tabPageResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_results)).BeginInit();
            this.tabPageCrews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_crews)).BeginInit();
            this.tabPagePrognostics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrognostics)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowingRaceTimerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_StartTime
            // 
            this.btn_StartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_StartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StartTime.Location = new System.Drawing.Point(882, 21);
            this.btn_StartTime.Name = "btn_StartTime";
            this.btn_StartTime.Size = new System.Drawing.Size(226, 59);
            this.btn_StartTime.TabIndex = 1;
            this.btn_StartTime.Text = "Start (F1)";
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
            this.tabControl.Controls.Add(this.tabPageCrews);
            this.tabControl.Controls.Add(this.tabPagePrognostics);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 99);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1338, 715);
            this.tabControl.TabIndex = 5;
            // 
            // tabPageStart
            // 
            this.tabPageStart.Controls.Add(this.lbl_starttime);
            this.tabPageStart.Controls.Add(this.btn_MaintToggleStart);
            this.tabPageStart.Controls.Add(this.dg_starttime);
            this.tabPageStart.Location = new System.Drawing.Point(4, 33);
            this.tabPageStart.Name = "tabPageStart";
            this.tabPageStart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStart.Size = new System.Drawing.Size(1330, 678);
            this.tabPageStart.TabIndex = 0;
            this.tabPageStart.Text = "Start";
            this.tabPageStart.UseVisualStyleBackColor = true;
            // 
            // lbl_starttime
            // 
            this.lbl_starttime.AutoSize = true;
            this.lbl_starttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_starttime.Location = new System.Drawing.Point(24, 159);
            this.lbl_starttime.Name = "lbl_starttime";
            this.lbl_starttime.Size = new System.Drawing.Size(0, 39);
            this.lbl_starttime.TabIndex = 7;
            this.lbl_starttime.Visible = false;
            // 
            // btn_MaintToggleStart
            // 
            this.btn_MaintToggleStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MaintToggleStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MaintToggleStart.Location = new System.Drawing.Point(1098, 6);
            this.btn_MaintToggleStart.Name = "btn_MaintToggleStart";
            this.btn_MaintToggleStart.Size = new System.Drawing.Size(226, 59);
            this.btn_MaintToggleStart.TabIndex = 6;
            this.btn_MaintToggleStart.Text = "Allow Maintenance";
            this.btn_MaintToggleStart.UseVisualStyleBackColor = true;
            this.btn_MaintToggleStart.Click += new System.EventHandler(this.btn_MaintToggleStart_Click);
            // 
            // dg_starttime
            // 
            this.dg_starttime.AllowUserToDeleteRows = false;
            this.dg_starttime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_starttime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_starttime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_starttime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartID,
            this.StartNum,
            this.TimeStart,
            this.CrewStart});
            this.dg_starttime.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dg_starttime.Location = new System.Drawing.Point(3, 6);
            this.dg_starttime.Name = "dg_starttime";
            this.dg_starttime.RowTemplate.Height = 35;
            this.dg_starttime.Size = new System.Drawing.Size(1086, 666);
            this.dg_starttime.TabIndex = 1;
            this.dg_starttime.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_starttime_CellContentClick);
            this.dg_starttime.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_starttime_CellEndEdit);
            this.dg_starttime.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dg_starttime_RowsRemoved);
            this.dg_starttime.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dg_starttime_UserDeletingRow);
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
            this.btn_MaintToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MaintToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MaintToggle.Location = new System.Drawing.Point(1098, 6);
            this.btn_MaintToggle.Name = "btn_MaintToggle";
            this.btn_MaintToggle.Size = new System.Drawing.Size(226, 59);
            this.btn_MaintToggle.TabIndex = 5;
            this.btn_MaintToggle.Text = "Allow Maintenance";
            this.btn_MaintToggle.UseVisualStyleBackColor = true;
            this.btn_MaintToggle.Click += new System.EventHandler(this.btn_MaintToggle_Click);
            // 
            // dg_endtime
            // 
            this.dg_endtime.AllowUserToDeleteRows = false;
            this.dg_endtime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_endtime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_endtime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_endtime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FinishID,
            this.FinishNum,
            this.TimeFinish,
            this.CrewFinish});
            this.dg_endtime.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dg_endtime.Location = new System.Drawing.Point(6, 6);
            this.dg_endtime.Name = "dg_endtime";
            this.dg_endtime.RowTemplate.Height = 35;
            this.dg_endtime.Size = new System.Drawing.Size(1086, 666);
            this.dg_endtime.TabIndex = 2;
            this.dg_endtime.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_endtime_CellEndEdit);
            this.dg_endtime.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dg_endtime_UserDeletingRow);
            // 
            // tabPageResults
            // 
            this.tabPageResults.Controls.Add(this.btn_report);
            this.tabPageResults.Controls.Add(this.btn_Save);
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
            // btn_report
            // 
            this.btn_report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_report.Location = new System.Drawing.Point(1206, 176);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(118, 47);
            this.btn_report.TabIndex = 4;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Location = new System.Drawing.Point(1206, 123);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(118, 47);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_exportcsv
            // 
            this.btn_exportcsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exportcsv.Location = new System.Drawing.Point(1206, 70);
            this.btn_exportcsv.Name = "btn_exportcsv";
            this.btn_exportcsv.Size = new System.Drawing.Size(118, 47);
            this.btn_exportcsv.TabIndex = 2;
            this.btn_exportcsv.Text = "Export";
            this.btn_exportcsv.UseVisualStyleBackColor = true;
            this.btn_exportcsv.Click += new System.EventHandler(this.btn_exportcsv_Click);
            // 
            // btn_loadresults
            // 
            this.btn_loadresults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dg_results.AllowUserToOrderColumns = true;
            this.dg_results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Race_ID,
            this.CrewName,
            this.Prognostic,
            this.Expected,
            this.ExpectedSeconds,
            this.StartTime,
            this.FinishTime,
            this.TimeTaken,
            this.TakenSeconds,
            this.Score,
            this.Division,
            this.BoatType});
            this.dg_results.Location = new System.Drawing.Point(6, 6);
            this.dg_results.Name = "dg_results";
            this.dg_results.ReadOnly = true;
            this.dg_results.Size = new System.Drawing.Size(1194, 666);
            this.dg_results.TabIndex = 0;
            // 
            // tabPageCrews
            // 
            this.tabPageCrews.Controls.Add(this.dg_crews);
            this.tabPageCrews.Location = new System.Drawing.Point(4, 33);
            this.tabPageCrews.Name = "tabPageCrews";
            this.tabPageCrews.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCrews.Size = new System.Drawing.Size(1330, 678);
            this.tabPageCrews.TabIndex = 3;
            this.tabPageCrews.Text = "Crews";
            this.tabPageCrews.UseVisualStyleBackColor = true;
            // 
            // dg_crews
            // 
            this.dg_crews.AllowUserToOrderColumns = true;
            this.dg_crews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_crews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_crews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CrewID,
            this.BoatNumber,
            this.BoatAlpha,
            this.Club,
            this.BoatType1,
            this.CrewName1,
            this.Prognostic1});
            this.dg_crews.Location = new System.Drawing.Point(6, 6);
            this.dg_crews.Name = "dg_crews";
            this.dg_crews.Size = new System.Drawing.Size(1318, 666);
            this.dg_crews.TabIndex = 0;
            this.dg_crews.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_crews_CellEndEdit);
            this.dg_crews.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dg_crews_CellValidating);
            // 
            // CrewID
            // 
            this.CrewID.HeaderText = "CrewID";
            this.CrewID.Name = "CrewID";
            this.CrewID.ReadOnly = true;
            this.CrewID.Visible = false;
            // 
            // BoatNumber
            // 
            this.BoatNumber.HeaderText = "Boat Number";
            this.BoatNumber.Name = "BoatNumber";
            // 
            // BoatAlpha
            // 
            this.BoatAlpha.HeaderText = "Boat Alpha";
            this.BoatAlpha.Name = "BoatAlpha";
            // 
            // Club
            // 
            this.Club.HeaderText = "Club";
            this.Club.Name = "Club";
            // 
            // BoatType1
            // 
            this.BoatType1.HeaderText = "Boat Type";
            this.BoatType1.Name = "BoatType1";
            // 
            // CrewName1
            // 
            this.CrewName1.HeaderText = "Crew";
            this.CrewName1.Name = "CrewName1";
            // 
            // Prognostic1
            // 
            this.Prognostic1.HeaderText = "Prognostic";
            this.Prognostic1.Name = "Prognostic1";
            // 
            // tabPagePrognostics
            // 
            this.tabPagePrognostics.Controls.Add(this.lbl_prognostic);
            this.tabPagePrognostics.Controls.Add(this.dgPrognostics);
            this.tabPagePrognostics.Controls.Add(this.cmbGender);
            this.tabPagePrognostics.Controls.Add(this.cmbDivision);
            this.tabPagePrognostics.Controls.Add(this.label4);
            this.tabPagePrognostics.Controls.Add(this.label3);
            this.tabPagePrognostics.Controls.Add(this.label2);
            this.tabPagePrognostics.Controls.Add(this.label1);
            this.tabPagePrognostics.Controls.Add(this.cmbBoat);
            this.tabPagePrognostics.Controls.Add(this.cmbDiscipline);
            this.tabPagePrognostics.Location = new System.Drawing.Point(4, 33);
            this.tabPagePrognostics.Name = "tabPagePrognostics";
            this.tabPagePrognostics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrognostics.Size = new System.Drawing.Size(1330, 678);
            this.tabPagePrognostics.TabIndex = 4;
            this.tabPagePrognostics.Text = "Prognostics";
            this.tabPagePrognostics.UseVisualStyleBackColor = true;
            this.tabPagePrognostics.Click += new System.EventHandler(this.tabPagePrognostics_Click);
            // 
            // dgPrognostics
            // 
            this.dgPrognostics.AllowUserToAddRows = false;
            this.dgPrognostics.AllowUserToDeleteRows = false;
            this.dgPrognostics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPrognostics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgPrognostics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrognostics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P_Division,
            this.P_Gender,
            this.P_PrognosticScore});
            this.dgPrognostics.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgPrognostics.Location = new System.Drawing.Point(38, 240);
            this.dgPrognostics.Name = "dgPrognostics";
            this.dgPrognostics.RowTemplate.Height = 35;
            this.dgPrognostics.Size = new System.Drawing.Size(1086, 347);
            this.dgPrognostics.TabIndex = 8;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(158, 191);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(249, 32);
            this.cmbGender.TabIndex = 7;
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            // 
            // cmbDivision
            // 
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(160, 132);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(249, 32);
            this.cmbDivision.TabIndex = 6;
            this.cmbDivision.SelectedIndexChanged += new System.EventHandler(this.cmbDivision_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Division";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Boat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Discipline";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbBoat
            // 
            this.cmbBoat.FormattingEnabled = true;
            this.cmbBoat.Location = new System.Drawing.Point(160, 75);
            this.cmbBoat.Name = "cmbBoat";
            this.cmbBoat.Size = new System.Drawing.Size(249, 32);
            this.cmbBoat.TabIndex = 1;
            this.cmbBoat.SelectedIndexChanged += new System.EventHandler(this.cmbBoat_SelectedIndexChanged);
            // 
            // cmbDiscipline
            // 
            this.cmbDiscipline.FormattingEnabled = true;
            this.cmbDiscipline.Location = new System.Drawing.Point(160, 22);
            this.cmbDiscipline.Name = "cmbDiscipline";
            this.cmbDiscipline.Size = new System.Drawing.Size(249, 32);
            this.cmbDiscipline.TabIndex = 0;
            this.cmbDiscipline.SelectedIndexChanged += new System.EventHandler(this.cmbDiscipline_SelectedIndexChanged);
            // 
            // btn_end
            // 
            this.btn_end.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_end.Location = new System.Drawing.Point(1114, 21);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(226, 59);
            this.btn_end.TabIndex = 6;
            this.btn_end.Text = "Finish (F10)";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintainRacesToolStripMenuItem,
            this.setCurrentRaceToolStripMenuItem,
            this.clearResultsForCurrentRaceToolStripMenuItem,
            this.openDatabaseToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // maintainRacesToolStripMenuItem
            // 
            this.maintainRacesToolStripMenuItem.Name = "maintainRacesToolStripMenuItem";
            this.maintainRacesToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.maintainRacesToolStripMenuItem.Text = "Maintain Races (To do)";
            this.maintainRacesToolStripMenuItem.Click += new System.EventHandler(this.maintainRacesToolStripMenuItem_Click);
            // 
            // setCurrentRaceToolStripMenuItem
            // 
            this.setCurrentRaceToolStripMenuItem.Name = "setCurrentRaceToolStripMenuItem";
            this.setCurrentRaceToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.setCurrentRaceToolStripMenuItem.Text = "Set Current Race (To do)";
            this.setCurrentRaceToolStripMenuItem.Click += new System.EventHandler(this.setCurrentRaceToolStripMenuItem_Click);
            // 
            // clearResultsForCurrentRaceToolStripMenuItem
            // 
            this.clearResultsForCurrentRaceToolStripMenuItem.Name = "clearResultsForCurrentRaceToolStripMenuItem";
            this.clearResultsForCurrentRaceToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.clearResultsForCurrentRaceToolStripMenuItem.Text = "Clear Results for Current Race";
            this.clearResultsForCurrentRaceToolStripMenuItem.Click += new System.EventHandler(this.clearResultsForCurrentRaceToolStripMenuItem_Click);
            // 
            // openDatabaseToolStripMenuItem
            // 
            this.openDatabaseToolStripMenuItem.Name = "openDatabaseToolStripMenuItem";
            this.openDatabaseToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.openDatabaseToolStripMenuItem.Text = "Open Database";
            this.openDatabaseToolStripMenuItem.Click += new System.EventHandler(this.openDatabaseToolStripMenuItem_Click);
            // 
            // crewBindingSource
            // 
            this.crewBindingSource.DataMember = "Crew";
            this.crewBindingSource.DataSource = this.rowingRaceTimerDataSet;
            this.crewBindingSource.CurrentChanged += new System.EventHandler(this.crewBindingSource_CurrentChanged_1);
            // 
            // rowingRaceTimerDataSet
            // 
            this.rowingRaceTimerDataSet.DataSetName = "RowingRaceTimerDataSet";
            this.rowingRaceTimerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crewTableAdapter
            // 
            this.crewTableAdapter.ClearBeforeFill = true;
            // 
            // StartID
            // 
            this.StartID.HeaderText = "ID";
            this.StartID.Name = "StartID";
            this.StartID.Visible = false;
            this.StartID.Width = 52;
            // 
            // StartNum
            // 
            this.StartNum.HeaderText = "No.";
            this.StartNum.Name = "StartNum";
            this.StartNum.ReadOnly = true;
            this.StartNum.Width = 65;
            // 
            // TimeStart
            // 
            this.TimeStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TimeStart.HeaderText = "Time";
            this.TimeStart.Name = "TimeStart";
            this.TimeStart.ReadOnly = true;
            this.TimeStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TimeStart.Width = 150;
            // 
            // CrewStart
            // 
            this.CrewStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CrewStart.DataSource = this.crewBindingSource;
            this.CrewStart.DisplayMember = "Crew";
            this.CrewStart.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.CrewStart.HeaderText = "Crew";
            this.CrewStart.Name = "CrewStart";
            this.CrewStart.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CrewStart.ValueMember = "Crew_ID";
            this.CrewStart.Width = 880;
            // 
            // FinishID
            // 
            this.FinishID.HeaderText = "FinishID";
            this.FinishID.Name = "FinishID";
            this.FinishID.Visible = false;
            this.FinishID.Width = 103;
            // 
            // FinishNum
            // 
            this.FinishNum.HeaderText = "No.";
            this.FinishNum.Name = "FinishNum";
            this.FinishNum.ReadOnly = true;
            this.FinishNum.Width = 65;
            // 
            // TimeFinish
            // 
            this.TimeFinish.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TimeFinish.HeaderText = "Time";
            this.TimeFinish.Name = "TimeFinish";
            this.TimeFinish.ReadOnly = true;
            this.TimeFinish.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TimeFinish.Width = 150;
            // 
            // CrewFinish
            // 
            this.CrewFinish.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CrewFinish.DataSource = this.crewBindingSource;
            this.CrewFinish.DisplayMember = "Crew";
            this.CrewFinish.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.CrewFinish.HeaderText = "Crew";
            this.CrewFinish.Name = "CrewFinish";
            this.CrewFinish.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CrewFinish.ValueMember = "Crew_ID";
            this.CrewFinish.Width = 880;
            // 
            // Race_ID
            // 
            this.Race_ID.Frozen = true;
            this.Race_ID.HeaderText = "Race_ID";
            this.Race_ID.Name = "Race_ID";
            this.Race_ID.ReadOnly = true;
            this.Race_ID.Visible = false;
            this.Race_ID.Width = 106;
            // 
            // CrewName
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CrewName.DefaultCellStyle = dataGridViewCellStyle1;
            this.CrewName.Frozen = true;
            this.CrewName.HeaderText = "Crew";
            this.CrewName.Name = "CrewName";
            this.CrewName.ReadOnly = true;
            this.CrewName.Width = 79;
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
            // ExpectedSeconds
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ExpectedSeconds.DefaultCellStyle = dataGridViewCellStyle4;
            this.ExpectedSeconds.HeaderText = "Seconds";
            this.ExpectedSeconds.Name = "ExpectedSeconds";
            this.ExpectedSeconds.ReadOnly = true;
            this.ExpectedSeconds.Width = 110;
            // 
            // StartTime
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.StartTime.DefaultCellStyle = dataGridViewCellStyle5;
            this.StartTime.HeaderText = "Start Time";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Width = 119;
            // 
            // FinishTime
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.FinishTime.DefaultCellStyle = dataGridViewCellStyle6;
            this.FinishTime.HeaderText = "Finish Time";
            this.FinishTime.Name = "FinishTime";
            this.FinishTime.ReadOnly = true;
            this.FinishTime.Width = 134;
            // 
            // TimeTaken
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TimeTaken.DefaultCellStyle = dataGridViewCellStyle7;
            this.TimeTaken.HeaderText = "Taken";
            this.TimeTaken.Name = "TimeTaken";
            this.TimeTaken.ReadOnly = true;
            this.TimeTaken.Width = 88;
            // 
            // TakenSeconds
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TakenSeconds.DefaultCellStyle = dataGridViewCellStyle8;
            this.TakenSeconds.HeaderText = "Seconds";
            this.TakenSeconds.Name = "TakenSeconds";
            this.TakenSeconds.ReadOnly = true;
            this.TakenSeconds.Width = 110;
            // 
            // Score
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.Score.DefaultCellStyle = dataGridViewCellStyle9;
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Width = 85;
            // 
            // Division
            // 
            this.Division.HeaderText = "Division";
            this.Division.Name = "Division";
            this.Division.ReadOnly = true;
            this.Division.Visible = false;
            // 
            // BoatType
            // 
            this.BoatType.HeaderText = "BoatType";
            this.BoatType.Name = "BoatType";
            this.BoatType.ReadOnly = true;
            this.BoatType.Width = 115;
            // 
            // lbl_prognostic
            // 
            this.lbl_prognostic.AutoSize = true;
            this.lbl_prognostic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prognostic.Location = new System.Drawing.Point(677, 75);
            this.lbl_prognostic.Name = "lbl_prognostic";
            this.lbl_prognostic.Size = new System.Drawing.Size(0, 31);
            this.lbl_prognostic.TabIndex = 9;
            this.lbl_prognostic.Click += new System.EventHandler(this.label5_Click);
            // 
            // P_Division
            // 
            this.P_Division.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.P_Division.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.P_Division.HeaderText = "Division";
            this.P_Division.Name = "P_Division";
            this.P_Division.ReadOnly = true;
            // 
            // P_Gender
            // 
            this.P_Gender.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.P_Gender.HeaderText = "Gender";
            this.P_Gender.Name = "P_Gender";
            this.P_Gender.ReadOnly = true;
            this.P_Gender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.P_Gender.Width = 80;
            // 
            // P_PrognosticScore
            // 
            this.P_PrognosticScore.HeaderText = "PrognosticScore";
            this.P_PrognosticScore.Name = "P_PrognosticScore";
            this.P_PrognosticScore.ReadOnly = true;
            this.P_PrognosticScore.Width = 174;
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
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageStart.ResumeLayout(false);
            this.tabPageStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_starttime)).EndInit();
            this.tabPageFinish.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_endtime)).EndInit();
            this.tabPageResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_results)).EndInit();
            this.tabPageCrews.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_crews)).EndInit();
            this.tabPagePrognostics.ResumeLayout(false);
            this.tabPagePrognostics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrognostics)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowingRaceTimerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_StartTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageStart;
        private System.Windows.Forms.Button btn_MaintToggleStart;
        private System.Windows.Forms.DataGridView dg_starttime;
        private System.Windows.Forms.TabPage tabPageFinish;
        private System.Windows.Forms.Button btn_MaintToggle;
        private System.Windows.Forms.DataGridView dg_endtime;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.TabPage tabPageResults;
        //private RowingRaceTimerDataSet rowingRaceTimerDataSet;
        //private RowingRaceTimerDataSetTableAdapters.RaceCrewsTableAdapter raceCrewsTableAdapter;
        private System.Windows.Forms.DataGridView dg_results;
        private System.Windows.Forms.Button btn_loadresults;
        private System.Windows.Forms.Button btn_exportcsv;
        private System.Windows.Forms.Label lbl_starttime;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.TabPage tabPageCrews;
        private System.Windows.Forms.DataGridView dg_crews;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainRacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setCurrentRaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearResultsForCurrentRaceToolStripMenuItem;
        //private System.Windows.Forms.DataGridViewTextBoxColumn boatNumberDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn boatAlphaDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn clubDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn crewNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrewID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoatNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoatAlpha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Club;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoatType1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrewName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prognostic1;
        private System.Windows.Forms.ToolStripMenuItem openDatabaseToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPagePrognostics;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoat;
        private System.Windows.Forms.ComboBox cmbDiscipline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.DataGridView dgPrognostics;
        private RowingRaceTimerDataSet rowingRaceTimerDataSet;
        private System.Windows.Forms.BindingSource crewBindingSource;
        private RowingRaceTimerDataSetTableAdapters.CrewTableAdapter crewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStart;
        private System.Windows.Forms.DataGridViewComboBoxColumn CrewStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeFinish;
        private System.Windows.Forms.DataGridViewComboBoxColumn CrewFinish;
        private System.Windows.Forms.DataGridViewTextBoxColumn Race_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrewName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prognostic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expected;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpectedSeconds;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeTaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn TakenSeconds;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Division;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoatType;
        private System.Windows.Forms.Label lbl_prognostic;
        private System.Windows.Forms.DataGridViewComboBoxColumn P_Division;
        private System.Windows.Forms.DataGridViewComboBoxColumn P_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_PrognosticScore;
    }
}