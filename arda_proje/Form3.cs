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

namespace arda_proje
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void uye_ol_Click(object sender, EventArgs e)
        {
            MySqlConnection baglantı = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='123456';");
            baglantı.Open();
            MySqlCommand komut = new MySqlCommand($"select count(Kullanıcı_ad) from uyeler where Kullanıcı_ad='{textBox4.Text}'", baglantı);
            MySqlDataReader veri = komut.ExecuteReader();
            veri.Read();
            if (veri[0].ToString() == "0")
            {
                baglantı.Close();
                baglantı.Open();
                MySqlCommand komut1 = new MySqlCommand($"insert into uyeler values('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}')",baglantı);
                komut1.ExecuteNonQuery();
                baglantı.Close();
                baglantı.Open() ;
                MySqlCommand komut2 = new MySqlCommand($"create table {textBox4.Text}(Kitap_ad varchar(20),Odunc_alıs date)", baglantı);
                komut2.ExecuteNonQuery();
                MessageBox.Show("Üye olma işleminiz başarıyla gerçekleşmiştir.");
                this.Close();

            }
            else
            {
                MessageBox.Show("Bu kullancı adı kullanılmıştır lütfen başka bir kullanıcı adı yazınız.");

            }


        }
    }
}
