using System.ComponentModel;

namespace WinFormsAppOne.Forms;

partial class Autor
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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(21, 32);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(107, 23);
        label1.TabIndex = 0;
        label1.Text = "Логин:";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(21, 76);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(107, 23);
        label2.TabIndex = 1;
        label2.Text = "Пароль:";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(120, 32);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(216, 23);
        textBox1.TabIndex = 2;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(120, 76);
        textBox2.Name = "textBox2";
        textBox2.PasswordChar = '*';
        textBox2.Size = new System.Drawing.Size(216, 23);
        textBox2.TabIndex = 3;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(21, 124);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(315, 23);
        button1.TabIndex = 4;
        button1.Text = "Войти";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Autor
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(367, 168);
        Controls.Add(button1);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label2);
        Controls.Add(label1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        Text = "Автоизация";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox1;

    #endregion
}