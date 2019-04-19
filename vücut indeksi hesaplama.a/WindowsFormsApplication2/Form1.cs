using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy, kilo,sonuc;
            boy = Convert.ToDouble(textBox1.Text);
            kilo = Convert.ToDouble(textBox2.Text);

            boy = boy / 100;                                 //virgüllü olarak algılaması için
            sonuc = (kilo) / (boy*boy);                      //indeksi hesaplama işlemi

            label3.Text = sonuc.ToString();

            if (sonuc < 18.5)
            { label3.Text = "ZAYIF"; }

            else if (18.5 < sonuc && sonuc < 25)
            { label3.Text = "NORMAL"; }

            else if (25 < sonuc && sonuc < 30)
            { label3.Text = "KİLOLU"; }

            else if (30 < sonuc && sonuc < 40)
            { label3.Text = "OBEZ"; }

            else 
            { label3.Text = "FAZLA OBEZ"; }
        }
       
    }
}
