namespace arastir
{
    partial class arastirfrm
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
            this.aranantxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.arabtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dizinsecbtn = new System.Windows.Forms.Button();
            this.belirlidizintxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.uygulamasurrd = new System.Windows.Forms.RadioButton();
            this.belirtilendizinrd = new System.Windows.Forms.RadioButton();
            this.tumsurucurd = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.sonuclist = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aranan";
            // 
            // aranantxt
            // 
            this.aranantxt.Location = new System.Drawing.Point(61, 31);
            this.aranantxt.Name = "aranantxt";
            this.aranantxt.Size = new System.Drawing.Size(369, 20);
            this.aranantxt.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.arabtn);
            this.groupBox1.Controls.Add(this.aranantxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aranan";
            // 
            // arabtn
            // 
            this.arabtn.Location = new System.Drawing.Point(456, 29);
            this.arabtn.Name = "arabtn";
            this.arabtn.Size = new System.Drawing.Size(75, 23);
            this.arabtn.TabIndex = 3;
            this.arabtn.Text = "Ara";
            this.arabtn.UseVisualStyleBackColor = true;
            this.arabtn.Click += new System.EventHandler(this.arabtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 199);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seçenekler";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dizinsecbtn);
            this.groupBox4.Controls.Add(this.belirlidizintxt);
            this.groupBox4.Location = new System.Drawing.Point(258, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(286, 105);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Belirlenen Dizin";
            // 
            // dizinsecbtn
            // 
            this.dizinsecbtn.Location = new System.Drawing.Point(198, 66);
            this.dizinsecbtn.Name = "dizinsecbtn";
            this.dizinsecbtn.Size = new System.Drawing.Size(75, 23);
            this.dizinsecbtn.TabIndex = 1;
            this.dizinsecbtn.Text = "Dizin Seç";
            this.dizinsecbtn.UseVisualStyleBackColor = true;
            this.dizinsecbtn.Click += new System.EventHandler(this.dizinsecbtn_Click);
            // 
            // belirlidizintxt
            // 
            this.belirlidizintxt.Location = new System.Drawing.Point(15, 29);
            this.belirlidizintxt.Name = "belirlidizintxt";
            this.belirlidizintxt.Size = new System.Drawing.Size(258, 20);
            this.belirlidizintxt.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.uygulamasurrd);
            this.groupBox3.Controls.Add(this.belirtilendizinrd);
            this.groupBox3.Controls.Add(this.tumsurucurd);
            this.groupBox3.Location = new System.Drawing.Point(17, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 145);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dizin Seçenekleri";
            // 
            // uygulamasurrd
            // 
            this.uygulamasurrd.AutoSize = true;
            this.uygulamasurrd.Location = new System.Drawing.Point(23, 66);
            this.uygulamasurrd.Name = "uygulamasurrd";
            this.uygulamasurrd.Size = new System.Drawing.Size(177, 17);
            this.uygulamasurrd.TabIndex = 1;
            this.uygulamasurrd.TabStop = true;
            this.uygulamasurrd.Text = "Uygulamanın Bulunduğu Sürücü";
            this.uygulamasurrd.UseVisualStyleBackColor = true;
            this.uygulamasurrd.CheckedChanged += new System.EventHandler(this.uygulamasurrd_CheckedChanged);
            // 
            // belirtilendizinrd
            // 
            this.belirtilendizinrd.AutoSize = true;
            this.belirtilendizinrd.Location = new System.Drawing.Point(23, 100);
            this.belirtilendizinrd.Name = "belirtilendizinrd";
            this.belirtilendizinrd.Size = new System.Drawing.Size(121, 17);
            this.belirtilendizinrd.TabIndex = 2;
            this.belirtilendizinrd.TabStop = true;
            this.belirtilendizinrd.Text = "Belirtilen Dizinde Ara";
            this.belirtilendizinrd.UseVisualStyleBackColor = true;
            this.belirtilendizinrd.CheckedChanged += new System.EventHandler(this.belirtilendizinrd_CheckedChanged);
            // 
            // tumsurucurd
            // 
            this.tumsurucurd.AutoSize = true;
            this.tumsurucurd.Location = new System.Drawing.Point(23, 32);
            this.tumsurucurd.Name = "tumsurucurd";
            this.tumsurucurd.Size = new System.Drawing.Size(94, 17);
            this.tumsurucurd.TabIndex = 0;
            this.tumsurucurd.TabStop = true;
            this.tumsurucurd.Text = "Tüm Sürücüler";
            this.tumsurucurd.UseVisualStyleBackColor = true;
            this.tumsurucurd.CheckedChanged += new System.EventHandler(this.tumsurucurd_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.sonuclist);
            this.groupBox5.Location = new System.Drawing.Point(12, 302);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(561, 268);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sonuçlar";
            // 
            // sonuclist
            // 
            this.sonuclist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sonuclist.FormattingEnabled = true;
            this.sonuclist.HorizontalScrollbar = true;
            this.sonuclist.Location = new System.Drawing.Point(3, 16);
            this.sonuclist.Name = "sonuclist";
            this.sonuclist.ScrollAlwaysVisible = true;
            this.sonuclist.Size = new System.Drawing.Size(555, 249);
            this.sonuclist.TabIndex = 0;
            // 
            // arastirfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 582);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "arastirfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araştır";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aranantxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button arabtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button dizinsecbtn;
        private System.Windows.Forms.TextBox belirlidizintxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton uygulamasurrd;
        private System.Windows.Forms.RadioButton belirtilendizinrd;
        private System.Windows.Forms.RadioButton tumsurucurd;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox sonuclist;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

