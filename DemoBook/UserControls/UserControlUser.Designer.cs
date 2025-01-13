namespace DemoBook.UserControls
{
    partial class UserControlUser
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxLofin = new System.Windows.Forms.TextBox();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxLofin
            // 
            this.textBoxLofin.Location = new System.Drawing.Point(3, 3);
            this.textBoxLofin.Multiline = true;
            this.textBoxLofin.Name = "textBoxLofin";
            this.textBoxLofin.ReadOnly = true;
            this.textBoxLofin.Size = new System.Drawing.Size(150, 24);
            this.textBoxLofin.TabIndex = 0;
            this.textBoxLofin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRole
            // 
            this.textBoxRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRole.Location = new System.Drawing.Point(159, 3);
            this.textBoxRole.Multiline = true;
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.ReadOnly = true;
            this.textBoxRole.Size = new System.Drawing.Size(223, 24);
            this.textBoxRole.TabIndex = 1;
            this.textBoxRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserControlUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.textBoxRole);
            this.Controls.Add(this.textBoxLofin);
            this.Name = "UserControlUser";
            this.Size = new System.Drawing.Size(385, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLofin;
        private System.Windows.Forms.TextBox textBoxRole;
    }
}
