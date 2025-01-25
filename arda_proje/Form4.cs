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
    public partial class Form4 : Form
    {
        Form1 ana1;
        public Form4()
        {
            InitializeComponent();
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ana1 = (Form1)Application.OpenForms["Form1"];
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            
            MySqlConnection baglantı = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='123456';");
            baglantı.Open();
            MySqlCommand komut = new MySqlCommand($"select * from {ana1.label6.Text}", baglantı);
            MySqlDataReader veri = komut.ExecuteReader();
            while (veri.Read())
            {
                listBox1.Items.Add(veri[0].ToString());
                listBox2.Items.Add(veri[1].ToString().Substring(0,10));
               
               
            }
            baglantı.Close();

        }

        
    }
}
