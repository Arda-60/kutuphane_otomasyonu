namespace arda_proje
{
    partial class Form2
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
            this.giris_button = new System.Windows.Forms.Button();
            this.uyeol_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ziyaretci = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // giris_button
            // 
            this.giris_button.Location = new System.Drawing.Point(130, 140);
            this.giris_button.Name = "giris_button";
            this.giris_button.Size = new System.Drawing.Size(75, 23);
            this.giris_button.TabIndex = 3;
            this.giris_button.Text = "Giriş";
            this.giris_button.UseVisualStyleBackColor = true;
            this.giris_button.Click += new System.EventHandler(this.giris_button_Click);
            // 
            // uyeol_button
            // 
            this.uyeol_button.Location = new System.Drawing.Point(130, 178);
            this.uyeol_button.Name = "uyeol_button";
            this.uyeol_button.Size = new System.Drawing.Size(75, 23);
            this.uyeol_button.TabIndex = 4;
            this.uyeol_button.Text = "Üye ol";
            this.uyeol_button.UseVisualStyleBackColor = true;
            this.uyeol_button.Click += new System.EventHandler(this.uyeol_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı adı";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 55);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 99);
            this.textBox2.MaxLength = 20;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // ziyaretci
            // 
            this.ziyaretci.AutoSize = true;
            this.ziyaretci.LinkColor = System.Drawing.Color.Black;
            this.ziyaretci.Location = new System.Drawing.Point(104, 220);
            this.ziyaretci.Name = "ziyaretci";
            this.ziyaretci.Size = new System.Drawing.Size(126, 13);
            this.ziyaretci.TabIndex = 5;
            this.ziyaretci.TabStop = true;
            this.ziyaretci.Text = "Ziyaretçi olarak devam et";
            this.ziyaretci.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ziyaretci_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 272);
            this.Controls.Add(this.ziyaretci);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uyeol_button);
            this.Controls.Add(this.giris_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giris_button;
        private System.Windows.Forms.Button uyeol_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.LinkLabel ziyaretci;
    }
}