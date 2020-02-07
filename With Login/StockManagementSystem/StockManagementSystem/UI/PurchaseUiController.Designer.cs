namespace StockManagementSystem.UI
{
    partial class PurchaseUiController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseUiController));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.addPurchaseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.purchaseDataGridView = new System.Windows.Forms.DataGridView();
            this.purchaseDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.endDateErrorLabel = new System.Windows.Forms.Label();
            this.startDateErrorLabel = new System.Windows.Forms.Label();
            this.purchaseEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.purchaseStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.purchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewImageColumn();
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.minimizeButton);
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1120, 40);
            this.topPanel.TabIndex = 6;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(1285, 17);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(23, 14);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(1331, 12);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(23, 25);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // addPurchaseButton
            // 
            this.addPurchaseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addPurchaseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPurchaseButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addPurchaseButton.FlatAppearance.BorderSize = 0;
            this.addPurchaseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.addPurchaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPurchaseButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPurchaseButton.ForeColor = System.Drawing.Color.White;
            this.addPurchaseButton.Image = ((System.Drawing.Image)(resources.GetObject("addPurchaseButton.Image")));
            this.addPurchaseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPurchaseButton.Location = new System.Drawing.Point(21, 57);
            this.addPurchaseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addPurchaseButton.Name = "addPurchaseButton";
            this.addPurchaseButton.Size = new System.Drawing.Size(188, 40);
            this.addPurchaseButton.TabIndex = 18;
            this.addPurchaseButton.Text = "       Add Purchase Item";
            this.addPurchaseButton.UseVisualStyleBackColor = false;
            this.addPurchaseButton.Click += new System.EventHandler(this.addPurchaseButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.purchaseDataGridView);
            this.panel1.Location = new System.Drawing.Point(21, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 581);
            this.panel1.TabIndex = 20;
            // 
            // purchaseDataGridView
            // 
            this.purchaseDataGridView.AllowUserToAddRows = false;
            this.purchaseDataGridView.AllowUserToResizeRows = false;
            this.purchaseDataGridView.AutoGenerateColumns = false;
            this.purchaseDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.purchaseDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.purchaseDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.purchaseDataGridView.ColumnHeadersHeight = 30;
            this.purchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.purchaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.idDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.supplierDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.Details});
            this.purchaseDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchaseDataGridView.DataSource = this.purchaseDetailsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purchaseDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.purchaseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseDataGridView.EnableHeadersVisualStyles = false;
            this.purchaseDataGridView.GridColor = System.Drawing.Color.White;
            this.purchaseDataGridView.Location = new System.Drawing.Point(0, 0);
            this.purchaseDataGridView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.purchaseDataGridView.Name = "purchaseDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.purchaseDataGridView.RowHeadersVisible = false;
            this.purchaseDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.purchaseDataGridView.RowTemplate.Height = 24;
            this.purchaseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchaseDataGridView.Size = new System.Drawing.Size(1083, 581);
            this.purchaseDataGridView.TabIndex = 21;
            this.purchaseDataGridView.TabStop = false;
            this.purchaseDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseDataGridView_CellContentClick);
            this.purchaseDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.purchaseDataGridView_RowPostPaint);
            // 
            // purchaseDetailsBindingSource
            // 
            this.purchaseDetailsBindingSource.DataSource = typeof(StockManagementSystem.Model.PurchaseDetails);
            // 
            // endDateErrorLabel
            // 
            this.endDateErrorLabel.AutoSize = true;
            this.endDateErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.endDateErrorLabel.Location = new System.Drawing.Point(789, 97);
            this.endDateErrorLabel.Name = "endDateErrorLabel";
            this.endDateErrorLabel.Size = new System.Drawing.Size(101, 17);
            this.endDateErrorLabel.TabIndex = 47;
            this.endDateErrorLabel.Text = "Error Message";
            // 
            // startDateErrorLabel
            // 
            this.startDateErrorLabel.AutoSize = true;
            this.startDateErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.startDateErrorLabel.Location = new System.Drawing.Point(489, 97);
            this.startDateErrorLabel.Name = "startDateErrorLabel";
            this.startDateErrorLabel.Size = new System.Drawing.Size(101, 17);
            this.startDateErrorLabel.TabIndex = 48;
            this.startDateErrorLabel.Text = "Error Message";
            // 
            // purchaseEndDateTimePicker
            // 
            this.purchaseEndDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.purchaseEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.purchaseEndDateTimePicker.Location = new System.Drawing.Point(792, 70);
            this.purchaseEndDateTimePicker.Name = "purchaseEndDateTimePicker";
            this.purchaseEndDateTimePicker.Size = new System.Drawing.Size(168, 22);
            this.purchaseEndDateTimePicker.TabIndex = 45;
            this.purchaseEndDateTimePicker.ValueChanged += new System.EventHandler(this.purchaseEndDateTimePicker_ValueChanged);
            // 
            // purchaseStartDateTimePicker
            // 
            this.purchaseStartDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.purchaseStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.purchaseStartDateTimePicker.Location = new System.Drawing.Point(489, 68);
            this.purchaseStartDateTimePicker.Name = "purchaseStartDateTimePicker";
            this.purchaseStartDateTimePicker.Size = new System.Drawing.Size(168, 22);
            this.purchaseStartDateTimePicker.TabIndex = 46;
            this.purchaseStartDateTimePicker.ValueChanged += new System.EventHandler(this.purchaseStartDateTimePicker_ValueChanged);
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
            this.searchButton.Location = new System.Drawing.Point(983, 67);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(102, 30);
            this.searchButton.TabIndex = 44;
            this.searchButton.Text = "     Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(718, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Start Date";
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshButton.Location = new System.Drawing.Point(230, 57);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(108, 40);
            this.refreshButton.TabIndex = 18;
            this.refreshButton.Text = "       Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // purchaseBindingSource
            // 
            this.purchaseBindingSource.DataSource = typeof(StockManagementSystem.Model.Purchase);
            // 
            // Sl
            // 
            this.Sl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sl.HeaderText = "#";
            this.Sl.Name = "Sl";
            this.Sl.Width = 43;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InvoiceNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "InvoiceNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 97;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn2.HeaderText = "Code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 68;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SupplierId";
            this.dataGridViewTextBoxColumn3.HeaderText = "SupplierId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 65;
            // 
            // Details
            // 
            this.Details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Details.HeaderText = "Details";
            this.Details.Image = ((System.Drawing.Image)(resources.GetObject("Details.Image")));
            this.Details.Name = "Details";
            this.Details.Width = 55;
            // 
            // PurchaseUiController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.endDateErrorLabel);
            this.Controls.Add(this.startDateErrorLabel);
            this.Controls.Add(this.purchaseEndDateTimePicker);
            this.Controls.Add(this.purchaseStartDateTimePicker);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.addPurchaseButton);
            this.Controls.Add(this.topPanel);
            this.Name = "PurchaseUiController";
            this.Size = new System.Drawing.Size(1120, 726);
            this.Load += new System.EventHandler(this.PurchaseUiController_Load);
            this.topPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button addPurchaseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource purchaseBindingSource;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNoDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn supplierIdDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView purchaseDataGridView;
        private System.Windows.Forms.BindingSource purchaseDetailsBindingSource;
        private System.Windows.Forms.Label endDateErrorLabel;
        private System.Windows.Forms.Label startDateErrorLabel;
        public System.Windows.Forms.DateTimePicker purchaseEndDateTimePicker;
        public System.Windows.Forms.DateTimePicker purchaseStartDateTimePicker;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn Details;
    }
}
