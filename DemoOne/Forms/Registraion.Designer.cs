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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registraion));
            groupBox1 = new GroupBox();
            GuestBtn = new Button();
            AvtoBtn = new Button();
            PassTxt = new TextBox();
            loginTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(GuestBtn);
            groupBox1.Controls.Add(AvtoBtn);
            groupBox1.Controls.Add(PassTxt);
            groupBox1.Controls.Add(loginTxt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(28, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 198);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Авторизация";
            // 
            // GuestBtn
            // 
            GuestBtn.Location = new Point(21, 161);
            GuestBtn.Name = "GuestBtn";
            GuestBtn.Size = new Size(246, 23);
            GuestBtn.TabIndex = 4;
            GuestBtn.Text = "Войти как гость";
            GuestBtn.UseVisualStyleBackColor = true;
            // 
            // AvtoBtn
            // 
            AvtoBtn.Location = new Point(21, 115);
            AvtoBtn.Name = "AvtoBtn";
            AvtoBtn.Size = new Size(246, 40);
            AvtoBtn.TabIndex = 3;
            AvtoBtn.Text = "Войти";
            AvtoBtn.UseVisualStyleBackColor = true;
            // 
            // PassTxt
            // 
            PassTxt.Location = new Point(92, 73);
            PassTxt.Name = "PassTxt";
            PassTxt.PasswordChar = '*';
            PassTxt.Size = new Size(175, 23);
            PassTxt.TabIndex = 2;
            // 
            // loginTxt
            // 
            loginTxt.Location = new Point(92, 38);
            loginTxt.Name = "loginTxt";
            loginTxt.Size = new Size(175, 23);
            loginTxt.TabIndex = 1;
            loginTxt.Validating += Validating_txt;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 76);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Пароль:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 41);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Логин:";
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkRate = 0;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // Registraion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 260);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Registraion";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
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