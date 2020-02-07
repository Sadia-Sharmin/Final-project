namespace StockManagementSystem.UI
{
    partial class AddSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplier));
            this.topPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contactPersonTextBox = new System.Windows.Forms.TextBox();
            this.contactPersonErrorLabel = new System.Windows.Forms.Label();
            this.saveOrUpdateButton = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.addressErrorLabel = new System.Windows.Forms.Label();
            this.contactErrorLabel = new System.Windows.Forms.Label();
            this.emailErrorLabel = new System.Windows.Forms.Label();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.exitButton);
            this.topPanel.Controls.Add(this.minimizeButton);
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(397, 38);
            this.topPanel.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(352, 2);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(20, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(1125, 16);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(20, 13);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(1164, 12);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(32, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Contact Person:";
            // 
            // contactPersonTextBox
            // 
            this.contactPersonTextBox.Location = new System.Drawing.Point(166, 255);
            this.contactPersonTextBox.MaxLength = 11;
            this.contactPersonTextBox.Name = "contactPersonTextBox";
            this.contactPersonTextBox.Size = new System.Drawing.Size(188, 27);
            this.contactPersonTextBox.TabIndex = 63;
            this.contactPersonTextBox.TextChanged += new System.EventHandler(this.contactPersonTextBox_TextChanged);
            // 
            // contactPersonErrorLabel
            // 
            this.contactPersonErrorLabel.AutoSize = true;
            this.contactPersonErrorLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contactPersonErrorLabel.Location = new System.Drawing.Point(158, 281);
            this.contactPersonErrorLabel.Name = "contactPersonErrorLabel";
            this.contactPersonErrorLabel.Size = new System.Drawing.Size(99, 20);
            this.contactPersonErrorLabel.TabIndex = 62;
            this.contactPersonErrorLabel.Text = "ErrorMessage";
            // 
            // saveOrUpdateButton
            // 
            this.saveOrUpdateButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveOrUpdateButton.Location = new System.Drawing.Point(161, 384);
            this.saveOrUpdateButton.Name = "saveOrUpdateButton";
            this.saveOrUpdateButton.Size = new System.Drawing.Size(77, 28);
            this.saveOrUpdateButton.TabIndex = 60;
            this.saveOrUpdateButton.Text = "Save";
            this.saveOrUpdateButton.UseVisualStyleBackColor = true;
            this.saveOrUpdateButton.Click += new System.EventHandler(this.saveOrUpdateButton_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(161, 304);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(188, 63);
            this.addressTextBox.TabIndex = 58;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(36, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Contact:";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(165, 209);
            this.contactTextBox.MaxLength = 11;
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(188, 27);
            this.contactTextBox.TabIndex = 57;
            this.contactTextBox.TextChanged += new System.EventHandler(this.contactTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(36, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(165, 161);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(188, 27);
            this.emailTextBox.TabIndex = 56;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(32, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Address:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(165, 108);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(188, 27);
            this.nameTextBox.TabIndex = 55;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(36, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Name:";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Enabled = false;
            this.codeTextBox.Location = new System.Drawing.Point(165, 69);
            this.codeTextBox.MaxLength = 4;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(188, 27);
            this.codeTextBox.TabIndex = 59;
            // 
            // addressErrorLabel
            // 
            this.addressErrorLabel.AutoSize = true;
            this.addressErrorLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addressErrorLabel.Location = new System.Drawing.Point(158, 365);
            this.addressErrorLabel.Name = "addressErrorLabel";
            this.addressErrorLabel.Size = new System.Drawing.Size(99, 20);
            this.addressErrorLabel.TabIndex = 54;
            this.addressErrorLabel.Text = "ErrorMessage";
            // 
            // contactErrorLabel
            // 
            this.contactErrorLabel.AutoSize = true;
            this.contactErrorLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contactErrorLabel.Location = new System.Drawing.Point(162, 235);
            this.contactErrorLabel.Name = "contactErrorLabel";
            this.contactErrorLabel.Size = new System.Drawing.Size(99, 20);
            this.contactErrorLabel.TabIndex = 49;
            this.contactErrorLabel.Text = "ErrorMessage";
            // 
            // emailErrorLabel
            // 
            this.emailErrorLabel.AutoSize = true;
            this.emailErrorLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.emailErrorLabel.Location = new System.Drawing.Point(158, 187);
            this.emailErrorLabel.Name = "emailErrorLabel";
            this.emailErrorLabel.Size = new System.Drawing.Size(99, 20);
            this.emailErrorLabel.TabIndex = 47;
            this.emailErrorLabel.Text = "ErrorMessage";
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nameErrorLabel.Location = new System.Drawing.Point(162, 134);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(99, 20);
            this.nameErrorLabel.TabIndex = 46;
            this.nameErrorLabel.Text = "ErrorMessage";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label.Location = new System.Drawing.Point(36, 72);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(47, 20);
            this.label.TabIndex = 45;
            this.label.Text = "Code:";
            // 
            // AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 421);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.contactPersonTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.contactPersonErrorLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.saveOrUpdateButton);
            this.Controls.Add(this.nameErrorLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailErrorLabel);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.contactErrorLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressErrorLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddSupplier_Load);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox contactPersonTextBox;
        private System.Windows.Forms.Label contactPersonErrorLabel;
        public System.Windows.Forms.Button saveOrUpdateButton;
        public System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label addressErrorLabel;
        private System.Windows.Forms.Label contactErrorLabel;
        private System.Windows.Forms.Label emailErrorLabel;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label label;
    }
}