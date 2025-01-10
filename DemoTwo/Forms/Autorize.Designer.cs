using System.ComponentModel;

namespace DemoTwo.Forms;

partial class Autorize
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
        buttonGo = new System.Windows.Forms.Button();
        buttonCanccel = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(35, 51);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 0;
        label1.Text = "Логин:";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(35, 95);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 1;
        label2.Text = "Пароль:";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(153, 51);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(199, 23);
        textBox1.TabIndex = 2;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(153, 95);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(199, 23);
        textBox2.TabIndex = 3;
        // 
        // buttonGo
        // 
        buttonGo.Location = new System.Drawing.Point(35, 154);
        buttonGo.Name = "buttonGo";
        buttonGo.Size = new System.Drawing.Size(217, 23);
        buttonGo.TabIndex = 4;
        buttonGo.Text = "Войти";
        buttonGo.UseVisualStyleBackColor = true;
        // 
        // buttonCanccel
        // 
        buttonCanccel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        buttonCanccel.Location = new System.Drawing.Point(258, 154);
        buttonCanccel.Name = "buttonCanccel";
        buttonCanccel.Size = new System.Drawing.Size(94, 23);
        buttonCanccel.TabIndex = 5;
        buttonCanccel.Text = "Отмена";
        buttonCanccel.UseVisualStyleBackColor = true;
        // 
        // Autorize
        // 
        AcceptButton = buttonGo;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        CancelButton = buttonCanccel;
        ClientSize = new System.Drawing.Size(409, 221);
        ControlBox = false;
        Controls.Add(buttonCanccel);
        Controls.Add(buttonGo);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label2);
        Controls.Add(label1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Авторизация";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button buttonGo;
    private System.Windows.Forms.Button buttonCanccel;

    private System.Windows.Forms.Label label1;

    #endregion
}