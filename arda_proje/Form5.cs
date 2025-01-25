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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            

            MySqlConnection baglantı = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='123456';");
            baglantı.Open();
            MySqlCommand komut1 = new MySqlCommand("select * from tum_ıslem", baglantı);
            MySqlDataReader veri = komut1.ExecuteReader();
            while (veri.Read())
            {
                listBox1.Items.Add(veri[0].ToString());
                listBox2.Items.Add(veri[1].ToString());
                listBox3.Items.Add(veri[2].ToString());
                listBox4.Items.Add(veri[3].ToString().Substring(0,10));
              

            }
            baglantı.Close();
        }
    }
}
