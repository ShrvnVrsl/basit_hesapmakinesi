using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hsmkns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private char Islem;
        private bool ekransilinecekmi;
        int ilksayi;
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ekransilinecekmi)
            {
                ekran_label.Text = " ";
                ekransilinecekmi = false;
            }
            if (ekran_label.Text == "0")
            {
                ekran_label.Text = " ";
            }
            ekran_label.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ekransilinecekmi)
            {
                ekran_label.Text = " ";
                ekransilinecekmi = false;
            }
            if (ekran_label.Text == "0")
            {
                ekran_label.Text = " ";
            }
            ekran_label.Text += "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ekransilinecekmi)
            {
                ekran_label.Text = " ";
                ekransilinecekmi = false;
            }
            if (ekran_label.Text == "0")
            {
                ekran_label.Text = " ";
            }
            ekran_label.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Islem = '+';
            ekransilinecekmi = true;
            ilksayi = Convert.ToInt32(ekran_label.Text);
    }

        private void button11_Click(object sender, EventArgs e)
        {
            Islem = '-';
            ekransilinecekmi = true;
            ilksayi = Convert.ToInt32(ekran_label.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ekransilinecekmi)
            {
                ekran_label.Text = " ";
                ekransilinecekmi = false;
            }
            if (ekran_label.Text=="0")
            {
                ekran_label.Text = " ";
            }
            ekran_label.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (ekransilinecekmi)
            {
                ekran_label.Text = " ";
                ekransilinecekmi = false;
            }
            if (ekran_label.Text == "0")
            {
                ekran_label.Text = " ";
            }
            ekran_label.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ekransilinecekmi)
            {
                ekran_label.Text = " ";
                ekransilinecekmi = false;
            }
            if (ekran_label.Text == "0")
            {
                ekran_label.Text = " ";
            }
            ekran_label.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ekransilinecekmi)
            {
                ekran_label.Text = " ";
                ekransilinecekmi = false;
            }
            if (ekran_label.Text == "0")
            {
                ekran_label.Text = " ";
            }
            ekran_label.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ekransilinecekmi)
            {
                ekran_label.Text = " ";
                ekransilinecekmi = false;
            }
            if (ekran_label.Text == "0")
            {
                ekran_label.Text = " ";
            }
            ekran_label.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ekransilinecekmi)
            {
                ekran_label.Text = " ";
                ekransilinecekmi = false;
            }
            if (ekran_label.Text == "0")
            {
                ekran_label.Text = " ";
            }
            ekran_label.Text += "8";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (ekransilinecekmi)
            {
                ekran_label.Text = " ";
                ekransilinecekmi = false;
            }
            if (ekran_label.Text == "0")
            {
                ekran_label.Text = " ";
            }
            ekran_label.Text += "0";
        }

        private void button_esittir_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(ekran_label.Text);
            int sonc;
            switch (Islem)
            {
                case '+':
                    sonc = ilksayi + ikincisayi;
                    break;

                case '-':
                    sonc = ilksayi - ikincisayi;
                    break;

                case '*':
                    sonc = ilksayi * ikincisayi;
                    break;

                case '/':
                    sonc = ilksayi / ikincisayi;
                    break;
                default:
                    sonc = 0;
                    break;
            }

            ekran_label.Text = Convert.ToString(sonc);
        }

        private void button_carp_Click(object sender, EventArgs e)
        {
            Islem = '*';
            ekransilinecekmi = true;
            ilksayi = Convert.ToInt32(ekran_label.Text);
        }

        private void button_bol_Click(object sender, EventArgs e)
        {
            Islem = '/';
            ekransilinecekmi = true;
            ilksayi = Convert.ToInt32(ekran_label.Text);
        }
    }
}
