using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10_luk_tabandan_2lik_tabana_çevirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi;
        int mod;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            sayi = Convert.ToInt32(textBox1.Text);

            while (sayi > 1)
            {
               
                mod = sayi % 2;
                sayi = sayi / 2;
                label1.Text = mod.ToString()+label1.Text;
            }

            label1.Text = sayi.ToString()+label1.Text;
        }
    }
}
