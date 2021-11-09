namespace ekrangoruntusual
{
    partial class ekranfrm
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
            this.ekrangorpb = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gecmislst = new System.Windows.Forms.ListBox();
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.ekrangabtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ekrangorpb)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ekrangorpb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekran Görüntüsü";
            // 
            // ekrangorpb
            // 
            this.ekrangorpb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ekrangorpb.Location = new System.Drawing.Point(3, 16);
            this.ekrangorpb.Name = "ekrangorpb";
            this.ekrangorpb.Size = new System.Drawing.Size(623, 407);
            this.ekrangorpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ekrangorpb.TabIndex = 0;
            this.ekrangorpb.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.gecmislst);
            this.groupBox2.Controls.Add(this.kaydetbtn);
            this.groupBox2.Controls.Add(this.ekrangabtn);
            this.groupBox2.Location = new System.Drawing.Point(647, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kontroller";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Geçmiş";
            // 
            // gecmislst
            // 
            this.gecmislst.FormattingEnabled = true;
            this.gecmislst.Location = new System.Drawing.Point(6, 104);
            this.gecmislst.Name = "gecmislst";
            this.gecmislst.Size = new System.Drawing.Size(129, 316);
            this.gecmislst.TabIndex = 2;
            this.gecmislst.Click += new System.EventHandler(this.gecmislst_Click);
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Location = new System.Drawing.Point(29, 58);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(75, 23);
            this.kaydetbtn.TabIndex = 1;
            this.kaydetbtn.Text = "Kaydet";
            this.kaydetbtn.UseVisualStyleBackColor = true;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // ekrangabtn
            // 
            this.ekrangabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekrangabtn.Location = new System.Drawing.Point(6, 29);
            this.ekrangabtn.Name = "ekrangabtn";
            this.ekrangabtn.Size = new System.Drawing.Size(129, 23);
            this.ekrangabtn.TabIndex = 0;
            this.ekrangabtn.Text = "Ekran Görüntüsü Al";
            this.ekrangabtn.UseVisualStyleBackColor = true;
            this.ekrangabtn.Click += new System.EventHandler(this.ekrangabtn_Click);
            // 
            // ekranfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ekranfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ekran Görüntüsü Al";
            this.Load += new System.EventHandler(this.ekranfrm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ekrangorpb)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox gecmislst;
        private System.Windows.Forms.Button kaydetbtn;
        private System.Windows.Forms.Button ekrangabtn;
        private System.Windows.Forms.PictureBox ekrangorpb;
    }
}

