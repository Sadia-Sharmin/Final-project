namespace StockManagementSystem.UI
{
    partial class HomeUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUi));
            this.topPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.activePanel = new System.Windows.Forms.Panel();
            this.reportButton = new System.Windows.Forms.Button();
            this.stockButton = new System.Windows.Forms.Button();
            this.saleButton = new System.Windows.Forms.Button();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.supplierButton = new System.Windows.Forms.Button();
            this.productButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.dashBoardButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.topPanel.Controls.Add(this.minimizeButton);
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1364, 40);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(1285, 13);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(31, 17);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(1331, 5);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 25);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.sidePanel.Controls.Add(this.activePanel);
            this.sidePanel.Controls.Add(this.reportButton);
            this.sidePanel.Controls.Add(this.stockButton);
            this.sidePanel.Controls.Add(this.saleButton);
            this.sidePanel.Controls.Add(this.purchaseButton);
            this.sidePanel.Controls.Add(this.supplierButton);
            this.sidePanel.Controls.Add(this.productButton);
            this.sidePanel.Controls.Add(this.homeButton);
            this.sidePanel.Controls.Add(this.categoryButton);
            this.sidePanel.Controls.Add(this.dashBoardButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidePanel.Location = new System.Drawing.Point(0, 40);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(232, 726);
            this.sidePanel.TabIndex = 1;
            // 
            // activePanel
            // 
            this.activePanel.BackColor = System.Drawing.Color.Red;
            this.activePanel.Location = new System.Drawing.Point(3, 102);
            this.activePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activePanel.Name = "activePanel";
            this.activePanel.Size = new System.Drawing.Size(11, 46);
            this.activePanel.TabIndex = 0;
            // 
            // reportButton
            // 
            this.reportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.reportButton.FlatAppearance.BorderSize = 0;
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.reportButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reportButton.Image = ((System.Drawing.Image)(resources.GetObject("reportButton.Image")));
            this.reportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportButton.Location = new System.Drawing.Point(18, 457);
            this.reportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(211, 46);
            this.reportButton.TabIndex = 0;
            this.reportButton.Text = "   Report";
            this.reportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // stockButton
            // 
            this.stockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stockButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.stockButton.FlatAppearance.BorderSize = 0;
            this.stockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.stockButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stockButton.Image = ((System.Drawing.Image)(resources.GetObject("stockButton.Image")));
            this.stockButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockButton.Location = new System.Drawing.Point(18, 407);
            this.stockButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stockButton.Name = "stockButton";
            this.stockButton.Size = new System.Drawing.Size(211, 46);
            this.stockButton.TabIndex = 0;
            this.stockButton.Text = "   Stock";
            this.stockButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stockButton.UseVisualStyleBackColor = true;
            this.stockButton.Click += new System.EventHandler(this.stockButton_Click);
            // 
            // saleButton
            // 
            this.saleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saleButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saleButton.FlatAppearance.BorderSize = 0;
            this.saleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saleButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.saleButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saleButton.Image = ((System.Drawing.Image)(resources.GetObject("saleButton.Image")));
            this.saleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saleButton.Location = new System.Drawing.Point(12, 357);
            this.saleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saleButton.Name = "saleButton";
            this.saleButton.Size = new System.Drawing.Size(211, 46);
            this.saleButton.TabIndex = 0;
            this.saleButton.Text = "   Sale";
            this.saleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saleButton.UseVisualStyleBackColor = true;
            this.saleButton.Click += new System.EventHandler(this.saleButton_Click);
            // 
            // purchaseButton
            // 
            this.purchaseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchaseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.purchaseButton.FlatAppearance.BorderSize = 0;
            this.purchaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.purchaseButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.purchaseButton.Image = ((System.Drawing.Image)(resources.GetObject("purchaseButton.Image")));
            this.purchaseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.purchaseButton.Location = new System.Drawing.Point(12, 305);
            this.purchaseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(211, 46);
            this.purchaseButton.TabIndex = 0;
            this.purchaseButton.Text = "   Purchase";
            this.purchaseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // supplierButton
            // 
            this.supplierButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supplierButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.supplierButton.FlatAppearance.BorderSize = 0;
            this.supplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplierButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.supplierButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.supplierButton.Image = ((System.Drawing.Image)(resources.GetObject("supplierButton.Image")));
            this.supplierButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supplierButton.Location = new System.Drawing.Point(12, 254);
            this.supplierButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.supplierButton.Name = "supplierButton";
            this.supplierButton.Size = new System.Drawing.Size(211, 46);
            this.supplierButton.TabIndex = 0;
            this.supplierButton.Text = "   Supplier";
            this.supplierButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.supplierButton.UseVisualStyleBackColor = true;
            this.supplierButton.Click += new System.EventHandler(this.supplierButton_Click);
            // 
            // productButton
            // 
            this.productButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.productButton.FlatAppearance.BorderSize = 0;
            this.productButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.productButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.productButton.Image = ((System.Drawing.Image)(resources.GetObject("productButton.Image")));
            this.productButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton.Location = new System.Drawing.Point(15, 204);
            this.productButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(211, 46);
            this.productButton.TabIndex = 0;
            this.productButton.Text = "   Product";
            this.productButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productButton.UseVisualStyleBackColor = true;
            this.productButton.Click += new System.EventHandler(this.productButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.homeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(15, 102);
            this.homeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(211, 46);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "   Home";
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // categoryButton
            // 
            this.categoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.categoryButton.FlatAppearance.BorderSize = 0;
            this.categoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.categoryButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.categoryButton.Image = ((System.Drawing.Image)(resources.GetObject("categoryButton.Image")));
            this.categoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryButton.Location = new System.Drawing.Point(15, 153);
            this.categoryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(211, 46);
            this.categoryButton.TabIndex = 0;
            this.categoryButton.Text = "   Category";
            this.categoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // dashBoardButton
            // 
            this.dashBoardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dashBoardButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.dashBoardButton.FlatAppearance.BorderSize = 0;
            this.dashBoardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashBoardButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBoardButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dashBoardButton.Image = ((System.Drawing.Image)(resources.GetObject("dashBoardButton.Image")));
            this.dashBoardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashBoardButton.Location = new System.Drawing.Point(0, 0);
            this.dashBoardButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashBoardButton.Name = "dashBoardButton";
            this.dashBoardButton.Size = new System.Drawing.Size(232, 40);
            this.dashBoardButton.TabIndex = 0;
            this.dashBoardButton.Text = "   Dashboard";
            this.dashBoardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashBoardButton.UseVisualStyleBackColor = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPanel.Location = new System.Drawing.Point(232, 40);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1132, 726);
            this.mainPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(232, 756);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 10);
            this.panel1.TabIndex = 0;
            // 
            // HomeUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 766);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomeUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.topPanel.ResumeLayout(false);
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button dashBoardButton;
        private System.Windows.Forms.Button saleButton;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Button supplierButton;
        private System.Windows.Forms.Button productButton;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel activePanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button stockButton;
        private System.Windows.Forms.Button reportButton;
    }
}