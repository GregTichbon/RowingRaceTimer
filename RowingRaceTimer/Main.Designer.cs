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
            this.btn_StartTime = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageStart = new System.Windows.Forms.TabPage();
            this.tabPageFinish = new System.Windows.Forms.TabPage();
            this.dg_starttime = new System.Windows.Forms.DataGridView();
            this.dg_endtime = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btn_end = new System.Windows.Forms.Button();
            this.btn_MaintToggle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPageResults = new System.Windows.Forms.TabPage();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crew = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPageStart.SuspendLayout();
            this.tabPageFinish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_starttime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_endtime)).BeginInit();
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
            // dg_starttime
            // 
            this.dg_starttime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_starttime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_starttime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_starttime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Crew});
            this.dg_starttime.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dg_starttime.Location = new System.Drawing.Point(6, 6);
            this.dg_starttime.Name = "dg_starttime";
            this.dg_starttime.RowTemplate.Height = 35;
            this.dg_starttime.Size = new System.Drawing.Size(698, 666);
            this.dg_starttime.TabIndex = 1;
            // 
            // dg_endtime
            // 
            this.dg_endtime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_endtime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_endtime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewComboBoxColumn1});
            this.dg_endtime.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dg_endtime.Location = new System.Drawing.Point(6, 6);
            this.dg_endtime.Name = "dg_endtime";
            this.dg_endtime.Size = new System.Drawing.Size(577, 566);
            this.dg_endtime.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Time";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 59;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn1.HeaderText = "Crew";
            this.dataGridViewComboBoxColumn1.Items.AddRange(new object[] {
            "1 Testting",
            "2 Testting",
            "3 Testting",
            "4 Testting",
            "5 Testting"});
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Width = 60;
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
            // tabPageResults
            // 
            this.tabPageResults.Location = new System.Drawing.Point(4, 33);
            this.tabPageResults.Name = "tabPageResults";
            this.tabPageResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResults.Size = new System.Drawing.Size(1330, 577);
            this.tabPageResults.TabIndex = 2;
            this.tabPageResults.Text = "Results";
            this.tabPageResults.UseVisualStyleBackColor = true;
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
            this.Crew.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Crew.HeaderText = "Crew";
            this.Crew.Items.AddRange(new object[] {
            "1 Testting",
            "2 Testting",
            "3 Testting",
            "4 Testting",
            "5 Testting"});
            this.Crew.Name = "Crew";
            this.Crew.Width = 500;
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
            this.tabPageFinish.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_starttime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_endtime)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.TabPage tabPageResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewComboBoxColumn Crew;
    }
}