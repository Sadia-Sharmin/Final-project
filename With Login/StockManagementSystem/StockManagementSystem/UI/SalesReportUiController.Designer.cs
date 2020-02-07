namespace StockManagementSystem.UI
{
    partial class SalesReportUiController
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReportUiController));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalesReportDataGridView = new System.Windows.Forms.DataGridView();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saleEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.salesStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateErrorLabel = new System.Windows.Forms.Label();
            this.startDateErrorLabel = new System.Windows.Forms.Label();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesReportViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseReportViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseReportViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SalesReportDataGridView);
            this.panel1.Location = new System.Drawing.Point(2, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 414);
            this.panel1.TabIndex = 45;
            // 
            // SalesReportDataGridView
            // 
            this.SalesReportDataGridView.AllowUserToAddRows = false;
            this.SalesReportDataGridView.AllowUserToResizeRows = false;
            this.SalesReportDataGridView.AutoGenerateColumns = false;
            this.SalesReportDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.SalesReportDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.SalesReportDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesReportDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SalesReportDataGridView.ColumnHeadersHeight = 30;
            this.SalesReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SalesReportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.soldQtyDataGridViewTextBoxColumn,
            this.cPDataGridViewTextBoxColumn,
            this.salesPriceDataGridViewTextBoxColumn,
            this.profitDataGridViewTextBoxColumn});
            this.SalesReportDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalesReportDataGridView.DataSource = this.salesReportViewModelBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SalesReportDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.SalesReportDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesReportDataGridView.EnableHeadersVisualStyles = false;
            this.SalesReportDataGridView.GridColor = System.Drawing.Color.White;
            this.SalesReportDataGridView.Location = new System.Drawing.Point(0, 0);
            this.SalesReportDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SalesReportDataGridView.Name = "SalesReportDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesReportDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SalesReportDataGridView.RowHeadersVisible = false;
            this.SalesReportDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SalesReportDataGridView.RowTemplate.Height = 24;
            this.SalesReportDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SalesReportDataGridView.Size = new System.Drawing.Size(840, 414);
            this.SalesReportDataGridView.TabIndex = 21;
            this.SalesReportDataGridView.TabStop = false;
            this.SalesReportDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.SalesReportDataGridView_RowPostPaint);
            // 
            // Sl
            // 
            this.Sl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sl.HeaderText = "#";
            this.Sl.Name = "Sl";
            this.Sl.Width = 37;
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
            this.searchButton.Location = new System.Drawing.Point(611, 17);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(76, 20);
            this.searchButton.TabIndex = 44;
            this.searchButton.Text = "     Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Start Date";
            // 
            // saleEndDateTimePicker
            // 
            this.saleEndDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.saleEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.saleEndDateTimePicker.Location = new System.Drawing.Point(460, 17);
            this.saleEndDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saleEndDateTimePicker.Name = "saleEndDateTimePicker";
            this.saleEndDateTimePicker.Size = new System.Drawing.Size(127, 20);
            this.saleEndDateTimePicker.TabIndex = 46;
            this.saleEndDateTimePicker.ValueChanged += new System.EventHandler(this.saleEndDateTimePicker_ValueChanged);
            // 
            // salesStartDateTimePicker
            // 
            this.salesStartDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.salesStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.salesStartDateTimePicker.Location = new System.Drawing.Point(233, 17);
            this.salesStartDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salesStartDateTimePicker.Name = "salesStartDateTimePicker";
            this.salesStartDateTimePicker.Size = new System.Drawing.Size(127, 20);
            this.salesStartDateTimePicker.TabIndex = 47;
            this.salesStartDateTimePicker.ValueChanged += new System.EventHandler(this.salesStartDateTimePicker_ValueChanged);
            // 
            // endDateErrorLabel
            // 
            this.endDateErrorLabel.AutoSize = true;
            this.endDateErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.endDateErrorLabel.Location = new System.Drawing.Point(458, 37);
            this.endDateErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endDateErrorLabel.Name = "endDateErrorLabel";
            this.endDateErrorLabel.Size = new System.Drawing.Size(75, 13);
            this.endDateErrorLabel.TabIndex = 48;
            this.endDateErrorLabel.Text = "Error Message";
            // 
            // startDateErrorLabel
            // 
            this.startDateErrorLabel.AutoSize = true;
            this.startDateErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.startDateErrorLabel.Location = new System.Drawing.Point(233, 37);
            this.startDateErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startDateErrorLabel.Name = "startDateErrorLabel";
            this.startDateErrorLabel.Size = new System.Drawing.Size(75, 13);
            this.startDateErrorLabel.TabIndex = 49;
            this.startDateErrorLabel.Text = "Error Message";
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
            // soldQtyDataGridViewTextBoxColumn
            // 
            this.soldQtyDataGridViewTextBoxColumn.DataPropertyName = "SoldQty";
            this.soldQtyDataGridViewTextBoxColumn.HeaderText = "SoldQty";
            this.soldQtyDataGridViewTextBoxColumn.Name = "soldQtyDataGridViewTextBoxColumn";
            // 
            // cPDataGridViewTextBoxColumn
            // 
            this.cPDataGridViewTextBoxColumn.DataPropertyName = "CP";
            this.cPDataGridViewTextBoxColumn.HeaderText = "CP";
            this.cPDataGridViewTextBoxColumn.Name = "cPDataGridViewTextBoxColumn";
            // 
            // salesPriceDataGridViewTextBoxColumn
            // 
            this.salesPriceDataGridViewTextBoxColumn.DataPropertyName = "SalesPrice";
            this.salesPriceDataGridViewTextBoxColumn.HeaderText = "SalesPrice";
            this.salesPriceDataGridViewTextBoxColumn.Name = "salesPriceDataGridViewTextBoxColumn";
            // 
            // profitDataGridViewTextBoxColumn
            // 
            this.profitDataGridViewTextBoxColumn.DataPropertyName = "Profit";
            this.profitDataGridViewTextBoxColumn.HeaderText = "Profit";
            this.profitDataGridViewTextBoxColumn.Name = "profitDataGridViewTextBoxColumn";
            // 
            // salesReportViewModelBindingSource
            // 
            this.salesReportViewModelBindingSource.DataSource = typeof(StockManagementSystem.Model.SalesReportViewModel);
            // 
            // purchaseReportViewModelBindingSource
            // 
            this.purchaseReportViewModelBindingSource.DataSource = typeof(StockManagementSystem.Model.PurchaseReportViewModel);
            // 
            // SalesReportUiController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.endDateErrorLabel);
            this.Controls.Add(this.startDateErrorLabel);
            this.Controls.Add(this.saleEndDateTimePicker);
            this.Controls.Add(this.salesStartDateTimePicker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SalesReportUiController";
            this.Size = new System.Drawing.Size(844, 497);
            this.Load += new System.EventHandler(this.SalesReportUiController_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseReportViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView SalesReportDataGridView;
        private System.Windows.Forms.BindingSource purchaseReportViewModelBindingSource;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker saleEndDateTimePicker;
        public System.Windows.Forms.DateTimePicker salesStartDateTimePicker;
        private System.Windows.Forms.BindingSource salesReportViewModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label endDateErrorLabel;
        private System.Windows.Forms.Label startDateErrorLabel;
    }
}
