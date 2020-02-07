namespace StockManagementSystem.UI
{
    partial class PurchaseReportUiController
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseReportUiController));
            this.panel1 = new System.Windows.Forms.Panel();
            this.purchaseReportDataGridView = new System.Windows.Forms.DataGridView();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseReportViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.purchaseStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.purchaseEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateErrorLabel = new System.Windows.Forms.Label();
            this.endDateErrorLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseReportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseReportViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.purchaseReportDataGridView);
            this.panel1.Location = new System.Drawing.Point(3, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 509);
            this.panel1.TabIndex = 39;
            // 
            // purchaseReportDataGridView
            // 
            this.purchaseReportDataGridView.AllowUserToAddRows = false;
            this.purchaseReportDataGridView.AllowUserToResizeRows = false;
            this.purchaseReportDataGridView.AutoGenerateColumns = false;
            this.purchaseReportDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.purchaseReportDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.purchaseReportDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseReportDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.purchaseReportDataGridView.ColumnHeadersHeight = 30;
            this.purchaseReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.purchaseReportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.availableQtyDataGridViewTextBoxColumn,
            this.cPDataGridViewTextBoxColumn,
            this.mRPDataGridViewTextBoxColumn,
            this.profitDataGridViewTextBoxColumn});
            this.purchaseReportDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchaseReportDataGridView.DataSource = this.purchaseReportViewModelBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purchaseReportDataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.purchaseReportDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseReportDataGridView.EnableHeadersVisualStyles = false;
            this.purchaseReportDataGridView.GridColor = System.Drawing.Color.White;
            this.purchaseReportDataGridView.Location = new System.Drawing.Point(0, 0);
            this.purchaseReportDataGridView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.purchaseReportDataGridView.Name = "purchaseReportDataGridView";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseReportDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.purchaseReportDataGridView.RowHeadersVisible = false;
            this.purchaseReportDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.purchaseReportDataGridView.RowTemplate.Height = 24;
            this.purchaseReportDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchaseReportDataGridView.Size = new System.Drawing.Size(1120, 509);
            this.purchaseReportDataGridView.TabIndex = 21;
            this.purchaseReportDataGridView.TabStop = false;
            this.purchaseReportDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.purchaseReportDataGridView_RowPostPaint);
            // 
            // Sl
            // 
            this.Sl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sl.HeaderText = "#";
            this.Sl.Name = "Sl";
            this.Sl.Width = 43;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // availableQtyDataGridViewTextBoxColumn
            // 
            this.availableQtyDataGridViewTextBoxColumn.DataPropertyName = "AvailableQty";
            this.availableQtyDataGridViewTextBoxColumn.HeaderText = "AvailableQty";
            this.availableQtyDataGridViewTextBoxColumn.Name = "availableQtyDataGridViewTextBoxColumn";
            // 
            // cPDataGridViewTextBoxColumn
            // 
            this.cPDataGridViewTextBoxColumn.DataPropertyName = "CP";
            this.cPDataGridViewTextBoxColumn.HeaderText = "CP";
            this.cPDataGridViewTextBoxColumn.Name = "cPDataGridViewTextBoxColumn";
            // 
            // mRPDataGridViewTextBoxColumn
            // 
            this.mRPDataGridViewTextBoxColumn.DataPropertyName = "MRP";
            this.mRPDataGridViewTextBoxColumn.HeaderText = "MRP";
            this.mRPDataGridViewTextBoxColumn.Name = "mRPDataGridViewTextBoxColumn";
            // 
            // profitDataGridViewTextBoxColumn
            // 
            this.profitDataGridViewTextBoxColumn.DataPropertyName = "Profit";
            this.profitDataGridViewTextBoxColumn.HeaderText = "Profit";
            this.profitDataGridViewTextBoxColumn.Name = "profitDataGridViewTextBoxColumn";
            // 
            // purchaseReportViewModelBindingSource
            // 
            this.purchaseReportViewModelBindingSource.DataSource = typeof(StockManagementSystem.Model.PurchaseReportViewModel);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.Location = new System.Drawing.Point(818, 20);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(102, 24);
            this.searchButton.TabIndex = 38;
            this.searchButton.Text = "     Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Start Date";
            // 
            // purchaseStartDateTimePicker
            // 
            this.purchaseStartDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.purchaseStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.purchaseStartDateTimePicker.Location = new System.Drawing.Point(311, 20);
            this.purchaseStartDateTimePicker.Name = "purchaseStartDateTimePicker";
            this.purchaseStartDateTimePicker.Size = new System.Drawing.Size(168, 22);
            this.purchaseStartDateTimePicker.TabIndex = 40;
            this.purchaseStartDateTimePicker.ValueChanged += new System.EventHandler(this.purchaseStartDateTimePicker_ValueChanged);
            // 
            // purchaseEndDateTimePicker
            // 
            this.purchaseEndDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.purchaseEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.purchaseEndDateTimePicker.Location = new System.Drawing.Point(614, 22);
            this.purchaseEndDateTimePicker.Name = "purchaseEndDateTimePicker";
            this.purchaseEndDateTimePicker.Size = new System.Drawing.Size(168, 22);
            this.purchaseEndDateTimePicker.TabIndex = 40;
            this.purchaseEndDateTimePicker.ValueChanged += new System.EventHandler(this.purchaseEndDateTimePicker_ValueChanged);
            // 
            // startDateErrorLabel
            // 
            this.startDateErrorLabel.AutoSize = true;
            this.startDateErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.startDateErrorLabel.Location = new System.Drawing.Point(311, 49);
            this.startDateErrorLabel.Name = "startDateErrorLabel";
            this.startDateErrorLabel.Size = new System.Drawing.Size(101, 17);
            this.startDateErrorLabel.TabIndex = 41;
            this.startDateErrorLabel.Text = "Error Message";
            // 
            // endDateErrorLabel
            // 
            this.endDateErrorLabel.AutoSize = true;
            this.endDateErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.endDateErrorLabel.Location = new System.Drawing.Point(611, 49);
            this.endDateErrorLabel.Name = "endDateErrorLabel";
            this.endDateErrorLabel.Size = new System.Drawing.Size(101, 17);
            this.endDateErrorLabel.TabIndex = 41;
            this.endDateErrorLabel.Text = "Error Message";
            // 
            // PurchaseReportUiController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.endDateErrorLabel);
            this.Controls.Add(this.startDateErrorLabel);
            this.Controls.Add(this.purchaseEndDateTimePicker);
            this.Controls.Add(this.purchaseStartDateTimePicker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "PurchaseReportUiController";
            this.Size = new System.Drawing.Size(1126, 612);
            this.Load += new System.EventHandler(this.PurchaseReportUiController_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseReportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseReportViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView purchaseReportDataGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource purchaseReportViewModelBindingSource;
        public System.Windows.Forms.DateTimePicker purchaseStartDateTimePicker;
        public System.Windows.Forms.DateTimePicker purchaseEndDateTimePicker;
        private System.Windows.Forms.Label startDateErrorLabel;
        private System.Windows.Forms.Label endDateErrorLabel;
    }
}
