using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using ZstdSharp.Unsafe;
using Google.Protobuf.WellKnownTypes;

namespace arda_proje
{
    public partial class Form1 : Form
    { 
        Form2 giris=new Form2();
        Form4 kitaplarım=new Form4();
        Form5 odunDurum=new Form5();
        Form6 oduncal=new Form6();
        Form7 oduniade=new Form7();
        Form8 kitap_Islem=new Form8();
       public bool hesap_durum=false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Giris_uyeol_Click(object sender, EventArgs e)
        {
            if (hesap_durum==false)
            giris.ShowDialog();
            else
            {
                label6.Text = " ";
                hesap_durum = false;
                Giris_uyeol.Text = "Giriş/Üye ol";
               
                odunc_al.Enabled = false;
                odunc_iade.Enabled = false;
                odunc_durum.Enabled = false;
                kitap_ıslem.Enabled = false;
                kitap_ıslem.Visible = false;
                ıslem_gecmis.Enabled = false;
                ıslem_gecmis.Visible = false;
                MessageBox.Show("Çıkış işlemi gerçekleştirildi");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            MySqlConnection baglantı = new MySqlConnection("Server=localhost;Database=kutuphane;Uid=root;Pwd='123456';");
            baglantı.Open();
            MySqlCommand komut = new MySqlCommand("select kitap_no,kitap_ad,yazar_ad,kitap_tur,kitap_durum from kitaplar",baglantı);
            MySqlDataReader veri = komut.ExecuteReader();
            while (veri.Read())
            {
                listBox1.Items.Add("          "+veri["kitap_no"].ToString());
                listBox2.Items.Add(veri["kitap_ad"].ToString());
                listBox3.Items.Add(veri["yazar_ad"].ToString());
                listBox4.Items.Add(veri["kitap_tur"].ToString());
                listBox5.Items.Add(veri["kitap_durum"].ToString());
                comboBox1.Items.Add(veri["kitap_tur"].ToString());
            }
            baglantı.Close();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   timer1.Stop();
            giris.ShowDialog();
            
        }

        private void filitre_ara_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();
                listBox5.Items.Clear();
                string kod = "select kitap_no,kitap_ad,yazar_ad,kitap_tur,kitap_durum from kitaplar where ";
                int sayac = 0;


                if (textBox1.Text.Trim() != "")
                {
                    kod += $"kitap_ad like '%{textBox1.Text.Trim()}%'";
                    sayac++;
                }
                if (textBox2.Text.Trim() != "")
                {
                    if (sayac > 0)
                        kod += $"and yazar_ad like '%{textBox2.Text.Trim()}%'";
                    else
                    {
                        kod += $"yazar_ad like '%{textBox2.Text.Trim()}%'";

                    }

                }
                if (comboBox1.SelectedIndex >= 0)
                {
                    if (sayac > 0)
                        kod += $"and kitap_tur='{comboBox1.SelectedItem}'";
                    else
                    {
                        kod += $"kitap_tur='{comboBox1.SelectedItem}'";

                    }
                }
                if (comboBox2.SelectedIndex >= 0)
                {
                    if (sayac > 0)
                        kod += $"and kitap_durum='{comboBox2.SelectedItem}' ";
                    else
                    {
                        kod += $" kitap_durum='{comboBox2.SelectedItem}' ";
                    }
                }

                MySqlConnection baglantı = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='123456';");
                baglantı.Open();
                MySqlCommand komut = new MySqlCommand(kod, baglantı);
                MySqlDataReader veri = komut.ExecuteReader();
                while (veri.Read())
                {
                    listBox1.Items.Add("          " + veri["kitap_no"].ToString());
                    listBox2.Items.Add(veri["kitap_ad"].ToString());
                    listBox3.Items.Add(veri["yazar_ad"].ToString());
                    listBox4.Items.Add(veri["kitap_tur"].ToString());
                    listBox5.Items.Add(veri["kitap_durum"].ToString());

                }
                baglantı.Close();
            }
            catch (Exception)
            {

                
            }
           
           


        }

        private void sıfırla_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();

            MySqlConnection baglantı = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='123456';");
            baglantı.Open();
            MySqlCommand komut1 = new MySqlCommand("select kitap_no,kitap_ad,yazar_ad,kitap_tur,kitap_durum from kitaplar", baglantı);
            MySqlDataReader veri = komut1.ExecuteReader();
            while (veri.Read())
            {
                listBox1.Items.Add("          " + veri["kitap_no"].ToString());
                listBox2.Items.Add(veri["kitap_ad"].ToString());
                listBox3.Items.Add(veri["yazar_ad"].ToString());
                listBox4.Items.Add(veri["kitap_tur"].ToString());
                listBox5.Items.Add(veri["kitap_durum"].ToString());

            }
            baglantı.Close();
        }

        private void odunc_durum_Click(object sender, EventArgs e)
        {
            kitaplarım.ShowDialog();
        }

        private void ıslem_gecmis_Click(object sender, EventArgs e)
        {
            odunDurum.ShowDialog();
        }

        private void odunc_al_Click(object sender, EventArgs e)
        {
            oduncal.ShowDialog();
        }

        private void odunc_iade_Click(object sender, EventArgs e)
        {
            oduniade.ShowDialog();
        }

        private void kitap_ıslem_Click(object sender, EventArgs e)
        {
            kitap_Islem.ShowDialog();
        }
    }
}
