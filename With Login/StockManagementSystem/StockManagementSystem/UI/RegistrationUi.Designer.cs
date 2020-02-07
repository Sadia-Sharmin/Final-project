namespace StockManagementSystem.UI
{
    partial class RegistrationUi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginNowButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.confirmError = new System.Windows.Forms.Label();
            this.nameError = new System.Windows.Forms.Label();
            this.emailError = new System.Windows.Forms.Label();
            this.passwordError = new System.Windows.Forms.Label();
            this.registrationErrorMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.registrationErrorMessage);
            this.groupBox1.Controls.Add(this.passwordError);
            this.groupBox1.Controls.Add(this.emailError);
            this.groupBox1.Controls.Add(this.nameError);
            this.groupBox1.Controls.Add(this.confirmError);
            this.groupBox1.Controls.Add(this.submitButton);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.confirmPasswordTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(142, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 270);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration From";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(143, 237);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(85, 27);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(143, 43);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(143, 88);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 22);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(143, 133);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 22);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email:";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(143, 178);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(200, 22);
            this.confirmPasswordTextBox.TabIndex = 1;
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
            this.confirmPasswordTextBox.TextChanged += new System.EventHandler(this.confirmPasswordTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Conf. Password:";
            // 
            // loginNowButton
            // 
            this.loginNowButton.Location = new System.Drawing.Point(348, 342);
            this.loginNowButton.Name = "loginNowButton";
            this.loginNowButton.Size = new System.Drawing.Size(97, 28);
            this.loginNowButton.TabIndex = 5;
            this.loginNowButton.Text = "Login Now";
            this.loginNowButton.UseVisualStyleBackColor = true;
            this.loginNowButton.Click += new System.EventHandler(this.loginNowButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Already have an account ";
            // 
            // confirmError
            // 
            this.confirmError.AutoSize = true;
            this.confirmError.ForeColor = System.Drawing.Color.Red;
            this.confirmError.Location = new System.Drawing.Point(143, 203);
            this.confirmError.Name = "confirmError";
            this.confirmError.Size = new System.Drawing.Size(97, 17);
            this.confirmError.TabIndex = 3;
            this.confirmError.Text = "ErrorMessage";
            // 
            // nameError
            // 
            this.nameError.AutoSize = true;
            this.nameError.ForeColor = System.Drawing.Color.Red;
            this.nameError.Location = new System.Drawing.Point(143, 68);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(97, 17);
            this.nameError.TabIndex = 4;
            this.nameError.Text = "ErrorMessage";
            // 
            // emailError
            // 
            this.emailError.AutoSize = true;
            this.emailError.ForeColor = System.Drawing.Color.Red;
            this.emailError.Location = new System.Drawing.Point(143, 113);
            this.emailError.Name = "emailError";
            this.emailError.Size = new System.Drawing.Size(97, 17);
            this.emailError.TabIndex = 5;
            this.emailError.Text = "ErrorMessage";
            // 
            // passwordError
            // 
            this.passwordError.AutoSize = true;
            this.passwordError.ForeColor = System.Drawing.Color.Red;
            this.passwordError.Location = new System.Drawing.Point(140, 158);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(97, 17);
            this.passwordError.TabIndex = 6;
            this.passwordError.Text = "ErrorMessage";
            // 
            // registrationErrorMessage
            // 
            this.registrationErrorMessage.AutoSize = true;
            this.registrationErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.registrationErrorMessage.Location = new System.Drawing.Point(143, 217);
            this.registrationErrorMessage.Name = "registrationErrorMessage";
            this.registrationErrorMessage.Size = new System.Drawing.Size(97, 17);
            this.registrationErrorMessage.TabIndex = 7;
            this.registrationErrorMessage.Text = "ErrorMessage";
            // 
            // RegistrationUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 423);
            this.Controls.Add(this.loginNowButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrationUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginNowButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label confirmError;
        private System.Windows.Forms.Label passwordError;
        private System.Windows.Forms.Label emailError;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.Label registrationErrorMessage;
    }
}