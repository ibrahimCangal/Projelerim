namespace csvokuyaz
{
    partial class csvfrm
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
            this.verilerlst = new System.Windows.Forms.ListBox();
            this.okubtn = new System.Windows.Forms.Button();
            this.getirbtn = new System.Windows.Forms.Button();
            this.gbolumtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gadsoyadtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gnumaratxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.satirnumaratxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara";
            // 
            // numaratxt
            // 
            this.numaratxt.Location = new System.Drawing.Point(89, 22);
            this.numaratxt.Name = "numaratxt";
            this.numaratxt.Size = new System.Drawing.Size(100, 20);
            this.numaratxt.TabIndex = 1;
            // 
            // adsoyadtxt
            // 
            this.adsoyadtxt.Location = new System.Drawing.Point(89, 48);
            this.adsoyadtxt.Name = "adsoyadtxt";
            this.adsoyadtxt.Size = new System.Drawing.Size(100, 20);
            this.adsoyadtxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad Soyad";
            // 
            // bolumtxt
            // 
            this.bolumtxt.Location = new System.Drawing.Point(89, 74);
            this.bolumtxt.Name = "bolumtxt";
            this.bolumtxt.Size = new System.Drawing.Size(100, 20);
            this.bolumtxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bölüm";
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Location = new System.Drawing.Point(114, 109);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(75, 23);
            this.kaydetbtn.TabIndex = 6;
            this.kaydetbtn.Text = "Kaydet";
            this.kaydetbtn.UseVisualStyleBackColor = true;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // verilerlst
            // 
            this.verilerlst.FormattingEnabled = true;
            this.verilerlst.Location = new System.Drawing.Point(302, 22);
            this.verilerlst.Name = "verilerlst";
            this.verilerlst.Size = new System.Drawing.Size(314, 160);
            this.verilerlst.TabIndex = 7;
            // 
            // okubtn
            // 
            this.okubtn.Location = new System.Drawing.Point(221, 20);
            this.okubtn.Name = "okubtn";
            this.okubtn.Size = new System.Drawing.Size(75, 23);
            this.okubtn.TabIndex = 8;
            this.okubtn.Text = "Oku";
            this.okubtn.UseVisualStyleBackColor = true;
            this.okubtn.Click += new System.EventHandler(this.okubtn_Click);
            // 
            // getirbtn
            // 
            this.getirbtn.Location = new System.Drawing.Point(482, 205);
            this.getirbtn.Name = "getirbtn";
            this.getirbtn.Size = new System.Drawing.Size(75, 23);
            this.getirbtn.TabIndex = 15;
            this.getirbtn.Text = "Getir";
            this.getirbtn.UseVisualStyleBackColor = true;
            this.getirbtn.Click += new System.EventHandler(this.getirbtn_Click);
            // 
            // gbolumtxt
            // 
            this.gbolumtxt.Location = new System.Drawing.Point(359, 259);
            this.gbolumtxt.Name = "gbolumtxt";
            this.gbolumtxt.Size = new System.Drawing.Size(100, 20);
            this.gbolumtxt.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Bölüm";
            // 
            // gadsoyadtxt
            // 
            this.gadsoyadtxt.Location = new System.Drawing.Point(359, 233);
            this.gadsoyadtxt.Name = "gadsoyadtxt";
            this.gadsoyadtxt.Size = new System.Drawing.Size(100, 20);
            this.gadsoyadtxt.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ad Soyad";
            // 
            // gnumaratxt
            // 
            this.gnumaratxt.Location = new System.Drawing.Point(359, 207);
            this.gnumaratxt.Name = "gnumaratxt";
            this.gnumaratxt.Size = new System.Drawing.Size(100, 20);
            this.gnumaratxt.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Numara";
            // 
            // satirnumaratxt
            // 
            this.satirnumaratxt.Location = new System.Drawing.Point(566, 207);
            this.satirnumaratxt.Name = "satirnumaratxt";
            this.satirnumaratxt.Size = new System.Drawing.Size(50, 20);
            this.satirnumaratxt.TabIndex = 16;
            // 
            // csvfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 396);
            this.Controls.Add(this.satirnumaratxt);
            this.Controls.Add(this.getirbtn);
            this.Controls.Add(this.gbolumtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gadsoyadtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gnumaratxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.okubtn);
            this.Controls.Add(this.verilerlst);
            this.Controls.Add(this.kaydetbtn);
            this.Controls.Add(this.bolumtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adsoyadtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numaratxt);
            this.Controls.Add(this.label1);
            this.Name = "csvfrm";
            this.Text = "CSV Oku Yaz";
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
        private System.Windows.Forms.ListBox verilerlst;
        private System.Windows.Forms.Button okubtn;
        private System.Windows.Forms.Button getirbtn;
        private System.Windows.Forms.TextBox gbolumtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gadsoyadtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gnumaratxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox satirnumaratxt;
    }
}

