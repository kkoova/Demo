using System.ComponentModel;

namespace DemoTwo.Forms;

partial class Main
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        жанрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        авторизоватьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        книгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        арендаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        сдачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        lableUser = new System.Windows.Forms.Label();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { жанрыToolStripMenuItem, пользовательToolStripMenuItem, книгиToolStripMenuItem });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(800, 24);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // жанрыToolStripMenuItem
        // 
        жанрыToolStripMenuItem.Name = "жанрыToolStripMenuItem";
        жанрыToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
        жанрыToolStripMenuItem.Text = "Жанры";
        // 
        // пользовательToolStripMenuItem
        // 
        пользовательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { авторизоватьсяToolStripMenuItem, выйтиToolStripMenuItem });
        пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
        пользовательToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
        пользовательToolStripMenuItem.Text = "Пользователь";
        // 
        // авторизоватьсяToolStripMenuItem
        // 
        авторизоватьсяToolStripMenuItem.Name = "авторизоватьсяToolStripMenuItem";
        авторизоватьсяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        авторизоватьсяToolStripMenuItem.Text = "Авторизоваться";
        авторизоватьсяToolStripMenuItem.Click += авторизоватьсяToolStripMenuItem_Click;
        // 
        // выйтиToolStripMenuItem
        // 
        выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
        выйтиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        выйтиToolStripMenuItem.Text = "Выйти";
        // 
        // книгиToolStripMenuItem
        // 
        книгиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { арендаToolStripMenuItem, сдачаToolStripMenuItem });
        книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
        книгиToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
        книгиToolStripMenuItem.Text = "Книги";
        // 
        // арендаToolStripMenuItem
        // 
        арендаToolStripMenuItem.Name = "арендаToolStripMenuItem";
        арендаToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
        арендаToolStripMenuItem.Text = "Аренда";
        // 
        // сдачаToolStripMenuItem
        // 
        сдачаToolStripMenuItem.Name = "сдачаToolStripMenuItem";
        сдачаToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
        сдачаToolStripMenuItem.Text = "Сдача";
        // 
        // lableUser
        // 
        lableUser.Location = new System.Drawing.Point(544, 36);
        lableUser.Name = "lableUser";
        lableUser.Size = new System.Drawing.Size(247, 23);
        lableUser.TabIndex = 1;
        lableUser.Text = "Гость";
        lableUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // Main
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(lableUser);
        Controls.Add(menuStrip1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MainMenuStrip = menuStrip1;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Арена книг";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem авторизоватьсяToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
    private System.Windows.Forms.Label lableUser;

    private System.Windows.Forms.ToolStripMenuItem жанрыToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem арендаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem сдачаToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem;

    private System.Windows.Forms.MenuStrip menuStrip1;

    #endregion
}