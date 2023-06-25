using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BılgıYYarısmasıı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-SG7L1Q97\\SQLEXPRESS01;Initial Catalog=Sorularrr;Integrated Security=True");
        int sayac = 0;
        int puan = 0;
        int zaman = 20;
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            zaman = 21;


            button5.Text="Sonraki";
            sayac++;
            lblsoru.Text = sayac.ToString();
            button5.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            if (sayac==1)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select*from Sorular1 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
               
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    label1.Text = (oku["dogru"].ToString());

                }
                
               
            }
            baglan.Close();
            if (sayac==2)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select*from Sorular2 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    label1.Text = (oku["dogru"].ToString());

                }
               
            }
            baglan.Close();
            if (sayac==3)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select*from Sorular3 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    label1.Text = (oku["dogru"].ToString());

                }
                baglan.Close();
            }
            if (sayac==4)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select*from Sorular3 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    label1.Text = (oku["dogru"].ToString());

                }
                baglan.Close();
            }
            if (sayac==5)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select*from Sorular4 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    label1.Text = (oku["dogru"].ToString());
                }
            }
            if (sayac==6)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select*from Sorular5 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    label1.Text = (oku["dogru"].ToString());
                }
            }
            if (sayac==7)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select*from Sorular5 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    label1.Text = (oku["dogru"].ToString());
                }
            }
            if (sayac==8)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select*from Sorular6 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    label1.Text = (oku["dogru"].ToString());
                }
            }
            if (sayac==9)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select*from Sorular7 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    label1.Text = (oku["dogru"].ToString());
                }
            }
            if (sayac==10)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select*from Sorular7 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    label1.Text = (oku["dogru"].ToString());
                   

                }
            }
            if (sayac==11)
            {
                MessageBox.Show("Oyun bitti");
                timer1.Enabled = false;
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblsoru.Text = sayac.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (button1.Text==label1.Text)
            {
                
                puan = puan + 10;
                lblpuhan.Text = puan.ToString();




            }
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text==label1.Text)
            {
                puan = puan + 10;
                lblpuhan.Text = puan.ToString();
            }
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text==label1.Text)
            {

                puan = puan + 10;
                lblpuhan.Text = puan.ToString();

            }
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text==label1.Text)
            {
                puan = puan + 10;
                lblpuhan.Text = puan.ToString();

            }
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman = zaman - 1;
            lblzaman.Text = zaman.ToString();
            if (zaman==0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                timer1.Enabled = false;
                button5.Enabled = true;


            }

        }
    }
}
