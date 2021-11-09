namespace tarihformatla
{
    partial class tarihFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tarihdtp = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sonuctxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ulkecmb = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarih";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tarihdtp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 69);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarih Bilgisi Girişi";
            // 
            // tarihdtp
            // 
            this.tarihdtp.Location = new System.Drawing.Point(57, 27);
            this.tarihdtp.Name = "tarihdtp";
            this.tarihdtp.Size = new System.Drawing.Size(200, 20);
            this.tarihdtp.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.sonuctxt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ulkecmb);
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 101);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Formatlanmış Tarih Çıktısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sonuç";
            // 
            // sonuctxt
            // 
            this.sonuctxt.Location = new System.Drawing.Point(57, 60);
            this.sonuctxt.Name = "sonuctxt";
            this.sonuctxt.Size = new System.Drawing.Size(200, 20);
            this.sonuctxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ülke";
            // 
            // ulkecmb
            // 
            this.ulkecmb.FormattingEnabled = true;
            this.ulkecmb.Items.AddRange(new object[] {
            "Türkiye uzun format",
            "Türkiye kısa format",
            "Türkiye tam format",
            "USA tam format",
            "USA yıl başta",
            "USA yıl sonda",
            "Arjantin sayısal",
            "Arjantin kısa",
            "Arjantin orta",
            "Arjantin uzun",
            "Arjantin tam"});
            this.ulkecmb.Location = new System.Drawing.Point(57, 33);
            this.ulkecmb.Name = "ulkecmb";
            this.ulkecmb.Size = new System.Drawing.Size(200, 21);
            this.ulkecmb.TabIndex = 0;
            this.ulkecmb.SelectedIndexChanged += new System.EventHandler(this.ulkecmb_SelectedIndexChanged);
            // 
            // tarihFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 201);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "tarihFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarih Formatla";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker tarihdtp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sonuctxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ulkecmb;
    }
}

