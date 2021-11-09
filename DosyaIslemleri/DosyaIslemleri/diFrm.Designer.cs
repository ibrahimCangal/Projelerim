namespace DosyaIslemleri
{
    partial class diFrm
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
            this.components = new System.ComponentModel.Container();
            this.arananTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.araBtn = new System.Windows.Forms.Button();
            this.dosyaLst = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dizinTxt = new System.Windows.Forms.TextBox();
            this.silMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // arananTxt
            // 
            this.arananTxt.Location = new System.Drawing.Point(123, 37);
            this.arananTxt.Name = "arananTxt";
            this.arananTxt.Size = new System.Drawing.Size(146, 20);
            this.arananTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aranacak Dosya Adı";
            // 
            // araBtn
            // 
            this.araBtn.Location = new System.Drawing.Point(281, 35);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(75, 23);
            this.araBtn.TabIndex = 2;
            this.araBtn.Text = "Ara";
            this.araBtn.UseVisualStyleBackColor = true;
            this.araBtn.Click += new System.EventHandler(this.araBtn_Click);
            // 
            // dosyaLst
            // 
            this.dosyaLst.ContextMenuStrip = this.silMenu;
            this.dosyaLst.FormattingEnabled = true;
            this.dosyaLst.Location = new System.Drawing.Point(12, 63);
            this.dosyaLst.Name = "dosyaLst";
            this.dosyaLst.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.dosyaLst.Size = new System.Drawing.Size(340, 212);
            this.dosyaLst.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dizin";
            // 
            // dizinTxt
            // 
            this.dizinTxt.Location = new System.Drawing.Point(123, 11);
            this.dizinTxt.Name = "dizinTxt";
            this.dizinTxt.Size = new System.Drawing.Size(146, 20);
            this.dizinTxt.TabIndex = 4;
            // 
            // silMenu
            // 
            this.silMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.silMenu.Name = "silMenu";
            this.silMenu.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // diFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 286);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dizinTxt);
            this.Controls.Add(this.dosyaLst);
            this.Controls.Add(this.araBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arananTxt);
            this.Name = "diFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dosya İşlemleri";
            this.silMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox arananTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button araBtn;
        private System.Windows.Forms.ListBox dosyaLst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dizinTxt;
        private System.Windows.Forms.ContextMenuStrip silMenu;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}

