namespace StockManagementSystem.UI
{
    partial class CategoryUiController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryUiController));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.allCategoryButton = new System.Windows.Forms.Button();
            this.codeRadioButton = new System.Windows.Forms.RadioButton();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.categoryViewPanel = new System.Windows.Forms.Panel();
            this.categoryDataGridView = new System.Windows.Forms.DataGridView();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.topPanelCategory = new System.Windows.Forms.Panel();
            this.Search = new System.Windows.Forms.GroupBox();
            this.categoryViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.topPanelCategory.SuspendLayout();
            this.Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // allCategoryButton
            // 
            this.allCategoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.allCategoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allCategoryButton.FlatAppearance.BorderSize = 0;
            this.allCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allCategoryButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allCategoryButton.ForeColor = System.Drawing.Color.White;
            this.allCategoryButton.Image = ((System.Drawing.Image)(resources.GetObject("allCategoryButton.Image")));
            this.allCategoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allCategoryButton.Location = new System.Drawing.Point(12, 108);
            this.allCategoryButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allCategoryButton.Name = "allCategoryButton";
            this.allCategoryButton.Size = new System.Drawing.Size(144, 31);
            this.allCategoryButton.TabIndex = 16;
            this.allCategoryButton.Text = "       All Category";
            this.allCategoryButton.UseVisualStyleBackColor = false;
            this.allCategoryButton.Click += new System.EventHandler(this.allCategoryButton_Click);
            // 
            // codeRadioButton
            // 
            this.codeRadioButton.AutoSize = true;
            this.codeRadioButton.Location = new System.Drawing.Point(108, 36);
            this.codeRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.codeRadioButton.Name = "codeRadioButton";
            this.codeRadioButton.Size = new System.Drawing.Size(62, 21);
            this.codeRadioButton.TabIndex = 15;
            this.codeRadioButton.TabStop = true;
            this.codeRadioButton.Text = "Code";
            this.codeRadioButton.UseVisualStyleBackColor = true;
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Location = new System.Drawing.Point(19, 36);
            this.nameRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(66, 21);
            this.nameRadioButton.TabIndex = 14;
            this.nameRadioButton.TabStop = true;
            this.nameRadioButton.Text = "Name";
            this.nameRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(178, 34);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(222, 22);
            this.searchTextBox.TabIndex = 13;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyUp);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addCategoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCategoryButton.FlatAppearance.BorderSize = 0;
            this.addCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategoryButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryButton.ForeColor = System.Drawing.Color.White;
            this.addCategoryButton.Image = ((System.Drawing.Image)(resources.GetObject("addCategoryButton.Image")));
            this.addCategoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCategoryButton.Location = new System.Drawing.Point(12, 54);
            this.addCategoryButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(144, 31);
            this.addCategoryButton.TabIndex = 17;
            this.addCategoryButton.Text = "       Add Category";
            this.addCategoryButton.UseVisualStyleBackColor = false;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // categoryViewPanel
            // 
            this.categoryViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryViewPanel.Controls.Add(this.categoryDataGridView);
            this.categoryViewPanel.Location = new System.Drawing.Point(12, 148);
            this.categoryViewPanel.Name = "categoryViewPanel";
            this.categoryViewPanel.Size = new System.Drawing.Size(1106, 563);
            this.categoryViewPanel.TabIndex = 12;
            // 
            // categoryDataGridView
            // 
            this.categoryDataGridView.AllowUserToAddRows = false;
            this.categoryDataGridView.AllowUserToResizeRows = false;
            this.categoryDataGridView.AutoGenerateColumns = false;
            this.categoryDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.categoryDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.categoryDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.categoryDataGridView.ColumnHeadersHeight = 30;
            this.categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.categoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.Edit});
            this.categoryDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryDataGridView.DataSource = this.categoryBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoryDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.categoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryDataGridView.EnableHeadersVisualStyles = false;
            this.categoryDataGridView.GridColor = System.Drawing.Color.White;
            this.categoryDataGridView.Location = new System.Drawing.Point(0, 0);
            this.categoryDataGridView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.categoryDataGridView.Name = "categoryDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.categoryDataGridView.RowHeadersVisible = false;
            this.categoryDataGridView.RowHeadersWidth = 51;
            this.categoryDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.categoryDataGridView.RowTemplate.Height = 24;
            this.categoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoryDataGridView.Size = new System.Drawing.Size(1106, 563);
            this.categoryDataGridView.TabIndex = 0;
            this.categoryDataGridView.TabStop = false;
            this.categoryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryDataGridView_CellContentClick);
            this.categoryDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.categoryDataGridView_RowPostPaint);
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
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
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
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(StockManagementSystem.Model.Category);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(1284, 17);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.closeButton.Location = new System.Drawing.Point(1332, 12);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(23, 25);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // topPanelCategory
            // 
            this.topPanelCategory.BackColor = System.Drawing.Color.White;
            this.topPanelCategory.Controls.Add(this.minimizeButton);
            this.topPanelCategory.Controls.Add(this.closeButton);
            this.topPanelCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanelCategory.Location = new System.Drawing.Point(0, 0);
            this.topPanelCategory.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.topPanelCategory.Name = "topPanelCategory";
            this.topPanelCategory.Size = new System.Drawing.Size(1132, 32);
            this.topPanelCategory.TabIndex = 11;
            // 
            // Search
            // 
            this.Search.Controls.Add(this.searchTextBox);
            this.Search.Controls.Add(this.nameRadioButton);
            this.Search.Controls.Add(this.codeRadioButton);
            this.Search.Location = new System.Drawing.Point(224, 54);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Search.Size = new System.Drawing.Size(438, 84);
            this.Search.TabIndex = 19;
            this.Search.TabStop = false;
            this.Search.Text = "Search";
            // 
            // CategoryUiController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Search);
            this.Controls.Add(this.allCategoryButton);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.categoryViewPanel);
            this.Controls.Add(this.topPanelCategory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CategoryUiController";
            this.Size = new System.Drawing.Size(1132, 726);
            this.Load += new System.EventHandler(this.CategoryUiController_Load);
            this.categoryViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.topPanelCategory.ResumeLayout(false);
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button allCategoryButton;
        private System.Windows.Forms.RadioButton codeRadioButton;
        private System.Windows.Forms.RadioButton nameRadioButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Panel categoryViewPanel;
        private System.Windows.Forms.DataGridView categoryDataGridView;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel topPanelCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.GroupBox Search;
    }
}
