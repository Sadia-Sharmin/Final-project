namespace StockManagementSystem.UI
{
    partial class ReportUiController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportUiController));
            this.topPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.bottonPanel = new System.Windows.Forms.Panel();
            this.salesActivePanel = new System.Windows.Forms.Panel();
            this.saleReportButton = new System.Windows.Forms.Button();
            this.purchaseReportButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.purchaseActivePanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.bottonPanel.SuspendLayout();
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
            this.topPanel.Size = new System.Drawing.Size(1132, 32);
            this.topPanel.TabIndex = 14;
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
            // bottonPanel
            // 
            this.bottonPanel.Controls.Add(this.purchaseActivePanel);
            this.bottonPanel.Controls.Add(this.salesActivePanel);
            this.bottonPanel.Controls.Add(this.saleReportButton);
            this.bottonPanel.Controls.Add(this.purchaseReportButton);
            this.bottonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bottonPanel.Location = new System.Drawing.Point(0, 32);
            this.bottonPanel.Name = "bottonPanel";
            this.bottonPanel.Size = new System.Drawing.Size(1132, 58);
            this.bottonPanel.TabIndex = 15;
            // 
            // salesActivePanel
            // 
            this.salesActivePanel.BackColor = System.Drawing.Color.Red;
            this.salesActivePanel.Location = new System.Drawing.Point(752, 47);
            this.salesActivePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salesActivePanel.Name = "salesActivePanel";
            this.salesActivePanel.Size = new System.Drawing.Size(211, 10);
            this.salesActivePanel.TabIndex = 1;
            // 
            // saleReportButton
            // 
            this.saleReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.saleReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saleReportButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saleReportButton.FlatAppearance.BorderSize = 0;
            this.saleReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saleReportButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.saleReportButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saleReportButton.Image = ((System.Drawing.Image)(resources.GetObject("saleReportButton.Image")));
            this.saleReportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saleReportButton.Location = new System.Drawing.Point(752, 4);
            this.saleReportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saleReportButton.Name = "saleReportButton";
            this.saleReportButton.Size = new System.Drawing.Size(211, 43);
            this.saleReportButton.TabIndex = 2;
            this.saleReportButton.Text = "   SalesReport";
            this.saleReportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saleReportButton.UseVisualStyleBackColor = false;
            this.saleReportButton.Click += new System.EventHandler(this.saleReportButton_Click);
            // 
            // purchaseReportButton
            // 
            this.purchaseReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.purchaseReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchaseReportButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.purchaseReportButton.FlatAppearance.BorderSize = 0;
            this.purchaseReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseReportButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.purchaseReportButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.purchaseReportButton.Image = ((System.Drawing.Image)(resources.GetObject("purchaseReportButton.Image")));
            this.purchaseReportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.purchaseReportButton.Location = new System.Drawing.Point(157, 4);
            this.purchaseReportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.purchaseReportButton.Name = "purchaseReportButton";
            this.purchaseReportButton.Size = new System.Drawing.Size(211, 43);
            this.purchaseReportButton.TabIndex = 2;
            this.purchaseReportButton.Text = "   PurchaseReport";
            this.purchaseReportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.purchaseReportButton.UseVisualStyleBackColor = false;
            this.purchaseReportButton.Click += new System.EventHandler(this.purchaseReportButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 90);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1132, 636);
            this.mainPanel.TabIndex = 16;
            // 
            // purchaseActivePanel
            // 
            this.purchaseActivePanel.BackColor = System.Drawing.Color.Red;
            this.purchaseActivePanel.Location = new System.Drawing.Point(157, 46);
            this.purchaseActivePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.purchaseActivePanel.Name = "purchaseActivePanel";
            this.purchaseActivePanel.Size = new System.Drawing.Size(211, 10);
            this.purchaseActivePanel.TabIndex = 1;
            // 
            // ReportUiController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.bottonPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "ReportUiController";
            this.Size = new System.Drawing.Size(1132, 726);
            this.topPanel.ResumeLayout(false);
            this.bottonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel bottonPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel salesActivePanel;
        private System.Windows.Forms.Button saleReportButton;
        private System.Windows.Forms.Button purchaseReportButton;
        private System.Windows.Forms.Panel purchaseActivePanel;
    }
}
