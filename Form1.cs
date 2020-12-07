using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasKagıtMakas
{
    public partial class Form1 : Form
    {
        int kullanıcı = 0;
        int bilgisayar = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_TasKagıtMakas_Click(object sender, EventArgs e)
        {
            if (rdbTas.Checked)
            {
                Random rnd = new Random();
                int sayi = rnd.Next(3);
                if (sayi == 2)
                {
                    MessageBox.Show("Sen Kazandın!");
                    kullanıcı++;
                    lblKullanıcı.Text = kullanıcı.ToString();
                    listBox1.Items.Add("Taş-----Makas");
                }
                else if (sayi == 1)
                {
                    MessageBox.Show("Ben Kazandım!");
                    bilgisayar++;
                    lblBilgisayar.Text = bilgisayar.ToString();
                    listBox1.Items.Add("Taş-----Kağıt");
                }
                else
                {
                    MessageBox.Show("İkimiz de taş seçtik tekrar.");
                    listBox1.Items.Add("Taş-----Taş");
                }
            }
            else if (rdbKagıt.Checked)
            {
                Random rnd = new Random();
                int sayi = rnd.Next(3);
                if (sayi == 0)
                {
                    MessageBox.Show("Sen Kazandın");
                    kullanıcı++;
                    lblKullanıcı.Text = kullanıcı.ToString();
                    listBox1.Items.Add("Kağıt-----Taş");
                }
                else if (sayi == 2)
                {
                    MessageBox.Show("Ben kazandım.");
                    bilgisayar++;
                    lblBilgisayar.Text = bilgisayar.ToString();
                    listBox1.Items.Add("Kağıt-----Makas");
                }
                else
                {
                    MessageBox.Show("İkimiz de kağıt seçtik tekrar.");
                    listBox1.Items.Add("Kağıt-----Kağıt");

                }
            }
            else
            {
                Random rnd = new Random();
                int sayi = rnd.Next(3);
                if (sayi == 1)
                {
                    MessageBox.Show("Sen Kazandın");
                    kullanıcı++;
                    lblKullanıcı.Text = kullanıcı.ToString();
                    listBox1.Items.Add("Makas-----Kağıt");
                }
                else if (sayi == 0)
                {
                    MessageBox.Show("Ben kazandım");
                    bilgisayar++;
                    lblBilgisayar.Text = bilgisayar.ToString();
                    listBox1.Items.Add("Makas-----Taş");
                }
                else
                {
                    MessageBox.Show("İkimiz de makas seçtik tekrar.");
                    listBox1.Items.Add("Makas-----Makas");
                }
            }     
	{
            }

            }

        private void btn_YeniOyun_Click(object sender, EventArgs e)
        {
            lblKullanıcı.Text = "0";
            lblBilgisayar.Text = "0";
            listBox1.Items.Clear();
        }
    }
    }

