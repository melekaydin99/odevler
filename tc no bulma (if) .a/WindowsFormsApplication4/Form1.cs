using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //direk 100 tane doğru tc no üretir
        {
            Random salla = new Random();

            for (int t = 0; t < 100; t++)
            {
                string tc = "";

                int[] a = new int[12];

                a[1] = salla.Next(1, 10);   //0 ile başlamaz
                tc = tc + a[1].ToString();

                for (int i = 2; i <= 9; i++) 
                {
                    a[i] = salla.Next(0, 10);
                    tc = tc + a[i].ToString();
                }

                //tc no doğru olma kuralları
                a[10] = ((a[1] + a[3] + a[5] + a[7] + a[9]) * 7 - (a[2] + a[4]  + a[6] + a[8])) % 10;
                tc = tc + a[10].ToString();
                a[11] = (a[1] + a[2] + a[3] + a[4] + a[5]+ a[6] + a[7] + a[8] + a[9] + a[10])%10;
                tc = tc + a[11].ToString();
                
                listBox1.Items.Add(tc);
                

            }
        }
    }
}
