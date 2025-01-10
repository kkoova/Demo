namespace DemoBook.UserControls
{
    partial class UserControlBook
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
            this.label2 = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.copiiLable = new System.Windows.Forms.Label();
            this.genreTextox = new System.Windows.Forms.TextBox();
            this.autorLable = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLable
            // 
            this.TitleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLable.Location = new System.Drawing.Point(13, 38);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(186, 86);
            this.TitleLable.TabIndex = 0;
            this.TitleLable.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Автор:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(18, 144);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.ReadOnly = true;
            this.yearTextBox.Size = new System.Drawing.Size(173, 20);
            this.yearTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Количество копий:";
            // 
            // copiiLable
            // 
            this.copiiLable.AutoSize = true;
            this.copiiLable.Location = new System.Drawing.Point(123, 176);
            this.copiiLable.Name = "copiiLable";
            this.copiiLable.Size = new System.Drawing.Size(35, 13);
            this.copiiLable.TabIndex = 4;
            this.copiiLable.Text = "label4";
            // 
            // genreTextox
            // 
            this.genreTextox.Location = new System.Drawing.Point(17, 202);
            this.genreTextox.Name = "genreTextox";
            this.genreTextox.ReadOnly = true;
            this.genreTextox.Size = new System.Drawing.Size(174, 20);
            this.genreTextox.TabIndex = 5;
            // 
            // autorLable
            // 
            this.autorLable.AutoSize = true;
            this.autorLable.Location = new System.Drawing.Point(56, 124);
            this.autorLable.Name = "autorLable";
            this.autorLable.Size = new System.Drawing.Size(35, 13);
            this.autorLable.TabIndex = 6;
            this.autorLable.Text = "label1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(212, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::DemoBook.Properties.Resources.edit_clear_all_icon_180807;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::DemoBook.Properties.Resources._2849810_cross_delite_error_interface_multimedia_107973;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // UserControlBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.autorLable);
            this.Controls.Add(this.genreTextox);
            this.Controls.Add(this.copiiLable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleLable);
            this.Name = "UserControlBook";
            this.Size = new System.Drawing.Size(212, 248);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label copiiLable;
        private System.Windows.Forms.TextBox genreTextox;
        private System.Windows.Forms.Label autorLable;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}
