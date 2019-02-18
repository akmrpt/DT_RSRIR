namespace MyWinApp
{
    partial class frmIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndex));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus_lbl_LoginName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus_lbl_FYear = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mASTERMENUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mENUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pARENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISPLAYNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dLLNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSACTIVEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new MyWinApp.DataSet1();
            this.mASTERMENUTableAdapter = new MyWinApp.DataSet1TableAdapters.MASTERMENUTableAdapter();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASTERMENUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus_lbl_LoginName,
            this.toolStripStatus_lbl_FYear});
            this.statusStrip1.Location = new System.Drawing.Point(0, 412);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(836, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatus_lbl_LoginName
            // 
            this.toolStripStatus_lbl_LoginName.Name = "toolStripStatus_lbl_LoginName";
            this.toolStripStatus_lbl_LoginName.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatus_lbl_LoginName.Text = "Login User :";
            // 
            // toolStripStatus_lbl_FYear
            // 
            this.toolStripStatus_lbl_FYear.Name = "toolStripStatus_lbl_FYear";
            this.toolStripStatus_lbl_FYear.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatus_lbl_FYear.Text = "FiscalYear :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(185, 383);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mENUIDDataGridViewTextBoxColumn,
            this.pARENTIDDataGridViewTextBoxColumn,
            this.dISPLAYNAMEDataGridViewTextBoxColumn,
            this.dLLNAMEDataGridViewTextBoxColumn,
            this.iSACTIVEDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.mASTERMENUBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(239, 48);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(378, 263);
            this.dataGridView2.TabIndex = 3;
            // 
            // mASTERMENUBindingSource
            // 
            this.mASTERMENUBindingSource.DataMember = "MASTERMENU";
            this.mASTERMENUBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // mENUIDDataGridViewTextBoxColumn
            // 
            this.mENUIDDataGridViewTextBoxColumn.DataPropertyName = "MENUID";
            this.mENUIDDataGridViewTextBoxColumn.HeaderText = "MENUID";
            this.mENUIDDataGridViewTextBoxColumn.Name = "mENUIDDataGridViewTextBoxColumn";
            // 
            // pARENTIDDataGridViewTextBoxColumn
            // 
            this.pARENTIDDataGridViewTextBoxColumn.DataPropertyName = "PARENTID";
            this.pARENTIDDataGridViewTextBoxColumn.HeaderText = "PARENTID";
            this.pARENTIDDataGridViewTextBoxColumn.Name = "pARENTIDDataGridViewTextBoxColumn";
            // 
            // dISPLAYNAMEDataGridViewTextBoxColumn
            // 
            this.dISPLAYNAMEDataGridViewTextBoxColumn.DataPropertyName = "DISPLAYNAME";
            this.dISPLAYNAMEDataGridViewTextBoxColumn.HeaderText = "DISPLAYNAME";
            this.dISPLAYNAMEDataGridViewTextBoxColumn.Name = "dISPLAYNAMEDataGridViewTextBoxColumn";
            // 
            // dLLNAMEDataGridViewTextBoxColumn
            // 
            this.dLLNAMEDataGridViewTextBoxColumn.DataPropertyName = "DLLNAME";
            this.dLLNAMEDataGridViewTextBoxColumn.HeaderText = "DLLNAME";
            this.dLLNAMEDataGridViewTextBoxColumn.Name = "dLLNAMEDataGridViewTextBoxColumn";
            // 
            // iSACTIVEDataGridViewTextBoxColumn
            // 
            this.iSACTIVEDataGridViewTextBoxColumn.DataPropertyName = "ISACTIVE";
            this.iSACTIVEDataGridViewTextBoxColumn.HeaderText = "ISACTIVE";
            this.iSACTIVEDataGridViewTextBoxColumn.Name = "iSACTIVEDataGridViewTextBoxColumn";
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mASTERMENUTableAdapter
            // 
            this.mASTERMENUTableAdapter.ClearBeforeFill = true;
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 434);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Index";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmIndex_FormClosed);
            this.Load += new System.EventHandler(this.frmIndex_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASTERMENUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_lbl_LoginName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_lbl_FYear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource mASTERMENUBindingSource;
        private DataSet1TableAdapters.MASTERMENUTableAdapter mASTERMENUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mENUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISPLAYNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dLLNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSACTIVEDataGridViewTextBoxColumn;
    }
}