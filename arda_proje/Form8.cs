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

    public partial class Form8 : Form
    {
        Form1 ana;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            ana = (Form1)Application.OpenForms["Form1"];
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            comboBox1.Items.Clear();

            MySqlConnection baglantı = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='123456';");
            baglantı.Open();
            MySqlCommand komut1 = new MySqlCommand("select kitap_no,kitap_ad,yazar_ad,kitap_tur,kitap_durum from kitaplar", baglantı);
            MySqlDataReader veri = komut1.ExecuteReader();
            while (veri.Read())
            {
                listBox1.Items.Add(veri["kitap_no"].ToString());
                listBox2.Items.Add(veri["kitap_ad"].ToString());
                listBox3.Items.Add(veri["yazar_ad"].ToString());
                listBox4.Items.Add(veri["kitap_tur"].ToString());
                listBox5.Items.Add(veri["kitap_durum"].ToString());
                comboBox1.Items.Add(veri["kitap_ad"].ToString());
            }
            baglantı.Close();
        }

        private void Kitap_silme_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglantı = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='123456';");
                baglantı.Open();
                MySqlCommand komut1 = new MySqlCommand($"delete from kitaplar where kitap_ad='{comboBox1.Text}'", baglantı);
                komut1.ExecuteNonQuery();
                baglantı.Close();

                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();
                listBox5.Items.Clear();
                comboBox1.Items.Clear();


                baglantı.Open();
                MySqlCommand komut = new MySqlCommand("select kitap_no,kitap_ad,yazar_ad,kitap_tur,kitap_durum from kitaplar", baglantı);
                MySqlDataReader veri = komut.ExecuteReader();
                while (veri.Read())
                {
                    listBox1.Items.Add(veri["kitap_no"].ToString());
                    listBox2.Items.Add(veri["kitap_ad"].ToString());
                    listBox3.Items.Add(veri["yazar_ad"].ToString());
                    listBox4.Items.Add(veri["kitap_tur"].ToString());
                    listBox5.Items.Add(veri["kitap_durum"].ToString());
                    comboBox1.Items.Add(veri["kitap_ad"].ToString());
                }
                baglantı.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Silinecek kitabın ismini seçiniz");
            }

        }

        private void Kitap_Ekle_Click(object sender, EventArgs e)
        {
            

                MySqlConnection baglantı = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='123456';");
                baglantı.Open();
                MySqlCommand komut = new MySqlCommand($"select count(kitap_no) from  kitaplar where kitap_ad='{textBox1.Text}' and yazar_ad='{textBox2.Text}' and kitap_tur='{textBox3.Text}'", baglantı);
                MySqlDataReader veri = komut.ExecuteReader();
                veri.Read();
                string kontrol = veri[0].ToString();
                baglantı.Close();
                if (kontrol == "0")
                {
                    baglantı.Open();
                    MySqlCommand komut2 = new MySqlCommand($"select count(kitap_no) from kitaplar ", baglantı);
                    MySqlDataReader veri1 = komut2.ExecuteReader();
                    veri1.Read();
                    int sıra=int.Parse(veri1[0].ToString());
                    sıra++;
                    baglantı.Close();
                    baglantı.Open();
                    MySqlCommand komut1 = new MySqlCommand($"insert into kitaplar values({sıra},'{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','Rafta')", baglantı);
                    komut1.ExecuteNonQuery();
                    baglantı.Close();
                    MessageBox.Show("Kitap ekleme işlemi başarılı");
                }
                else
                {

                    MessageBox.Show("Bu kitap kutuphanede bulunuyor");
                }
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();
                listBox5.Items.Clear();
                comboBox1.Items.Clear();


                baglantı.Open();
                MySqlCommand komut3 = new MySqlCommand("select kitap_no,kitap_ad,yazar_ad,kitap_tur,kitap_durum from kitaplar", baglantı);
                MySqlDataReader veri3 = komut3.ExecuteReader();
                while (veri3.Read())
                {
                    listBox1.Items.Add(veri3["kitap_no"].ToString());
                    listBox2.Items.Add(veri3["kitap_ad"].ToString());
                    listBox3.Items.Add(veri3["yazar_ad"].ToString());
                    listBox4.Items.Add(veri3["kitap_tur"].ToString());
                    listBox5.Items.Add(veri3["kitap_durum"].ToString());
                    comboBox1.Items.Add(veri3["kitap_ad"].ToString());
                }
                baglantı.Close();



            
        }
    }
}
