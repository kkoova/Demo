using System.Drawing;
using System.Windows.Forms;

namespace DemoOne.Forms
{
    partial class Registraion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registraion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GuestBtn = new System.Windows.Forms.Button();
            this.AvtoBtn = new System.Windows.Forms.Button();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.loginTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GuestBtn);
            this.groupBox1.Controls.Add(this.AvtoBtn);
            this.groupBox1.Controls.Add(this.PassTxt);
            this.groupBox1.Controls.Add(this.loginTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Авторизация";
            // 
            // GuestBtn
            // 
            this.GuestBtn.Location = new System.Drawing.Point(18, 140);
            this.GuestBtn.Name = "GuestBtn";
            this.GuestBtn.Size = new System.Drawing.Size(211, 20);
            this.GuestBtn.TabIndex = 4;
            this.GuestBtn.Text = "Войти как гость";
            this.GuestBtn.UseVisualStyleBackColor = true;
            this.GuestBtn.Click += new System.EventHandler(this.GuestBtn_Click);
            // 
            // AvtoBtn
            // 
            this.AvtoBtn.Location = new System.Drawing.Point(18, 100);
            this.AvtoBtn.Name = "AvtoBtn";
            this.AvtoBtn.Size = new System.Drawing.Size(211, 35);
            this.AvtoBtn.TabIndex = 3;
            this.AvtoBtn.Text = "Войти";
            this.AvtoBtn.UseVisualStyleBackColor = true;
            this.AvtoBtn.Click += new System.EventHandler(this.AvtoBtn_Click);
            // 
            // PassTxt
            // 
            this.PassTxt.Location = new System.Drawing.Point(79, 63);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.PasswordChar = '*';
            this.PassTxt.Size = new System.Drawing.Size(151, 20);
            this.PassTxt.TabIndex = 2;
            // 
            // loginTxt
            // 
            this.loginTxt.Location = new System.Drawing.Point(79, 33);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(151, 20);
            this.loginTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Registraion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 225);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registraion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Button AvtoBtn;
        private TextBox PassTxt;
        private TextBox loginTxt;
        private Button GuestBtn;
        private ErrorProvider errorProvider1;
    }
}