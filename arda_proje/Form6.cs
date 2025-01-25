using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arda_proje
{
    public partial class Form6 : Form
    {
        Form1 ana;
        public Form6()
        {
            InitializeComponent();
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            ana = (Form1)Application.OpenForms["Form1"];
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            MySqlConnection baglantı = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='123456';");
            baglantı.Open();
            MySqlCommand komut1 = new MySqlCommand("select kitap_no,kitap_ad,kitap_durum from kitaplar", baglantı);
            MySqlDataReader veri = komut1.ExecuteReader();
            while (veri.Read())
            {
                listBox3.Items.Add("        " + veri["kitap_no"].ToString());
                listBox2.Items.Add(veri["kitap_ad"].ToString());
                listBox1.Items.Add(veri["kitap_durum"].ToString());
                comboBox1.Items.Add(veri["kitap_ad"].ToString());
            }
            baglantı.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            MySqlConnection baglantı = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='123456';");
            baglantı.Open();
            MySqlCommand komut1 = new MySqlCommand($"select kitap_no,kitap_ad,kitap_durum from kitaplar where kitap_ad like '%{textBox1.Text}%'", baglantı);
            MySqlDataReader veri = komut1.ExecuteReader();
            while (veri.Read())
            {
                listBox3.Items.Add("        " + veri["kitap_no"].ToString());
                listBox2.Items.Add(veri["kitap_ad"].ToString());
                listBox1.Items.Add(veri["kitap_durum"].ToString());

            }
            baglantı.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            MySqlConnection baglantı = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='123456';");
            baglantı.Open();
            MySqlCommand komut1 = new MySqlCommand("select kitap_no,kitap_ad,kitap_durum from kitaplar", baglantı);
            MySqlDataReader veri = komut1.ExecuteReader();
            while (veri.Read())
            {
                listBox3.Items.Add("        " + veri["kitap_no"].ToString());
                listBox2.Items.Add(veri["kitap_ad"].ToString());
                listBox1.Items.Add(veri["kitap_durum"].ToString());

            }
            baglantı.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection baglantı = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='123456';");
            baglantı.Open();
            MySqlCommand komut1 = new MySqlCommand($"select kitap_durum,kitap_ad from kitaplar where kitap_ad='{comboBox1.Text}'", baglantı);
            MySqlDataReader veri = komut1.ExecuteReader();
            veri.Read();
            string ad = veri[1].ToString();
         
            string durum = veri[0].ToString();
            if (durum == "Rafta")
            {
                
                baglantı.Close() ;
                baglantı.Open();
                MySqlCommand komut = new MySqlCommand($"update kitaplar set kitap_durum='Odunc verildi' where kitap_ad='{comboBox1.Text}'", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                baglantı.Open() ;
                MySqlCommand komut2 = new MySqlCommand($"insert into {ana.label6.Text}(Kitap_ad,Odunc_alıs) values('{ad}',now())", baglantı);
                komut2.ExecuteNonQuery();
                baglantı.Close();
                baglantı.Open();
                MySqlCommand komut3 = new MySqlCommand($"insert into tum_ıslem values('{ad}','{ana.label6.Text}','Ödünç alma',now())", baglantı);
                komut3.ExecuteNonQuery();

                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();

                baglantı.Close();
                baglantı.Open();
                MySqlCommand komut4 = new MySqlCommand("select kitap_no,kitap_ad,kitap_durum from kitaplar", baglantı);
                MySqlDataReader veri4 = komut4.ExecuteReader();
                while (veri4.Read())
                {
                    listBox3.Items.Add("        " + veri4["kitap_no"].ToString());
                    listBox2.Items.Add(veri4["kitap_ad"].ToString());
                    listBox1.Items.Add(veri4["kitap_durum"].ToString());

                }
                baglantı.Close();

                MessageBox.Show("ödünç alma işlemi başarıyla gerçekleşti");
            }
            else
            {
                MessageBox.Show("Seçilen kitap başka kişiye ödünç verilmiş ");
            }
        }
    }
}
