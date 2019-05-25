using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random salla = new Random();
        int[] sayi = new int[9];
        int sayac = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            //satır toplamları

            int satir1 = 0, satir2 = 0, satir3 = 0;
            satir1 = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text);
            textBox10.Text = satir1.ToString();


            satir2 = Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text);
            textBox11.Text = satir2.ToString();

            satir3 = Convert.ToInt32(textBox7.Text) + Convert.ToInt32(textBox8.Text) + Convert.ToInt32(textBox9.Text);
            textBox12.Text = satir3.ToString();

            //sutun toplamları

            int sutun1 = 0, sutun2 = 0, sutun3 = 0;
            sutun1 = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox7.Text);
            textBox13.Text = sutun1.ToString();

            sutun2 = Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox8.Text);
            textBox14.Text = sutun2.ToString();

            sutun3 = Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox9.Text);
            textBox15.Text = sutun3.ToString();


            if (satir1 == 15 && satir2 == 15 && satir3 == 15 && sutun1 == 15 && sutun2 == 15 && sutun3 == 15)
            {
                MessageBox.Show("Tebrikler kazandınız");
            }
            else
            {
                MessageBox.Show("tekrar deneyiniz!");

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*textBox1.Text = "0";
           textBox2.Text = "0";
           textBox3.Text = "0";
           textBox4.Text = "0";
           textBox5.Text = "0";
           textBox6.Text = "0";
           textBox7.Text = "0";
           textBox8.Text = "0";
           textBox9.Text = "0";*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                int s1;
                s1 = Convert.ToInt32(textBox1.Text);

                if (sayi.Contains(s1))
                {
                    textBox1.Clear();
                    textBox1.Focus();
                    MessageBox.Show("Aynı değeri tekrar girdiniz, değiştriniz!");
                }
                else
                {
                    sayi[sayac] = s1;
                    sayac++;
                    textBox2.Focus();
                }

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                int s1;
                s1 = Convert.ToInt32(textBox2.Text);

                if (sayi.Contains(s1))
                {
                    textBox1.Clear();
                    textBox2.Focus();
                    MessageBox.Show("Aynı değeri tekrar girdiniz, değiştriniz!");
                }
                else
                {
                    sayi[sayac] = s1;
                    sayac++;
                    textBox3.Focus();

                }

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                int s1;
                s1 = Convert.ToInt32(textBox3.Text);

                if (sayi.Contains(s1))
                {
                    textBox3.Clear();
                    textBox3.Focus();
                    MessageBox.Show("Aynı değeri tekrar girdiniz, değiştriniz!");
                }
                else
                {
                    sayi[sayac] = s1;
                    textBox4.Focus();
                    sayac++;
                }

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                int s1;
                s1 = Convert.ToInt32(textBox4.Text);

                if (sayi.Contains(s1))
                {
                    textBox4.Clear();
                    textBox4.Focus();
                    MessageBox.Show("Aynı değeri tekrar girdiniz, değiştriniz!");
                }
                else
                {
                    sayi[sayac] = s1;
                    sayac++;
                    textBox5.Focus();

                }

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                int s1;
                s1 = Convert.ToInt32(textBox5.Text);

                if (sayi.Contains(s1))
                {
                    textBox5.Clear();
                    textBox5.Focus();
                    MessageBox.Show("Aynı değeri tekrar girdiniz, değiştriniz!");
                }
                else
                {
                    sayi[sayac] = s1;
                    sayac++;
                    textBox6.Focus();

                }
            }


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                int s1;
                s1 = Convert.ToInt32(textBox6.Text);

                if (sayi.Contains(s1))
                {
                    textBox6.Clear();
                    textBox6.Focus();
                    MessageBox.Show("Aynı değeri tekrar girdiniz, değiştriniz!");
                }
                else
                {
                    sayi[sayac] = s1;
                    textBox7.Focus();
                    sayac++;
                }

            }

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                int s1;
                s1 = Convert.ToInt32(textBox7.Text);

                if (sayi.Contains(s1))
                {
                    textBox7.Clear();
                    textBox7.Focus();
                    MessageBox.Show("Aynı değeri tekrar girdiniz, değiştriniz!");
                }
                else
                {
                    sayi[sayac] = s1;
                    textBox8.Focus();
                    sayac++;
                }
            }


        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
            {
                int s1;
                s1 = Convert.ToInt32(textBox8.Text);

                if (sayi.Contains(s1))
                {
                    textBox8.Clear();
                    textBox8.Focus();
                    MessageBox.Show("Aynı değeri tekrar girdiniz, değiştriniz!");
                }
                else
                {
                    sayi[sayac] = s1;
                    textBox9.Focus();
                    sayac++;
                }
            }

        }



        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                int s1;
                s1 = Convert.ToInt32(textBox9.Text);

                if (sayi.Contains(s1))
                {
                    textBox9.Clear();
                    textBox9.Focus();
                    MessageBox.Show("Aynı değeri tekrar girdiniz, değiştriniz!");
                }
                else
                {
                    sayi[sayac] = s1;
                    sayac++;
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sayi.Length; i++)
            {
                sayi[i] = 0;
            }
            sayac = 0;
            textBox1.Text = salla.Next(1, 10).ToString();
            textBox5.Text = salla.Next(1, 10).ToString();
            textBox9.Text = salla.Next(1, 10).ToString();
        }

    }
}