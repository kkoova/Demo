namespace WinFormsAppOne.Forms
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
            this.flowLayoutTovar = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowTovar = new System.Windows.Forms.ToolStripMenuItem();
            this.ShoZakaz = new System.Windows.Forms.ToolStripMenuItem();
            this.AddZakaz = new System.Windows.Forms.ToolStripMenuItem();
            this.EditZakaz = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTovar = new System.Windows.Forms.ToolStripMenuItem();
            this.EditTovar = new System.Windows.Forms.ToolStripMenuItem();
            this.DeliteTovar = new System.Windows.Forms.ToolStripMenuItem();
            this.NameUserPol = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutTovar
            // 
            this.flowLayoutTovar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutTovar.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutTovar.Location = new System.Drawing.Point(12, 51);
            this.flowLayoutTovar.Name = "flowLayoutTovar";
            this.flowLayoutTovar.Size = new System.Drawing.Size(601, 387);
            this.flowLayoutTovar.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товарыToolStripMenuItem,
            this.заказыToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(12, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(126, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowTovar,
            this.AddTovar,
            this.EditTovar,
            this.DeliteTovar});
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.товарыToolStripMenuItem.Text = "Товары";
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShoZakaz,
            this.AddZakaz,
            this.EditZakaz});
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.заказыToolStripMenuItem.Text = "Заказы";
            // 
            // ShowTovar
            // 
            this.ShowTovar.Name = "ShowTovar";
            this.ShowTovar.Size = new System.Drawing.Size(180, 22);
            this.ShowTovar.Text = "Просмотр";
            this.ShowTovar.Click += new System.EventHandler(this.ShowTovar_Click);
            // 
            // ShoZakaz
            // 
            this.ShoZakaz.Name = "ShoZakaz";
            this.ShoZakaz.Size = new System.Drawing.Size(180, 22);
            this.ShoZakaz.Text = "Просмотр";
            // 
            // AddZakaz
            // 
            this.AddZakaz.Name = "AddZakaz";
            this.AddZakaz.Size = new System.Drawing.Size(180, 22);
            this.AddZakaz.Text = "Сформировать";
            // 
            // EditZakaz
            // 
            this.EditZakaz.Name = "EditZakaz";
            this.EditZakaz.Size = new System.Drawing.Size(180, 22);
            this.EditZakaz.Text = "Редактировать";
            // 
            // AddTovar
            // 
            this.AddTovar.Name = "AddTovar";
            this.AddTovar.Size = new System.Drawing.Size(180, 22);
            this.AddTovar.Text = "Добавить";
            // 
            // EditTovar
            // 
            this.EditTovar.Name = "EditTovar";
            this.EditTovar.Size = new System.Drawing.Size(180, 22);
            this.EditTovar.Text = "Редактировать";
            // 
            // DeliteTovar
            // 
            this.DeliteTovar.Name = "DeliteTovar";
            this.DeliteTovar.Size = new System.Drawing.Size(180, 22);
            this.DeliteTovar.Text = "Удалить";
            // 
            // NameUserPol
            // 
            this.NameUserPol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameUserPol.Location = new System.Drawing.Point(354, 9);
            this.NameUserPol.Name = "NameUserPol";
            this.NameUserPol.Size = new System.Drawing.Size(259, 23);
            this.NameUserPol.TabIndex = 2;
            this.NameUserPol.Text = "Гость";
            this.NameUserPol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.Controls.Add(this.NameUserPol);
            this.Controls.Add(this.flowLayoutTovar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutTovar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowTovar;
        private System.Windows.Forms.ToolStripMenuItem AddTovar;
        private System.Windows.Forms.ToolStripMenuItem EditTovar;
        private System.Windows.Forms.ToolStripMenuItem DeliteTovar;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShoZakaz;
        private System.Windows.Forms.ToolStripMenuItem AddZakaz;
        private System.Windows.Forms.ToolStripMenuItem EditZakaz;
        private System.Windows.Forms.Label NameUserPol;
    }
}