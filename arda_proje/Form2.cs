using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace arda_proje
{
    public partial class Form2 : Form
    {
        Form3 uyeol=new Form3();
        Form1 ana;
        
        public Form2()
        {
            InitializeComponent();
           
        } 
        private void Form2_Load(object sender, EventArgs e)
        {
            ana = (Form1)Application.OpenForms["Form1"];
        }

       
        private void ziyaretci_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            ana.label6.Text = "Ziyaretci";
            ana.hesap_durum = false;
        }

        private void uyeol_button_Click(object sender, EventArgs e)
        {
            uyeol.ShowDialog();
        }

        private void giris_button_Click(object sender, EventArgs e)
        {
            MySqlConnection baglantı = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='123456';");
            baglantı.Open();
            MySqlCommand komut = new MySqlCommand($"select count(Kullanıcı_ad) from uyeler where Kullanıcı_ad='{textBox1.Text}'", baglantı);
            MySqlDataReader veri = komut.ExecuteReader();
            veri.Read();
            string ad_durum = veri[0].ToString();
            if (ad_durum == "1")
            {
                baglantı.Close();
                baglantı.Open();
                MySqlCommand komut1 = new MySqlCommand($"select Sifre from uyeler where Kullanıcı_ad='{textBox1.Text}'", baglantı);
                MySqlDataReader veri1= komut1.ExecuteReader();
                veri1.Read();
                string sifre_durum= veri1[0].ToString();
                if (textBox2.Text == sifre_durum)
                {
                    MessageBox.Show("Giriş işlemi başarıyla gerçekleşti");
                    ana.label6.Text = textBox1.Text;
                    ana.odunc_durum.Enabled = true;
                    ana.odunc_al.Enabled = true;
                    ana.odunc_iade.Enabled = true;
                    if (textBox1.Text == "admin")
                    {
                        ana.kitap_ıslem.Enabled = true;
                        ana.kitap_ıslem.Visible = true;
                        ana.ıslem_gecmis.Enabled = true;
                        ana.ıslem_gecmis.Visible = true;
                    }
                    ana.hesap_durum = true;
                    ana.Giris_uyeol.Text = "Çıkış";
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı yada şifre yanlış girilmiştir lütfen tekrar deneyiniz.");

                }

            }
            else
            {
                MessageBox.Show("Kullanıcı adı yada şifre yanlış girilmiştir lütfen tekrar deneyiniz.");

            }
        }


    }
}
