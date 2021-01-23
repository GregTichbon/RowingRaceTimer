namespace RowingRaceTimer
{
    partial class Races
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.raceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raceDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singleStartDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.prognosticsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.raceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rowingRaceTimerDataSet2 = new RowingRaceTimer.RowingRaceTimerDataSet2();
            this.raceTableAdapter = new RowingRaceTimer.RowingRaceTimerDataSet2TableAdapters.RaceTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowingRaceTimerDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.raceIDDataGridViewTextBoxColumn,
            this.raceNameDataGridViewTextBoxColumn,
            this.raceDateTimeDataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn,
            this.singleStartDataGridViewCheckBoxColumn,
            this.prognosticsDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.raceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // raceIDDataGridViewTextBoxColumn
            // 
            this.raceIDDataGridViewTextBoxColumn.DataPropertyName = "Race_ID";
            this.raceIDDataGridViewTextBoxColumn.HeaderText = "Race_ID";
            this.raceIDDataGridViewTextBoxColumn.Name = "raceIDDataGridViewTextBoxColumn";
            this.raceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.raceIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // raceNameDataGridViewTextBoxColumn
            // 
            this.raceNameDataGridViewTextBoxColumn.DataPropertyName = "RaceName";
            this.raceNameDataGridViewTextBoxColumn.HeaderText = "RaceName";
            this.raceNameDataGridViewTextBoxColumn.Name = "raceNameDataGridViewTextBoxColumn";
            // 
            // raceDateTimeDataGridViewTextBoxColumn
            // 
            this.raceDateTimeDataGridViewTextBoxColumn.DataPropertyName = "RaceDateTime";
            this.raceDateTimeDataGridViewTextBoxColumn.HeaderText = "RaceDateTime";
            this.raceDateTimeDataGridViewTextBoxColumn.Name = "raceDateTimeDataGridViewTextBoxColumn";
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "Distance";
            this.distanceDataGridViewTextBoxColumn.HeaderText = "Distance";
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            // 
            // singleStartDataGridViewCheckBoxColumn
            // 
            this.singleStartDataGridViewCheckBoxColumn.DataPropertyName = "SingleStart";
            this.singleStartDataGridViewCheckBoxColumn.HeaderText = "SingleStart";
            this.singleStartDataGridViewCheckBoxColumn.Name = "singleStartDataGridViewCheckBoxColumn";
            // 
            // prognosticsDataGridViewCheckBoxColumn
            // 
            this.prognosticsDataGridViewCheckBoxColumn.DataPropertyName = "Prognostics";
            this.prognosticsDataGridViewCheckBoxColumn.HeaderText = "Prognostics";
            this.prognosticsDataGridViewCheckBoxColumn.Name = "prognosticsDataGridViewCheckBoxColumn";
            // 
            // raceBindingSource
            // 
            this.raceBindingSource.DataMember = "Race";
            this.raceBindingSource.DataSource = this.rowingRaceTimerDataSet2;
            this.raceBindingSource.CurrentChanged += new System.EventHandler(this.raceBindingSource_CurrentChanged);
            // 
            // rowingRaceTimerDataSet2
            // 
            this.rowingRaceTimerDataSet2.DataSetName = "RowingRaceTimerDataSet2";
            this.rowingRaceTimerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raceTableAdapter
            // 
            this.raceTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.raceBindingSource;
            this.comboBox1.DisplayMember = "RaceName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 365);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(459, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Race_ID";
            // 
            // Races
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Races";
            this.Text = "Races";
            this.Load += new System.EventHandler(this.Races_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowingRaceTimerDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RowingRaceTimerDataSet2 rowingRaceTimerDataSet2;
        private System.Windows.Forms.BindingSource raceBindingSource;
        private RowingRaceTimerDataSet2TableAdapters.RaceTableAdapter raceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn singleStartDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn prognosticsDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}