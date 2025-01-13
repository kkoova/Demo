namespace DemoBook.Forms
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.книгаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сдачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жанрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЖанрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторизацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяАрендыКнигToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПользToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.книгаToolStripMenuItem,
            this.жанрыToolStripMenuItem,
            this.пользовательToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // книгаToolStripMenuItem
            // 
            this.книгаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сдачаToolStripMenuItem,
            this.добавитьКнигуToolStripMenuItem,
            this.просмотрToolStripMenuItem});
            this.книгаToolStripMenuItem.Name = "книгаToolStripMenuItem";
            this.книгаToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.книгаToolStripMenuItem.Text = "Книга";
            // 
            // сдачаToolStripMenuItem
            // 
            this.сдачаToolStripMenuItem.Enabled = false;
            this.сдачаToolStripMenuItem.Name = "сдачаToolStripMenuItem";
            this.сдачаToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.сдачаToolStripMenuItem.Text = "Сдача";
            // 
            // добавитьКнигуToolStripMenuItem
            // 
            this.добавитьКнигуToolStripMenuItem.Enabled = false;
            this.добавитьКнигуToolStripMenuItem.Name = "добавитьКнигуToolStripMenuItem";
            this.добавитьКнигуToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.добавитьКнигуToolStripMenuItem.Text = "Добавить книгу";
            this.добавитьКнигуToolStripMenuItem.Click += new System.EventHandler(this.добавитьКнигуToolStripMenuItem_Click);
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            this.просмотрToolStripMenuItem.Click += new System.EventHandler(this.просмотрToolStripMenuItem_Click);
            // 
            // жанрыToolStripMenuItem
            // 
            this.жанрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрToolStripMenuItem1,
            this.добавитьЖанрToolStripMenuItem});
            this.жанрыToolStripMenuItem.Name = "жанрыToolStripMenuItem";
            this.жанрыToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.жанрыToolStripMenuItem.Text = "Жанры";
            // 
            // просмотрToolStripMenuItem1
            // 
            this.просмотрToolStripMenuItem1.Name = "просмотрToolStripMenuItem1";
            this.просмотрToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.просмотрToolStripMenuItem1.Text = "Просмотр";
            this.просмотрToolStripMenuItem1.Click += new System.EventHandler(this.жанрыToolStripMenuItem_Click);
            // 
            // добавитьЖанрToolStripMenuItem
            // 
            this.добавитьЖанрToolStripMenuItem.Enabled = false;
            this.добавитьЖанрToolStripMenuItem.Name = "добавитьЖанрToolStripMenuItem";
            this.добавитьЖанрToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.добавитьЖанрToolStripMenuItem.Text = "Добавить жанр";
            this.добавитьЖанрToolStripMenuItem.Click += new System.EventHandler(this.добавитьЖанрToolStripMenuItem_Click);
            // 
            // пользовательToolStripMenuItem
            // 
            this.пользовательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авторизацияToolStripMenuItem,
            this.историяАрендыКнигToolStripMenuItem,
            this.списокПользToolStripMenuItem});
            this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            this.пользовательToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.пользовательToolStripMenuItem.Text = "Пользователь";
            // 
            // авторизацияToolStripMenuItem
            // 
            this.авторизацияToolStripMenuItem.Name = "авторизацияToolStripMenuItem";
            this.авторизацияToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.авторизацияToolStripMenuItem.Text = "Авторизация";
            this.авторизацияToolStripMenuItem.Click += new System.EventHandler(this.авторизацияToolStripMenuItem_Click);
            // 
            // историяАрендыКнигToolStripMenuItem
            // 
            this.историяАрендыКнигToolStripMenuItem.Enabled = false;
            this.историяАрендыКнигToolStripMenuItem.Name = "историяАрендыКнигToolStripMenuItem";
            this.историяАрендыКнигToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.историяАрендыКнигToolStripMenuItem.Text = "История аренды книг";
            // 
            // списокПользToolStripMenuItem
            // 
            this.списокПользToolStripMenuItem.Enabled = false;
            this.списокПользToolStripMenuItem.Name = "списокПользToolStripMenuItem";
            this.списокПользToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.списокПользToolStripMenuItem.Text = "Список польз";
            this.списокПользToolStripMenuItem.Click += new System.EventHandler(this.списокПользToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(585, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelUser
            // 
            this.toolStripStatusLabelUser.Name = "toolStripStatusLabelUser";
            this.toolStripStatusLabelUser.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabelUser.Text = "Гость";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 27);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(561, 382);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 445);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аренда книги";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem книгаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сдачаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem жанрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторизацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяАрендыКнигToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUser;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.ToolStripMenuItem добавитьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьЖанрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПользToolStripMenuItem;
    }
}