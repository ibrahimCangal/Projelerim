namespace downloadweb
{
    partial class downloadWebFrm
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
            this.urltxt = new System.Windows.Forms.TextBox();
            this.htmlrtb = new System.Windows.Forms.RichTextBox();
            this.indirBtn = new System.Windows.Forms.Button();
            this.topluindirbtn = new System.Windows.Forms.Button();
            this.urllerrtb = new System.Windows.Forms.RichTextBox();
            this.durumlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // urltxt
            // 
            this.urltxt.Location = new System.Drawing.Point(12, 12);
            this.urltxt.Name = "urltxt";
            this.urltxt.Size = new System.Drawing.Size(188, 20);
            this.urltxt.TabIndex = 0;
            // 
            // htmlrtb
            // 
            this.htmlrtb.Location = new System.Drawing.Point(12, 38);
            this.htmlrtb.Name = "htmlrtb";
            this.htmlrtb.Size = new System.Drawing.Size(188, 211);
            this.htmlrtb.TabIndex = 1;
            this.htmlrtb.Text = "";
            // 
            // indirBtn
            // 
            this.indirBtn.Location = new System.Drawing.Point(206, 10);
            this.indirBtn.Name = "indirBtn";
            this.indirBtn.Size = new System.Drawing.Size(75, 23);
            this.indirBtn.TabIndex = 2;
            this.indirBtn.Text = "İndir";
            this.indirBtn.UseVisualStyleBackColor = true;
            this.indirBtn.Click += new System.EventHandler(this.indirBtn_Click);
            // 
            // topluindirbtn
            // 
            this.topluindirbtn.Location = new System.Drawing.Point(494, 10);
            this.topluindirbtn.Name = "topluindirbtn";
            this.topluindirbtn.Size = new System.Drawing.Size(75, 23);
            this.topluindirbtn.TabIndex = 3;
            this.topluindirbtn.Text = "Toplu İndir";
            this.topluindirbtn.UseVisualStyleBackColor = true;
            this.topluindirbtn.Click += new System.EventHandler(this.topluindirbtn_Click);
            // 
            // urllerrtb
            // 
            this.urllerrtb.Location = new System.Drawing.Point(308, 12);
            this.urllerrtb.Name = "urllerrtb";
            this.urllerrtb.Size = new System.Drawing.Size(180, 237);
            this.urllerrtb.TabIndex = 4;
            this.urllerrtb.Text = "";
            // 
            // durumlbl
            // 
            this.durumlbl.AutoSize = true;
            this.durumlbl.Location = new System.Drawing.Point(305, 263);
            this.durumlbl.Name = "durumlbl";
            this.durumlbl.Size = new System.Drawing.Size(0, 13);
            this.durumlbl.TabIndex = 5;
            // 
            // downloadWebFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 299);
            this.Controls.Add(this.durumlbl);
            this.Controls.Add(this.urllerrtb);
            this.Controls.Add(this.topluindirbtn);
            this.Controls.Add(this.indirBtn);
            this.Controls.Add(this.htmlrtb);
            this.Controls.Add(this.urltxt);
            this.Name = "downloadWebFrm";
            this.Text = "Web Sayfası İndir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urltxt;
        private System.Windows.Forms.RichTextBox htmlrtb;
        private System.Windows.Forms.Button indirBtn;
        private System.Windows.Forms.Button topluindirbtn;
        private System.Windows.Forms.RichTextBox urllerrtb;
        private System.Windows.Forms.Label durumlbl;
    }
}

