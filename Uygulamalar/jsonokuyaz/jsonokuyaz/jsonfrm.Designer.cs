namespace jsonokuyaz
{
    partial class jsonfrm
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
            this.jsonyazbtn = new System.Windows.Forms.Button();
            this.jsonveridgv = new System.Windows.Forms.DataGridView();
            this.jsonokubtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jsonveridgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara";
            // 
            // numaratxt
            // 
            this.numaratxt.Location = new System.Drawing.Point(75, 23);
            this.numaratxt.Name = "numaratxt";
            this.numaratxt.Size = new System.Drawing.Size(100, 20);
            this.numaratxt.TabIndex = 1;
            // 
            // adsoyadtxt
            // 
            this.adsoyadtxt.Location = new System.Drawing.Point(75, 49);
            this.adsoyadtxt.Name = "adsoyadtxt";
            this.adsoyadtxt.Size = new System.Drawing.Size(100, 20);
            this.adsoyadtxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adı Soyadı";
            // 
            // bolumtxt
            // 
            this.bolumtxt.Location = new System.Drawing.Point(75, 75);
            this.bolumtxt.Name = "bolumtxt";
            this.bolumtxt.Size = new System.Drawing.Size(100, 20);
            this.bolumtxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bölüm";
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Location = new System.Drawing.Point(210, 21);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(75, 23);
            this.kaydetbtn.TabIndex = 6;
            this.kaydetbtn.Text = "Kaydet";
            this.kaydetbtn.UseVisualStyleBackColor = true;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // jsonyazbtn
            // 
            this.jsonyazbtn.Location = new System.Drawing.Point(210, 47);
            this.jsonyazbtn.Name = "jsonyazbtn";
            this.jsonyazbtn.Size = new System.Drawing.Size(75, 23);
            this.jsonyazbtn.TabIndex = 7;
            this.jsonyazbtn.Text = "JSON Yaz";
            this.jsonyazbtn.UseVisualStyleBackColor = true;
            this.jsonyazbtn.Click += new System.EventHandler(this.jsonyazbtn_Click);
            // 
            // jsonveridgv
            // 
            this.jsonveridgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jsonveridgv.Location = new System.Drawing.Point(12, 115);
            this.jsonveridgv.Name = "jsonveridgv";
            this.jsonveridgv.Size = new System.Drawing.Size(273, 235);
            this.jsonveridgv.TabIndex = 8;
            // 
            // jsonokubtn
            // 
            this.jsonokubtn.Location = new System.Drawing.Point(210, 76);
            this.jsonokubtn.Name = "jsonokubtn";
            this.jsonokubtn.Size = new System.Drawing.Size(75, 23);
            this.jsonokubtn.TabIndex = 9;
            this.jsonokubtn.Text = "JSON Oku";
            this.jsonokubtn.UseVisualStyleBackColor = true;
            this.jsonokubtn.Click += new System.EventHandler(this.jsonokubtn_Click);
            // 
            // jsonfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 365);
            this.Controls.Add(this.jsonokubtn);
            this.Controls.Add(this.jsonveridgv);
            this.Controls.Add(this.jsonyazbtn);
            this.Controls.Add(this.kaydetbtn);
            this.Controls.Add(this.bolumtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adsoyadtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numaratxt);
            this.Controls.Add(this.label1);
            this.Name = "jsonfrm";
            this.Text = "JSON Oku Yaz";
            ((System.ComponentModel.ISupportInitialize)(this.jsonveridgv)).EndInit();
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
        private System.Windows.Forms.Button jsonyazbtn;
        private System.Windows.Forms.DataGridView jsonveridgv;
        private System.Windows.Forms.Button jsonokubtn;
    }
}

