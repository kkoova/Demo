namespace DemoBook.UserControls
{
    partial class UserControlGenre
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
            this.TitleLable = new System.Windows.Forms.Label();
            this.deckLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLable
            // 
            this.TitleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLable.Location = new System.Drawing.Point(14, 16);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(632, 55);
            this.TitleLable.TabIndex = 1;
            this.TitleLable.Text = "Title";
            // 
            // deckLable
            // 
            this.deckLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deckLable.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deckLable.Location = new System.Drawing.Point(16, 83);
            this.deckLable.Name = "deckLable";
            this.deckLable.Size = new System.Drawing.Size(630, 33);
            this.deckLable.TabIndex = 7;
            this.deckLable.Text = "label1";
            // 
            // UserControlGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.deckLable);
            this.Controls.Add(this.TitleLable);
            this.Name = "UserControlGenre";
            this.Size = new System.Drawing.Size(660, 139);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLable;
        private System.Windows.Forms.Label deckLable;
    }
}
