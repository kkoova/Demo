namespace DemoTrade.Controlls
{
    partial class UserControlTovar
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
            this.pictureBoxTovar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNameTovar = new System.Windows.Forms.Label();
            this.labelDeckTovar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPriceTovar = new System.Windows.Forms.Label();
            this.labelProizTovar = new System.Windows.Forms.Label();
            this.labelSale = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTovar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxTovar
            // 
            this.pictureBoxTovar.ErrorImage = global::DemoTrade.Properties.Resources.picture;
            this.pictureBoxTovar.Location = new System.Drawing.Point(15, 15);
            this.pictureBoxTovar.Name = "pictureBoxTovar";
            this.pictureBoxTovar.Size = new System.Drawing.Size(211, 120);
            this.pictureBoxTovar.TabIndex = 0;
            this.pictureBoxTovar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelProizTovar);
            this.panel1.Controls.Add(this.labelPriceTovar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelDeckTovar);
            this.panel1.Controls.Add(this.labelNameTovar);
            this.panel1.Location = new System.Drawing.Point(232, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 120);
            this.panel1.TabIndex = 1;
            // 
            // labelNameTovar
            // 
            this.labelNameTovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameTovar.Location = new System.Drawing.Point(3, 0);
            this.labelNameTovar.Name = "labelNameTovar";
            this.labelNameTovar.Size = new System.Drawing.Size(298, 52);
            this.labelNameTovar.TabIndex = 2;
            this.labelNameTovar.Text = "Наименование товара:";
            // 
            // labelDeckTovar
            // 
            this.labelDeckTovar.Location = new System.Drawing.Point(3, 52);
            this.labelDeckTovar.Name = "labelDeckTovar";
            this.labelDeckTovar.Size = new System.Drawing.Size(298, 27);
            this.labelDeckTovar.TabIndex = 3;
            this.labelDeckTovar.Text = "Описание товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Производитель:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цена:";
            // 
            // labelPriceTovar
            // 
            this.labelPriceTovar.Location = new System.Drawing.Point(161, 98);
            this.labelPriceTovar.Name = "labelPriceTovar";
            this.labelPriceTovar.Size = new System.Drawing.Size(140, 13);
            this.labelPriceTovar.TabIndex = 6;
            this.labelPriceTovar.Text = "1000";
            this.labelPriceTovar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelProizTovar
            // 
            this.labelProizTovar.Location = new System.Drawing.Point(161, 79);
            this.labelProizTovar.Name = "labelProizTovar";
            this.labelProizTovar.Size = new System.Drawing.Size(140, 13);
            this.labelProizTovar.TabIndex = 7;
            this.labelProizTovar.Text = "произв";
            this.labelProizTovar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSale
            // 
            this.labelSale.BackColor = System.Drawing.Color.White;
            this.labelSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSale.Location = new System.Drawing.Point(542, 13);
            this.labelSale.Name = "labelSale";
            this.labelSale.Size = new System.Drawing.Size(143, 120);
            this.labelSale.TabIndex = 2;
            this.labelSale.Text = "10%";
            this.labelSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlTovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.labelSale);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxTovar);
            this.Name = "UserControlTovar";
            this.Size = new System.Drawing.Size(705, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTovar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTovar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNameTovar;
        private System.Windows.Forms.Label labelPriceTovar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDeckTovar;
        private System.Windows.Forms.Label labelProizTovar;
        private System.Windows.Forms.Label labelSale;
    }
}
