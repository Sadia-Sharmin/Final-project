namespace StockManagementSystem.UI
{
    partial class StockUiController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockUiController));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.productComboBoxErrorLabel = new System.Windows.Forms.Label();
            this.categoryComboboxerrorLabel = new System.Windows.Forms.Label();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stockDataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.endDateErrorLabel = new System.Windows.Forms.Label();
            this.startDateErrorLabel = new System.Windows.Forms.Label();
            this.stockBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.stockBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closingBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource3)).BeginInit();
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
            this.topPanel.Size = new System.Drawing.Size(1132, 40);
            this.topPanel.TabIndex = 7;
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
            // productComboBoxErrorLabel
            // 
            this.productComboBoxErrorLabel.AutoSize = true;
            this.productComboBoxErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.productComboBoxErrorLabel.Location = new System.Drawing.Point(303, 133);
            this.productComboBoxErrorLabel.Name = "productComboBoxErrorLabel";
            this.productComboBoxErrorLabel.Size = new System.Drawing.Size(101, 17);
            this.productComboBoxErrorLabel.TabIndex = 12;
            this.productComboBoxErrorLabel.Text = "Error Message";
            // 
            // categoryComboboxerrorLabel
            // 
            this.categoryComboboxerrorLabel.AutoSize = true;
            this.categoryComboboxerrorLabel.ForeColor = System.Drawing.Color.Red;
            this.categoryComboboxerrorLabel.Location = new System.Drawing.Point(303, 87);
            this.categoryComboboxerrorLabel.Name = "categoryComboboxerrorLabel";
            this.categoryComboboxerrorLabel.Size = new System.Drawing.Size(101, 17);
            this.categoryComboboxerrorLabel.TabIndex = 13;
            this.categoryComboboxerrorLabel.Text = "Error Message";
            // 
            // productComboBox
            // 
            this.productComboBox.DisplayMember = "Name";
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(306, 106);
            this.productComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(168, 24);
            this.productComboBox.TabIndex = 10;
            this.productComboBox.ValueMember = "Id";
            this.productComboBox.SelectedIndexChanged += new System.EventHandler(this.productComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Product";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(306, 59);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(168, 24);
            this.categoryComboBox.TabIndex = 11;
            this.categoryComboBox.ValueMember = "Id";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Category";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(667, 106);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(168, 22);
            this.endDateTimePicker.TabIndex = 16;
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.endDateTimePicker_ValueChanged);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(667, 57);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(168, 22);
            this.startDateTimePicker.TabIndex = 17;
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.startDateTimePicker_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(593, 107);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "End Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(593, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Start Date";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stockDataGridView);
            this.panel1.Location = new System.Drawing.Point(20, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 497);
            this.panel1.TabIndex = 18;
            // 
            // stockDataGridView
            // 
            this.stockDataGridView.AllowUserToAddRows = false;
            this.stockDataGridView.AllowUserToResizeRows = false;
            this.stockDataGridView.AutoGenerateColumns = false;
            this.stockDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.stockDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.stockDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.stockDataGridView.ColumnHeadersHeight = 30;
            this.stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.stockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.codeDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.reorderLevelDataGridViewTextBoxColumn,
            this.openingBalanceDataGridViewTextBoxColumn,
            this.inDataGridViewTextBoxColumn,
            this.outDataGridViewTextBoxColumn,
            this.closingBalanceDataGridViewTextBoxColumn});
            this.stockDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stockDataGridView.DataSource = this.stockBindingSource3;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stockDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.stockDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockDataGridView.EnableHeadersVisualStyles = false;
            this.stockDataGridView.GridColor = System.Drawing.Color.White;
            this.stockDataGridView.Location = new System.Drawing.Point(0, 0);
            this.stockDataGridView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.stockDataGridView.Name = "stockDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.stockDataGridView.RowHeadersVisible = false;
            this.stockDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.stockDataGridView.RowTemplate.Height = 24;
            this.stockDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockDataGridView.Size = new System.Drawing.Size(1094, 497);
            this.stockDataGridView.TabIndex = 20;
            this.stockDataGridView.TabStop = false;
            this.stockDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.purchaseDataGridView_RowPostPaint);
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
            this.searchButton.Location = new System.Drawing.Point(733, 154);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(102, 38);
            this.searchButton.TabIndex = 19;
            this.searchButton.Text = "     Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // endDateErrorLabel
            // 
            this.endDateErrorLabel.AutoSize = true;
            this.endDateErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.endDateErrorLabel.Location = new System.Drawing.Point(664, 133);
            this.endDateErrorLabel.Name = "endDateErrorLabel";
            this.endDateErrorLabel.Size = new System.Drawing.Size(101, 17);
            this.endDateErrorLabel.TabIndex = 42;
            this.endDateErrorLabel.Text = "Error Message";
            // 
            // startDateErrorLabel
            // 
            this.startDateErrorLabel.AutoSize = true;
            this.startDateErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.startDateErrorLabel.Location = new System.Drawing.Point(664, 82);
            this.startDateErrorLabel.Name = "startDateErrorLabel";
            this.startDateErrorLabel.Size = new System.Drawing.Size(101, 17);
            this.startDateErrorLabel.TabIndex = 43;
            this.startDateErrorLabel.Text = "Error Message";
            // 
            // stockBindingSource2
            // 
            this.stockBindingSource2.DataSource = typeof(StockManagementSystem.Model.Stock);
            // 
            // stockBindingSource1
            // 
            this.stockBindingSource1.DataSource = typeof(StockManagementSystem.Model.Stock);
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataSource = typeof(StockManagementSystem.Model.Stock);
            // 
            // stockBindingSource3
            // 
            this.stockBindingSource3.DataSource = typeof(StockManagementSystem.Model.Stock);
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
            this.codeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.Width = 68;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 92;
            // 
            // reorderLevelDataGridViewTextBoxColumn
            // 
            this.reorderLevelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.reorderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.HeaderText = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.Name = "reorderLevelDataGridViewTextBoxColumn";
            this.reorderLevelDataGridViewTextBoxColumn.Width = 121;
            // 
            // openingBalanceDataGridViewTextBoxColumn
            // 
            this.openingBalanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.openingBalanceDataGridViewTextBoxColumn.DataPropertyName = "OpeningBalance";
            this.openingBalanceDataGridViewTextBoxColumn.HeaderText = "OpeningBalance";
            this.openingBalanceDataGridViewTextBoxColumn.Name = "openingBalanceDataGridViewTextBoxColumn";
            this.openingBalanceDataGridViewTextBoxColumn.Width = 140;
            // 
            // inDataGridViewTextBoxColumn
            // 
            this.inDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.inDataGridViewTextBoxColumn.DataPropertyName = "In";
            this.inDataGridViewTextBoxColumn.HeaderText = "In";
            this.inDataGridViewTextBoxColumn.Name = "inDataGridViewTextBoxColumn";
            this.inDataGridViewTextBoxColumn.Width = 46;
            // 
            // outDataGridViewTextBoxColumn
            // 
            this.outDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.outDataGridViewTextBoxColumn.DataPropertyName = "Out";
            this.outDataGridViewTextBoxColumn.HeaderText = "Out";
            this.outDataGridViewTextBoxColumn.Name = "outDataGridViewTextBoxColumn";
            this.outDataGridViewTextBoxColumn.Width = 58;
            // 
            // closingBalanceDataGridViewTextBoxColumn
            // 
            this.closingBalanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.closingBalanceDataGridViewTextBoxColumn.DataPropertyName = "ClosingBalance";
            this.closingBalanceDataGridViewTextBoxColumn.HeaderText = "ClosingBalance";
            this.closingBalanceDataGridViewTextBoxColumn.Name = "closingBalanceDataGridViewTextBoxColumn";
            this.closingBalanceDataGridViewTextBoxColumn.Width = 132;
            // 
            // StockUiController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.endDateErrorLabel);
            this.Controls.Add(this.startDateErrorLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.productComboBoxErrorLabel);
            this.Controls.Add(this.categoryComboboxerrorLabel);
            this.Controls.Add(this.productComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.topPanel);
            this.Name = "StockUiController";
            this.Size = new System.Drawing.Size(1132, 726);
            this.Load += new System.EventHandler(this.StockUiController_Load);
            this.topPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label productComboBoxErrorLabel;
        private System.Windows.Forms.Label categoryComboboxerrorLabel;
        public System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker endDateTimePicker;
        public System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource stockBindingSource;
        public System.Windows.Forms.DataGridView stockDataGridView;
        private System.Windows.Forms.BindingSource stockBindingSource1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label endDateErrorLabel;
        private System.Windows.Forms.Label startDateErrorLabel;
        private System.Windows.Forms.BindingSource stockBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closingBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stockBindingSource3;
    }
}
