namespace DemoTrade.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.tovarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTovarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addTovarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addZakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStripMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tovarToolStripMenuItem,
            this.zakToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // tovarToolStripMenuItem
            // 
            this.tovarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTovarToolStripMenuItem1,
            this.addTovarToolStripMenuItem});
            this.tovarToolStripMenuItem.Name = "tovarToolStripMenuItem";
            this.tovarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.tovarToolStripMenuItem.Text = "Товары";
            // 
            // showTovarToolStripMenuItem1
            // 
            this.showTovarToolStripMenuItem1.Name = "showTovarToolStripMenuItem1";
            this.showTovarToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.showTovarToolStripMenuItem1.Text = "Просмотр";
            this.showTovarToolStripMenuItem1.Click += new System.EventHandler(this.showTovarToolStripMenuItem1_Click);
            // 
            // addTovarToolStripMenuItem
            // 
            this.addTovarToolStripMenuItem.Name = "addTovarToolStripMenuItem";
            this.addTovarToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.addTovarToolStripMenuItem.Text = "Сформировать товар";
            this.addTovarToolStripMenuItem.Visible = false;
            // 
            // zakToolStripMenuItem
            // 
            this.zakToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.addZakToolStripMenuItem});
            this.zakToolStripMenuItem.Name = "zakToolStripMenuItem";
            this.zakToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.zakToolStripMenuItem.Text = "Заказы";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.showToolStripMenuItem.Text = "Просмотр";
            this.showToolStripMenuItem.Visible = false;
            // 
            // addZakToolStripMenuItem
            // 
            this.addZakToolStripMenuItem.Name = "addZakToolStripMenuItem";
            this.addZakToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addZakToolStripMenuItem.Text = "Сформировать заказ";
            this.addZakToolStripMenuItem.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelUser
            // 
            this.toolStripStatusLabelUser.Name = "toolStripStatusLabelUser";
            this.toolStripStatusLabelUser.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabelUser.Text = "Гость";
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(713, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Выход";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 27);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(776, 398);
            this.flowLayoutPanel.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "Main";
            this.Text = "Товары";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem tovarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTovarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addTovarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addZakToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUser;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}