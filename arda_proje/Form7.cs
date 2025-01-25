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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace arda_proje
{
    public partial class Form7 : Form
    {
        Form1 ana;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            ana = (Form1)Application.OpenForms["Form1"];
            MySqlConnection baglantı = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='123456';");
            baglantı.Open();
            MySqlCommand komut1 = new MySqlCommand($"select kitap_ad from {ana.label6.Text}", baglantı);
            MySqlDataReader veri = komut1.ExecuteReader();
            while (veri.Read())
            {
                listBox1.Items.Add(veri[0].ToString());
                comboBox1.Items.Add(veri[0].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection baglantı = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='123456';");
            baglantı.Open();
            MySqlCommand komut1 = new MySqlCommand($"delete from {ana.label6.Text} where kitap_ad='{comboBox1.Text}'", baglantı);
            komut1.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("iade işlemi başarılı");

            baglantı.Close();
            baglantı.Open();
            MySqlCommand komut3 = new MySqlCommand($"insert into tum_ıslem values('{comboBox1.Text}','{ana.label6.Text}','Ödünç iade',now())", baglantı);
            komut3.ExecuteNonQuery();
            baglantı.Close();

            listBox1.Items.Clear();
            comboBox1.Items.Clear();

            baglantı.Open();
            MySqlCommand komut2 = new MySqlCommand($"select kitap_ad from {ana.label6.Text}", baglantı);
            MySqlDataReader veri = komut2.ExecuteReader();
            while (veri.Read())
            {
                listBox1.Items.Add(veri[0].ToString());
                comboBox1.Items.Add(veri[0].ToString());
            }

            baglantı.Close() ;
            baglantı.Open();
            MySqlCommand komut = new MySqlCommand($"update kitaplar set kitap_durum='Rafta' where kitap_ad='{comboBox1.Text}'", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();

        }
    }
}
