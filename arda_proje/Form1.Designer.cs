namespace arda_proje
{
    partial class Form1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ıslem_gecmis = new System.Windows.Forms.Button();
            this.odunc_durum = new System.Windows.Forms.Button();
            this.Giris_uyeol = new System.Windows.Forms.Button();
            this.odunc_iade = new System.Windows.Forms.Button();
            this.odunc_al = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sıfırla = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.filitre_ara = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.kitap_ıslem = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.kitap_ıslem);
            this.panel2.Controls.Add(this.ıslem_gecmis);
            this.panel2.Controls.Add(this.odunc_durum);
            this.panel2.Controls.Add(this.Giris_uyeol);
            this.panel2.Controls.Add(this.odunc_iade);
            this.panel2.Controls.Add(this.odunc_al);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 54);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hesap:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // ıslem_gecmis
            // 
            this.ıslem_gecmis.Enabled = false;
            this.ıslem_gecmis.Location = new System.Drawing.Point(409, 10);
            this.ıslem_gecmis.Name = "ıslem_gecmis";
            this.ıslem_gecmis.Size = new System.Drawing.Size(82, 34);
            this.ıslem_gecmis.TabIndex = 4;
            this.ıslem_gecmis.Text = "İşlem geçmişi";
            this.ıslem_gecmis.UseVisualStyleBackColor = false;
            this.ıslem_gecmis.Visible = false;
            this.ıslem_gecmis.Click += new System.EventHandler(this.ıslem_gecmis_Click);
            // 
            // odunc_durum
            // 
            this.odunc_durum.Enabled = false;
            this.odunc_durum.Location = new System.Drawing.Point(321, 9);
            this.odunc_durum.Name = "odunc_durum";
            this.odunc_durum.Size = new System.Drawing.Size(82, 35);
            this.odunc_durum.TabIndex = 4;
            this.odunc_durum.Text = "Ödünç Durum";
            this.odunc_durum.UseVisualStyleBackColor = false;
            this.odunc_durum.Click += new System.EventHandler(this.odunc_durum_Click);
            // 
            // Giris_uyeol
            // 
            this.Giris_uyeol.Location = new System.Drawing.Point(622, 9);
            this.Giris_uyeol.Name = "Giris_uyeol";
            this.Giris_uyeol.Size = new System.Drawing.Size(98, 34);
            this.Giris_uyeol.TabIndex = 3;
            this.Giris_uyeol.Text = "Giriş/Üye ol";
            this.Giris_uyeol.UseVisualStyleBackColor = true;
            this.Giris_uyeol.Click += new System.EventHandler(this.Giris_uyeol_Click);
            // 
            // odunc_iade
            // 
            this.odunc_iade.Enabled = false;
            this.odunc_iade.Location = new System.Drawing.Point(233, 9);
            this.odunc_iade.Name = "odunc_iade";
            this.odunc_iade.Size = new System.Drawing.Size(82, 34);
            this.odunc_iade.TabIndex = 1;
            this.odunc_iade.Text = "Ödünç iade";
            this.odunc_iade.UseVisualStyleBackColor = false;
            this.odunc_iade.Click += new System.EventHandler(this.odunc_iade_Click);
            // 
            // odunc_al
            // 
            this.odunc_al.Enabled = false;
            this.odunc_al.Location = new System.Drawing.Point(140, 9);
            this.odunc_al.Name = "odunc_al";
            this.odunc_al.Size = new System.Drawing.Size(87, 34);
            this.odunc_al.TabIndex = 0;
            this.odunc_al.Text = "Ödünç Al";
            this.odunc_al.UseVisualStyleBackColor = false;
            this.odunc_al.Click += new System.EventHandler(this.odunc_al_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.sıfırla);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.filitre_ara);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 396);
            this.panel1.TabIndex = 2;
            // 
            // sıfırla
            // 
            this.sıfırla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sıfırla.Location = new System.Drawing.Point(11, 344);
            this.sıfırla.Name = "sıfırla";
            this.sıfırla.Size = new System.Drawing.Size(98, 39);
            this.sıfırla.TabIndex = 9;
            this.sıfırla.Text = "Sıfırla";
            this.sıfırla.UseVisualStyleBackColor = true;
            this.sıfırla.Click += new System.EventHandler(this.sıfırla_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Kitap Durumu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Kitap Türü:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Rafta",
            "Odunc verildi"});
            this.comboBox2.Location = new System.Drawing.Point(7, 202);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(104, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Yazar Adı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Kitap Adı:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(104, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 1;
            // 
            // filitre_ara
            // 
            this.filitre_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filitre_ara.Location = new System.Drawing.Point(11, 280);
            this.filitre_ara.Name = "filitre_ara";
            this.filitre_ara.Size = new System.Drawing.Size(99, 47);
            this.filitre_ara.TabIndex = 0;
            this.filitre_ara.Text = "Ara";
            this.filitre_ara.UseVisualStyleBackColor = true;
            this.filitre_ara.Click += new System.EventHandler(this.filitre_ara_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBox5);
            this.panel3.Controls.Add(this.listBox4);
            this.panel3.Controls.Add(this.listBox3);
            this.panel3.Controls.Add(this.listBox2);
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(132, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 396);
            this.panel3.TabIndex = 3;
            // 
            // listBox5
            // 
            this.listBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 16;
            this.listBox5.Location = new System.Drawing.Point(501, 30);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(102, 366);
            this.listBox5.TabIndex = 6;
            // 
            // listBox4
            // 
            this.listBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(383, 30);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(118, 366);
            this.listBox4.TabIndex = 5;
            // 
            // listBox3
            // 
            this.listBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(233, 30);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(150, 366);
            this.listBox3.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(93, 30);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(140, 366);
            this.listBox2.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(93, 366);
            this.listBox1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(603, 30);
            this.panel4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(514, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kitap Durum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(403, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kitap Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(269, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yazar Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(122, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kitap Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap No";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kitap_ıslem
            // 
            this.kitap_ıslem.Enabled = false;
            this.kitap_ıslem.Location = new System.Drawing.Point(497, 9);
            this.kitap_ıslem.Name = "kitap_ıslem";
            this.kitap_ıslem.Size = new System.Drawing.Size(82, 34);
            this.kitap_ıslem.TabIndex = 4;
            this.kitap_ıslem.Text = "Kitap Ekle/Çıkar";
            this.kitap_ıslem.UseVisualStyleBackColor = false;
            this.kitap_ıslem.Visible = false;
            this.kitap_ıslem.Click += new System.EventHandler(this.kitap_ıslem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button filitre_ara;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button odunc_durum;
        public System.Windows.Forms.Button odunc_iade;
        public System.Windows.Forms.Button odunc_al;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button Giris_uyeol;
        private System.Windows.Forms.Button sıfırla;
        public System.Windows.Forms.Button ıslem_gecmis;
        public System.Windows.Forms.Button kitap_ıslem;
    }
}

