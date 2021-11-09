namespace Threading
{
    partial class threadfrm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.sayac1lbl = new System.Windows.Forms.Label();
            this.sayac2lbl = new System.Windows.Forms.Label();
            this.baslatbtn = new System.Windows.Forms.Button();
            this.durbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sayac1lbl
            // 
            this.sayac1lbl.AutoSize = true;
            this.sayac1lbl.Location = new System.Drawing.Point(96, 81);
            this.sayac1lbl.Name = "sayac1lbl";
            this.sayac1lbl.Size = new System.Drawing.Size(0, 13);
            this.sayac1lbl.TabIndex = 0;
            // 
            // sayac2lbl
            // 
            this.sayac2lbl.AutoSize = true;
            this.sayac2lbl.Location = new System.Drawing.Point(242, 81);
            this.sayac2lbl.Name = "sayac2lbl";
            this.sayac2lbl.Size = new System.Drawing.Size(0, 13);
            this.sayac2lbl.TabIndex = 1;
            // 
            // baslatbtn
            // 
            this.baslatbtn.Location = new System.Drawing.Point(145, 150);
            this.baslatbtn.Name = "baslatbtn";
            this.baslatbtn.Size = new System.Drawing.Size(75, 23);
            this.baslatbtn.TabIndex = 2;
            this.baslatbtn.Text = "Başlat";
            this.baslatbtn.UseVisualStyleBackColor = true;
            this.baslatbtn.Click += new System.EventHandler(this.baslatbtn_Click);
            // 
            // durbtn
            // 
            this.durbtn.Location = new System.Drawing.Point(267, 150);
            this.durbtn.Name = "durbtn";
            this.durbtn.Size = new System.Drawing.Size(75, 23);
            this.durbtn.TabIndex = 3;
            this.durbtn.Text = "Durdur";
            this.durbtn.UseVisualStyleBackColor = true;
            this.durbtn.Click += new System.EventHandler(this.durbtn_Click);
            // 
            // threadfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 227);
            this.Controls.Add(this.durbtn);
            this.Controls.Add(this.baslatbtn);
            this.Controls.Add(this.sayac2lbl);
            this.Controls.Add(this.sayac1lbl);
            this.Name = "threadfrm";
            this.Text = "Threading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sayac1lbl;
        private System.Windows.Forms.Label sayac2lbl;
        private System.Windows.Forms.Button baslatbtn;
        private System.Windows.Forms.Button durbtn;
    }
}

