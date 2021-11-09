namespace bilgiyarismasi
{
    partial class bilgifrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cevaplist = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sorurtb = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.skorlbl = new System.Windows.Forms.Label();
            this.sonuclbl = new System.Windows.Forms.Label();
            this.cevaplabtn = new System.Windows.Forms.Button();
            this.sorusayitxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yeniyarismabtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.joker1btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgi Yarışması";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bilgiyarismasi.Properties.Resources.bilgisayarismasi;
            this.pictureBox1.Location = new System.Drawing.Point(18, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(737, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cevaplist);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.sorurtb);
            this.groupBox2.Location = new System.Drawing.Point(12, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 326);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Soru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(325, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "CEVAPLAR";
            // 
            // cevaplist
            // 
            this.cevaplist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevaplist.FormattingEnabled = true;
            this.cevaplist.ItemHeight = 25;
            this.cevaplist.Location = new System.Drawing.Point(18, 144);
            this.cevaplist.Name = "cevaplist";
            this.cevaplist.Size = new System.Drawing.Size(737, 154);
            this.cevaplist.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(350, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SORU";
            // 
            // sorurtb
            // 
            this.sorurtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorurtb.Location = new System.Drawing.Point(18, 42);
            this.sorurtb.Name = "sorurtb";
            this.sorurtb.Size = new System.Drawing.Size(737, 72);
            this.sorurtb.TabIndex = 0;
            this.sorurtb.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 467);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 117);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seçenekler";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.skorlbl);
            this.groupBox5.Controls.Add(this.sonuclbl);
            this.groupBox5.Controls.Add(this.cevaplabtn);
            this.groupBox5.Controls.Add(this.sorusayitxt);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.yeniyarismabtn);
            this.groupBox5.Location = new System.Drawing.Point(264, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(491, 92);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Yarışma Seçenekleri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Skor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sonuç:";
            // 
            // skorlbl
            // 
            this.skorlbl.AutoSize = true;
            this.skorlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorlbl.Location = new System.Drawing.Point(199, 55);
            this.skorlbl.Name = "skorlbl";
            this.skorlbl.Size = new System.Drawing.Size(0, 16);
            this.skorlbl.TabIndex = 5;
            // 
            // sonuclbl
            // 
            this.sonuclbl.AutoSize = true;
            this.sonuclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuclbl.Location = new System.Drawing.Point(199, 27);
            this.sonuclbl.Name = "sonuclbl";
            this.sonuclbl.Size = new System.Drawing.Size(0, 16);
            this.sonuclbl.TabIndex = 4;
            // 
            // cevaplabtn
            // 
            this.cevaplabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevaplabtn.Location = new System.Drawing.Point(342, 26);
            this.cevaplabtn.Name = "cevaplabtn";
            this.cevaplabtn.Size = new System.Drawing.Size(131, 46);
            this.cevaplabtn.TabIndex = 3;
            this.cevaplabtn.Text = "CEVAPLA";
            this.cevaplabtn.UseVisualStyleBackColor = true;
            this.cevaplabtn.Click += new System.EventHandler(this.cevaplabtn_Click);
            // 
            // sorusayitxt
            // 
            this.sorusayitxt.Location = new System.Drawing.Point(84, 26);
            this.sorusayitxt.Name = "sorusayitxt";
            this.sorusayitxt.Size = new System.Drawing.Size(62, 20);
            this.sorusayitxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soru Sayısı";
            // 
            // yeniyarismabtn
            // 
            this.yeniyarismabtn.Location = new System.Drawing.Point(61, 52);
            this.yeniyarismabtn.Name = "yeniyarismabtn";
            this.yeniyarismabtn.Size = new System.Drawing.Size(85, 23);
            this.yeniyarismabtn.TabIndex = 0;
            this.yeniyarismabtn.Text = "Yeni Yarışma";
            this.yeniyarismabtn.UseVisualStyleBackColor = true;
            this.yeniyarismabtn.Click += new System.EventHandler(this.yeniyarismabtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.joker1btn);
            this.groupBox4.Location = new System.Drawing.Point(18, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 92);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Jokerler";
            // 
            // joker1btn
            // 
            this.joker1btn.Location = new System.Drawing.Point(81, 41);
            this.joker1btn.Name = "joker1btn";
            this.joker1btn.Size = new System.Drawing.Size(75, 23);
            this.joker1btn.TabIndex = 0;
            this.joker1btn.Text = "%50 Joker";
            this.joker1btn.UseVisualStyleBackColor = true;
            this.joker1btn.Click += new System.EventHandler(this.joker1btn_Click);
            // 
            // bilgifrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "bilgifrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgi Yarışması";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox cevaplist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox sorurtb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox sorusayitxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button yeniyarismabtn;
        private System.Windows.Forms.Button cevaplabtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label skorlbl;
        private System.Windows.Forms.Label sonuclbl;
        private System.Windows.Forms.Button joker1btn;
    }
}

