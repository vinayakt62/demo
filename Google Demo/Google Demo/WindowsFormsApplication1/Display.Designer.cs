namespace WindowsFormsApplication1
{
    partial class Display
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
            this.tblNameBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._C__PROGRAM_FILES_MICROSOFT_SQL_SERVER_MSSQL_1_MSSQL_DATA_GOOGLEDEMO_MDFDataSet = new WindowsFormsApplication1._C__PROGRAM_FILES_MICROSOFT_SQL_SERVER_MSSQL_1_MSSQL_DATA_GOOGLEDEMO_MDFDataSet();
            this.tblNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.googleDemoDataSet = new WindowsFormsApplication1.GoogleDemoDataSet();
            this.tblNameTableAdapter = new WindowsFormsApplication1.GoogleDemoDataSetTableAdapters.tblNameTableAdapter();
            this.tblNameTableAdapter1 = new WindowsFormsApplication1._C__PROGRAM_FILES_MICROSOFT_SQL_SERVER_MSSQL_1_MSSQL_DATA_GOOGLEDEMO_MDFDataSetTableAdapters.tblNameTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNameBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__PROGRAM_FILES_MICROSOFT_SQL_SERVER_MSSQL_1_MSSQL_DATA_GOOGLEDEMO_MDFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.googleDemoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.noDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblNameBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 213);
            this.dataGridView1.TabIndex = 0;
            // 
            // tblNameBindingSource1
            // 
            this.tblNameBindingSource1.DataMember = "tblName";
            this.tblNameBindingSource1.DataSource = this._C__PROGRAM_FILES_MICROSOFT_SQL_SERVER_MSSQL_1_MSSQL_DATA_GOOGLEDEMO_MDFDataSet;
            // 
            // _C__PROGRAM_FILES_MICROSOFT_SQL_SERVER_MSSQL_1_MSSQL_DATA_GOOGLEDEMO_MDFDataSet
            // 
            this._C__PROGRAM_FILES_MICROSOFT_SQL_SERVER_MSSQL_1_MSSQL_DATA_GOOGLEDEMO_MDFDataSet.DataSetName = "_C__PROGRAM_FILES_MICROSOFT_SQL_SERVER_MSSQL_1_MSSQL_DATA_GOOGLEDEMO_MDFDataSet";
            this._C__PROGRAM_FILES_MICROSOFT_SQL_SERVER_MSSQL_1_MSSQL_DATA_GOOGLEDEMO_MDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNameBindingSource
            // 
            this.tblNameBindingSource.DataMember = "tblName";
            this.tblNameBindingSource.DataSource = this.googleDemoDataSet;
            // 
            // googleDemoDataSet
            // 
            this.googleDemoDataSet.DataSetName = "GoogleDemoDataSet";
            this.googleDemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNameTableAdapter
            // 
            this.tblNameTableAdapter.ClearBeforeFill = true;
            // 
            // tblNameTableAdapter1
            // 
            this.tblNameTableAdapter1.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "UpdateRecord";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 282);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Display";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display";
            this.Load += new System.EventHandler(this.Display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNameBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__PROGRAM_FILES_MICROSOFT_SQL_SERVER_MSSQL_1_MSSQL_DATA_GOOGLEDEMO_MDFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.googleDemoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GoogleDemoDataSet googleDemoDataSet;
        private System.Windows.Forms.BindingSource tblNameBindingSource;
        private WindowsFormsApplication1.GoogleDemoDataSetTableAdapters.tblNameTableAdapter tblNameTableAdapter;
        private _C__PROGRAM_FILES_MICROSOFT_SQL_SERVER_MSSQL_1_MSSQL_DATA_GOOGLEDEMO_MDFDataSet _C__PROGRAM_FILES_MICROSOFT_SQL_SERVER_MSSQL_1_MSSQL_DATA_GOOGLEDEMO_MDFDataSet;
        private System.Windows.Forms.BindingSource tblNameBindingSource1;
        private WindowsFormsApplication1._C__PROGRAM_FILES_MICROSOFT_SQL_SERVER_MSSQL_1_MSSQL_DATA_GOOGLEDEMO_MDFDataSetTableAdapters.tblNameTableAdapter tblNameTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}