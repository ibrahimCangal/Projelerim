namespace resimgalerisi
{
    partial class resimgalerifrm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.galeripb = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.otomatikchk = new System.Windows.Forms.CheckBox();
            this.sagabtn = new System.Windows.Forms.Button();
            this.solabtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.resimlerlv = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.farklikaydetbtn = new System.Windows.Forms.Button();
            this.resimacbtn = new System.Windows.Forms.Button();
            this.iceriaktarbtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galeripb)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.galeripb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 503);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Galeri";
            // 
            // galeripb
            // 
            this.galeripb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.galeripb.Location = new System.Drawing.Point(3, 16);
            this.galeripb.Name = "galeripb";
            this.galeripb.Size = new System.Drawing.Size(696, 484);
            this.galeripb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.galeripb.TabIndex = 0;
            this.galeripb.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.otomatikchk);
            this.groupBox2.Controls.Add(this.sagabtn);
            this.groupBox2.Controls.Add(this.solabtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 521);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Galeri Kontrol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sn.";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(216, 19);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // otomatikchk
            // 
            this.otomatikchk.AutoSize = true;
            this.otomatikchk.Enabled = false;
            this.otomatikchk.Location = new System.Drawing.Point(216, 52);
            this.otomatikchk.Name = "otomatikchk";
            this.otomatikchk.Size = new System.Drawing.Size(68, 17);
            this.otomatikchk.TabIndex = 2;
            this.otomatikchk.Text = "Otomatik";
            this.otomatikchk.UseVisualStyleBackColor = true;
            this.otomatikchk.CheckedChanged += new System.EventHandler(this.otomatikchk_CheckedChanged);
            // 
            // sagabtn
            // 
            this.sagabtn.Enabled = false;
            this.sagabtn.Location = new System.Drawing.Point(117, 33);
            this.sagabtn.Name = "sagabtn";
            this.sagabtn.Size = new System.Drawing.Size(75, 23);
            this.sagabtn.TabIndex = 1;
            this.sagabtn.Text = ">>>";
            this.sagabtn.UseVisualStyleBackColor = true;
            this.sagabtn.Click += new System.EventHandler(this.sagabtn_Click);
            // 
            // solabtn
            // 
            this.solabtn.Enabled = false;
            this.solabtn.Location = new System.Drawing.Point(22, 33);
            this.solabtn.Name = "solabtn";
            this.solabtn.Size = new System.Drawing.Size(75, 23);
            this.solabtn.TabIndex = 0;
            this.solabtn.Text = "<<<";
            this.solabtn.UseVisualStyleBackColor = true;
            this.solabtn.Click += new System.EventHandler(this.solabtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.resimlerlv);
            this.groupBox3.Location = new System.Drawing.Point(720, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 593);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resimlerim";
            // 
            // resimlerlv
            // 
            this.resimlerlv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resimlerlv.HideSelection = false;
            this.resimlerlv.Location = new System.Drawing.Point(3, 16);
            this.resimlerlv.Name = "resimlerlv";
            this.resimlerlv.Size = new System.Drawing.Size(313, 574);
            this.resimlerlv.TabIndex = 0;
            this.resimlerlv.UseCompatibleStateImageBehavior = false;
            this.resimlerlv.SelectedIndexChanged += new System.EventHandler(this.resimlerlv_SelectedIndexChanged);
            this.resimlerlv.Click += new System.EventHandler(this.resimlerlv_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.farklikaydetbtn);
            this.groupBox4.Controls.Add(this.resimacbtn);
            this.groupBox4.Controls.Add(this.iceriaktarbtn);
            this.groupBox4.Location = new System.Drawing.Point(332, 521);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(379, 84);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resim Kontrolleri";
            // 
            // farklikaydetbtn
            // 
            this.farklikaydetbtn.Location = new System.Drawing.Point(108, 33);
            this.farklikaydetbtn.Name = "farklikaydetbtn";
            this.farklikaydetbtn.Size = new System.Drawing.Size(84, 23);
            this.farklikaydetbtn.TabIndex = 2;
            this.farklikaydetbtn.Text = "Farklı Kaydet";
            this.farklikaydetbtn.UseVisualStyleBackColor = true;
            this.farklikaydetbtn.Click += new System.EventHandler(this.farklikaydetbtn_Click);
            // 
            // resimacbtn
            // 
            this.resimacbtn.Location = new System.Drawing.Point(198, 33);
            this.resimacbtn.Name = "resimacbtn";
            this.resimacbtn.Size = new System.Drawing.Size(75, 23);
            this.resimacbtn.TabIndex = 1;
            this.resimacbtn.Text = "Resim Aç";
            this.resimacbtn.UseVisualStyleBackColor = true;
            this.resimacbtn.Click += new System.EventHandler(this.resimacbtn_Click);
            // 
            // iceriaktarbtn
            // 
            this.iceriaktarbtn.Location = new System.Drawing.Point(279, 33);
            this.iceriaktarbtn.Name = "iceriaktarbtn";
            this.iceriaktarbtn.Size = new System.Drawing.Size(75, 23);
            this.iceriaktarbtn.TabIndex = 0;
            this.iceriaktarbtn.Text = "İçeri Aktar";
            this.iceriaktarbtn.UseVisualStyleBackColor = true;
            this.iceriaktarbtn.Click += new System.EventHandler(this.iceriaktarbtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Jpeg dosyaları (*.jpg)|*.jpg|Tüm dosyalar (*.*)|";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // resimgalerifrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 617);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "resimgalerifrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resim Galerisi";
            this.Load += new System.EventHandler(this.resimgalerifrm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galeripb)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox galeripb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox otomatikchk;
        private System.Windows.Forms.Button sagabtn;
        private System.Windows.Forms.Button solabtn;
        private System.Windows.Forms.ListView resimlerlv;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button farklikaydetbtn;
        private System.Windows.Forms.Button resimacbtn;
        private System.Windows.Forms.Button iceriaktarbtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}

