namespace StockManagementSystem.UI
{
    partial class SupplierUiController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierUiController));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.showAllSupplierButton = new System.Windows.Forms.Button();
            this.addSupplierButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactRadioButton = new System.Windows.Forms.RadioButton();
            this.emailRadioButton = new System.Windows.Forms.RadioButton();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.searchTextBoxErrorLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // showAllSupplierButton
            // 
            this.showAllSupplierButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showAllSupplierButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showAllSupplierButton.FlatAppearance.BorderSize = 0;
            this.showAllSupplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllSupplierButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllSupplierButton.ForeColor = System.Drawing.Color.White;
            this.showAllSupplierButton.Image = ((System.Drawing.Image)(resources.GetObject("showAllSupplierButton.Image")));
            this.showAllSupplierButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showAllSupplierButton.Location = new System.Drawing.Point(16, 104);
            this.showAllSupplierButton.Name = "showAllSupplierButton";
            this.showAllSupplierButton.Size = new System.Drawing.Size(135, 31);
            this.showAllSupplierButton.TabIndex = 66;
            this.showAllSupplierButton.Text = "All Supplier";
            this.showAllSupplierButton.UseVisualStyleBackColor = false;
            this.showAllSupplierButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // addSupplierButton
            // 
            this.addSupplierButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addSupplierButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSupplierButton.FlatAppearance.BorderSize = 0;
            this.addSupplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSupplierButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSupplierButton.ForeColor = System.Drawing.Color.White;
            this.addSupplierButton.Image = ((System.Drawing.Image)(resources.GetObject("addSupplierButton.Image")));
            this.addSupplierButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addSupplierButton.Location = new System.Drawing.Point(13, 54);
            this.addSupplierButton.Name = "addSupplierButton";
            this.addSupplierButton.Size = new System.Drawing.Size(138, 31);
            this.addSupplierButton.TabIndex = 67;
            this.addSupplierButton.Text = "Add Supplier";
            this.addSupplierButton.UseVisualStyleBackColor = false;
            this.addSupplierButton.Click += new System.EventHandler(this.addSupplierButton_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1132, 32);
            this.topPanel.TabIndex = 65;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.showDataGridView);
            this.panel1.Location = new System.Drawing.Point(16, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 546);
            this.panel1.TabIndex = 63;
            // 
            // showDataGridView
            // 
            this.showDataGridView.AllowUserToAddRows = false;
            this.showDataGridView.AllowUserToResizeRows = false;
            this.showDataGridView.AutoGenerateColumns = false;
            this.showDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.showDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.showDataGridView.ColumnHeadersHeight = 30;
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.showDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.contactPersonDataGridViewTextBoxColumn,
            this.Edit});
            this.showDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showDataGridView.DataSource = this.supplierBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.showDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.showDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showDataGridView.EnableHeadersVisualStyles = false;
            this.showDataGridView.Location = new System.Drawing.Point(0, 0);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.RowHeadersVisible = false;
            this.showDataGridView.RowHeadersWidth = 51;
            this.showDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showDataGridView.Size = new System.Drawing.Size(1103, 546);
            this.showDataGridView.TabIndex = 0;
            this.showDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showDataGridView_CellContentClick);
            this.showDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.showDataGridView_RowPostPaint);
            // 
            // Sl
            // 
            this.Sl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sl.HeaderText = "#";
            this.Sl.MinimumWidth = 6;
            this.Sl.Name = "Sl";
            this.Sl.Width = 43;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.Width = 68;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 72;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 69;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.Width = 83;
            // 
            // contactPersonDataGridViewTextBoxColumn
            // 
            this.contactPersonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.contactPersonDataGridViewTextBoxColumn.DataPropertyName = "ContactPerson";
            this.contactPersonDataGridViewTextBoxColumn.HeaderText = "ContactPerson";
            this.contactPersonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactPersonDataGridViewTextBoxColumn.Name = "contactPersonDataGridViewTextBoxColumn";
            this.contactPersonDataGridViewTextBoxColumn.Width = 128;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "Action";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Width = 51;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(StockManagementSystem.Model.Supplier);
            // 
            // contactRadioButton
            // 
            this.contactRadioButton.AutoSize = true;
            this.contactRadioButton.Location = new System.Drawing.Point(234, 3);
            this.contactRadioButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.contactRadioButton.Name = "contactRadioButton";
            this.contactRadioButton.Size = new System.Drawing.Size(77, 21);
            this.contactRadioButton.TabIndex = 62;
            this.contactRadioButton.Text = "Contact";
            this.contactRadioButton.UseVisualStyleBackColor = true;
            // 
            // emailRadioButton
            // 
            this.emailRadioButton.AutoSize = true;
            this.emailRadioButton.Location = new System.Drawing.Point(155, 3);
            this.emailRadioButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.emailRadioButton.Name = "emailRadioButton";
            this.emailRadioButton.Size = new System.Drawing.Size(63, 21);
            this.emailRadioButton.TabIndex = 61;
            this.emailRadioButton.Text = "Email";
            this.emailRadioButton.UseVisualStyleBackColor = true;
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Checked = true;
            this.nameRadioButton.Location = new System.Drawing.Point(78, 3);
            this.nameRadioButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(66, 21);
            this.nameRadioButton.TabIndex = 60;
            this.nameRadioButton.TabStop = true;
            this.nameRadioButton.Text = "Name";
            this.nameRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBoxErrorLabel
            // 
            this.searchTextBoxErrorLabel.AutoSize = true;
            this.searchTextBoxErrorLabel.Location = new System.Drawing.Point(75, 58);
            this.searchTextBoxErrorLabel.Name = "searchTextBoxErrorLabel";
            this.searchTextBoxErrorLabel.Size = new System.Drawing.Size(79, 17);
            this.searchTextBoxErrorLabel.TabIndex = 70;
            this.searchTextBoxErrorLabel.Text = "Error Label";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(80, 33);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(231, 22);
            this.searchTextBox.TabIndex = 68;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchTextBoxErrorLabel);
            this.groupBox1.Controls.Add(this.nameRadioButton);
            this.groupBox1.Controls.Add(this.emailRadioButton);
            this.groupBox1.Controls.Add(this.searchTextBox);
            this.groupBox1.Controls.Add(this.contactRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(238, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 77);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // SupplierUiController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showAllSupplierButton);
            this.Controls.Add(this.addSupplierButton);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SupplierUiController";
            this.Size = new System.Drawing.Size(1132, 720);
            this.Load += new System.EventHandler(this.SupplierUiController_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showAllSupplierButton;
        private System.Windows.Forms.Button addSupplierButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.RadioButton contactRadioButton;
        private System.Windows.Forms.RadioButton emailRadioButton;
        private System.Windows.Forms.RadioButton nameRadioButton;
        private System.Windows.Forms.Label searchTextBoxErrorLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
    }
}
