namespace StockManagementSystem.UI
{
    partial class AddCategoryUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategoryUi));
            this.topPanel = new System.Windows.Forms.Panel();
            this.closeCategoryUiButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveOrUpdateButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.codeErrorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.topPanel.Controls.Add(this.closeCategoryUiButton);
            this.topPanel.Controls.Add(this.minimizeButton);
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(340, 39);
            this.topPanel.TabIndex = 1;
            // 
            // closeCategoryUiButton
            // 
            this.closeCategoryUiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeCategoryUiButton.FlatAppearance.BorderSize = 0;
            this.closeCategoryUiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeCategoryUiButton.Image = ((System.Drawing.Image)(resources.GetObject("closeCategoryUiButton.Image")));
            this.closeCategoryUiButton.Location = new System.Drawing.Point(312, 12);
            this.closeCategoryUiButton.Name = "closeCategoryUiButton";
            this.closeCategoryUiButton.Size = new System.Drawing.Size(23, 16);
            this.closeCategoryUiButton.TabIndex = 1;
            this.closeCategoryUiButton.UseVisualStyleBackColor = true;
            this.closeCategoryUiButton.Click += new System.EventHandler(this.closeCategoryUiButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(1286, 21);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(23, 18);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(1331, 15);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(23, 30);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // saveOrUpdateButton
            // 
            this.saveOrUpdateButton.Location = new System.Drawing.Point(94, 182);
            this.saveOrUpdateButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.saveOrUpdateButton.Name = "saveOrUpdateButton";
            this.saveOrUpdateButton.Size = new System.Drawing.Size(84, 34);
            this.saveOrUpdateButton.TabIndex = 9;
            this.saveOrUpdateButton.Text = "Save";
            this.saveOrUpdateButton.UseVisualStyleBackColor = true;
            this.saveOrUpdateButton.Click += new System.EventHandler(this.saveOrUpdateButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(94, 116);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(194, 27);
            this.nameTextBox.TabIndex = 8;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Enabled = false;
            this.codeTextBox.Location = new System.Drawing.Point(94, 59);
            this.codeTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.codeTextBox.MaxLength = 4;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(194, 27);
            this.codeTextBox.TabIndex = 4;
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.Location = new System.Drawing.Point(90, 148);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(99, 20);
            this.nameErrorLabel.TabIndex = 5;
            this.nameErrorLabel.Text = "ErrorMassage";
            // 
            // codeErrorLabel
            // 
            this.codeErrorLabel.AutoSize = true;
            this.codeErrorLabel.Location = new System.Drawing.Point(91, 91);
            this.codeErrorLabel.Name = "codeErrorLabel";
            this.codeErrorLabel.Size = new System.Drawing.Size(99, 20);
            this.codeErrorLabel.TabIndex = 6;
            this.codeErrorLabel.Text = "ErorrMassage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Code:";
            // 
            // AddCategoryUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 225);
            this.ControlBox = false;
            this.Controls.Add(this.saveOrUpdateButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.nameErrorLabel);
            this.Controls.Add(this.codeErrorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddCategoryUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddCategoryUi_Load);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label codeErrorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeCategoryUiButton;
        public System.Windows.Forms.Button saveOrUpdateButton;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox codeTextBox;
    }
}