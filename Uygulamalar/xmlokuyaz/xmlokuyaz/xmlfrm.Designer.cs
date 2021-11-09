namespace xmlokuyaz
{
    partial class xmlfrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.numaratxt = new System.Windows.Forms.TextBox();
            this.adsoyadtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bolumtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.okubtn = new System.Windows.Forms.Button();
            this.xmlverdgv = new System.Windows.Forms.DataGridView();
            this.xmlyazbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xmlverdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara";
            // 
            // numaratxt
            // 
            this.numaratxt.Location = new System.Drawing.Point(84, 20);
            this.numaratxt.Name = "numaratxt";
            this.numaratxt.Size = new System.Drawing.Size(100, 20);
            this.numaratxt.TabIndex = 1;
            // 
            // adsoyadtxt
            // 
            this.adsoyadtxt.Location = new System.Drawing.Point(84, 46);
            this.adsoyadtxt.Name = "adsoyadtxt";
            this.adsoyadtxt.Size = new System.Drawing.Size(100, 20);
            this.adsoyadtxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad Soyad";
            // 
            // bolumtxt
            // 
            this.bolumtxt.Location = new System.Drawing.Point(84, 72);
            this.bolumtxt.Name = "bolumtxt";
            this.bolumtxt.Size = new System.Drawing.Size(100, 20);
            this.bolumtxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bölüm";
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Location = new System.Drawing.Point(207, 18);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(75, 23);
            this.kaydetbtn.TabIndex = 6;
            this.kaydetbtn.Text = "Kaydet";
            this.kaydetbtn.UseVisualStyleBackColor = true;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // okubtn
            // 
            this.okubtn.Location = new System.Drawing.Point(207, 70);
            this.okubtn.Name = "okubtn";
            this.okubtn.Size = new System.Drawing.Size(75, 23);
            this.okubtn.TabIndex = 7;
            this.okubtn.Text = "XML Oku";
            this.okubtn.UseVisualStyleBackColor = true;
            this.okubtn.Click += new System.EventHandler(this.okubtn_Click);
            // 
            // xmlverdgv
            // 
            this.xmlverdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xmlverdgv.Location = new System.Drawing.Point(12, 125);
            this.xmlverdgv.Name = "xmlverdgv";
            this.xmlverdgv.Size = new System.Drawing.Size(270, 289);
            this.xmlverdgv.TabIndex = 8;
            // 
            // xmlyazbtn
            // 
            this.xmlyazbtn.Location = new System.Drawing.Point(207, 44);
            this.xmlyazbtn.Name = "xmlyazbtn";
            this.xmlyazbtn.Size = new System.Drawing.Size(75, 23);
            this.xmlyazbtn.TabIndex = 9;
            this.xmlyazbtn.Text = "XML Yaz";
            this.xmlyazbtn.UseVisualStyleBackColor = true;
            this.xmlyazbtn.Click += new System.EventHandler(this.xmlyazbtn_Click);
            // 
            // xmlfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 427);
            this.Controls.Add(this.xmlyazbtn);
            this.Controls.Add(this.xmlverdgv);
            this.Controls.Add(this.okubtn);
            this.Controls.Add(this.kaydetbtn);
            this.Controls.Add(this.bolumtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adsoyadtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numaratxt);
            this.Controls.Add(this.label1);
            this.Name = "xmlfrm";
            this.Text = "XML Oku Yaz";
            ((System.ComponentModel.ISupportInitialize)(this.xmlverdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numaratxt;
        private System.Windows.Forms.TextBox adsoyadtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bolumtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button kaydetbtn;
        private System.Windows.Forms.Button okubtn;
        private System.Windows.Forms.DataGridView xmlverdgv;
        private System.Windows.Forms.Button xmlyazbtn;
    }
}

