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

        private void button1_Click(object sender, EventArgs e)
        {
            Random salla = new Random();
            for (int t = 0; t < 1000; t++)
            {
                string tc = "";
                int kontrol;
                int kontrol1;

                int[] a = new int[12];

                for (int i = 1; i <= 11; i++)
                {
                    a[i] = salla.Next(0, 10);
                    tc = tc + a[i].ToString();
                }

                kontrol  = ((a[1] + a[3] + a[5] + a[7] + a[9]) * 7 - (a[2] + a[4]  + a[6] + a[8])) % 10;
                kontrol1 = (a[1] + a[2] + a[3] + a[4] + a[5]+ a[6] + a[7] + a[8] + a[9] + a[10])%10;

                if (kontrol == a[10] && kontrol1==a[11])
                {
                    listBox1.Items.Add(tc);
                }

            }
        }
    }
}
