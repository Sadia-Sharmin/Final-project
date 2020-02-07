namespace StockManagementSystem.UI
{
    partial class AddProductUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductUi));
            this.topPanel = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.reorderLevelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveOrUpdateButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionErrorLabel = new System.Windows.Forms.Label();
            this.reorderLevelErrorLabel = new System.Windows.Forms.Label();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.codeErrorLabel = new System.Windows.Forms.Label();
            this.categoryErrorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reorderLevelNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.topPanel.Controls.Add(this.close);
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(399, 36);
            this.topPanel.TabIndex = 1;
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(365, 11);
            this.close.Margin = new System.Windows.Forms.Padding(2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 18);
            this.close.TabIndex = 1;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(1496, 17);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(26, 33);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // reorderLevelNumericUpDown
            // 
            this.reorderLevelNumericUpDown.Location = new System.Drawing.Point(146, 215);
            this.reorderLevelNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.reorderLevelNumericUpDown.Name = "reorderLevelNumericUpDown";
            this.reorderLevelNumericUpDown.Size = new System.Drawing.Size(214, 30);
            this.reorderLevelNumericUpDown.TabIndex = 35;
            this.reorderLevelNumericUpDown.ValueChanged += new System.EventHandler(this.reorderLevelNumericUpDown_ValueChanged);
            // 
            // saveOrUpdateButton
            // 
            this.saveOrUpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.saveOrUpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveOrUpdateButton.FlatAppearance.BorderSize = 0;
            this.saveOrUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveOrUpdateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveOrUpdateButton.ForeColor = System.Drawing.Color.White;
            this.saveOrUpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveOrUpdateButton.Location = new System.Drawing.Point(146, 367);
            this.saveOrUpdateButton.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.saveOrUpdateButton.Name = "saveOrUpdateButton";
            this.saveOrUpdateButton.Size = new System.Drawing.Size(89, 37);
            this.saveOrUpdateButton.TabIndex = 37;
            this.saveOrUpdateButton.Text = "Save";
            this.saveOrUpdateButton.UseVisualStyleBackColor = false;
            this.saveOrUpdateButton.Click += new System.EventHandler(this.saveOrUpdateButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(146, 271);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(214, 74);
            this.descriptionTextBox.TabIndex = 36;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Reorder Level:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(146, 164);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(214, 30);
            this.nameTextBox.TabIndex = 32;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Name:";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Enabled = false;
            this.codeTextBox.Location = new System.Drawing.Point(146, 114);
            this.codeTextBox.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.codeTextBox.MaxLength = 4;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(214, 30);
            this.codeTextBox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Code:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(146, 62);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(214, 31);
            this.categoryComboBox.TabIndex = 22;
            this.categoryComboBox.ValueMember = "Id";
            this.categoryComboBox.TextChanged += new System.EventHandler(this.categoryComboBox_TextChanged);
            // 
            // descriptionErrorLabel
            // 
            this.descriptionErrorLabel.AutoSize = true;
            this.descriptionErrorLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.descriptionErrorLabel.Location = new System.Drawing.Point(142, 342);
            this.descriptionErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionErrorLabel.Name = "descriptionErrorLabel";
            this.descriptionErrorLabel.Size = new System.Drawing.Size(93, 19);
            this.descriptionErrorLabel.TabIndex = 23;
            this.descriptionErrorLabel.Text = "ErrorMessage";
            // 
            // reorderLevelErrorLabel
            // 
            this.reorderLevelErrorLabel.AutoSize = true;
            this.reorderLevelErrorLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.reorderLevelErrorLabel.Location = new System.Drawing.Point(142, 246);
            this.reorderLevelErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reorderLevelErrorLabel.Name = "reorderLevelErrorLabel";
            this.reorderLevelErrorLabel.Size = new System.Drawing.Size(93, 19);
            this.reorderLevelErrorLabel.TabIndex = 24;
            this.reorderLevelErrorLabel.Text = "ErrorMessage";
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.nameErrorLabel.Location = new System.Drawing.Point(142, 191);
            this.nameErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(93, 19);
            this.nameErrorLabel.TabIndex = 25;
            this.nameErrorLabel.Text = "ErrorMessage";
            // 
            // codeErrorLabel
            // 
            this.codeErrorLabel.AutoSize = true;
            this.codeErrorLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.codeErrorLabel.Location = new System.Drawing.Point(142, 139);
            this.codeErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codeErrorLabel.Name = "codeErrorLabel";
            this.codeErrorLabel.Size = new System.Drawing.Size(93, 19);
            this.codeErrorLabel.TabIndex = 26;
            this.codeErrorLabel.Text = "ErrorMessage";
            // 
            // categoryErrorLabel
            // 
            this.categoryErrorLabel.AutoSize = true;
            this.categoryErrorLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryErrorLabel.Location = new System.Drawing.Point(142, 89);
            this.categoryErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryErrorLabel.Name = "categoryErrorLabel";
            this.categoryErrorLabel.Size = new System.Drawing.Size(93, 19);
            this.categoryErrorLabel.TabIndex = 27;
            this.categoryErrorLabel.Text = "ErrorMessage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Category:";
            // 
            // AddProductUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(399, 415);
            this.ControlBox = false;
            this.Controls.Add(this.reorderLevelNumericUpDown);
            this.Controls.Add(this.saveOrUpdateButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.descriptionErrorLabel);
            this.Controls.Add(this.reorderLevelErrorLabel);
            this.Controls.Add(this.nameErrorLabel);
            this.Controls.Add(this.codeErrorLabel);
            this.Controls.Add(this.categoryErrorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "AddProductUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddProductUi_Load);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reorderLevelNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label descriptionErrorLabel;
        private System.Windows.Forms.Label reorderLevelErrorLabel;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label codeErrorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
        public System.Windows.Forms.NumericUpDown reorderLevelNumericUpDown;
        public System.Windows.Forms.TextBox descriptionTextBox;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox codeTextBox;
        public System.Windows.Forms.ComboBox categoryComboBox;
        public System.Windows.Forms.Button saveOrUpdateButton;
        public System.Windows.Forms.Label categoryErrorLabel;
    }
}