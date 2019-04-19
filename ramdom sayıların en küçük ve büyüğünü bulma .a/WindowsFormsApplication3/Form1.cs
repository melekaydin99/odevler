using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random salla = new Random();        //Random
        int [] sayi =new int [100];         //Dizi


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {}
        private void Form1_Load(object sender, EventArgs e)
        { }


        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i<100 ; i++)
            { 
                sayi[i] = salla.Next(1, 1001);
                listBox1.Items.Add(sayi[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int enkucuk=10000;

            for (int k=0; k<100 ; k++)
            {
                if (sayi[k] < enkucuk)
                {
                    enkucuk = sayi[k];
                }
            }
            label1.Text = enkucuk.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int enbuyuk = -1;

            for (int k = 0; k < 100; k++)
            {
                if (sayi[k] > enbuyuk)
                {
                    enbuyuk = sayi[k];
                }
            }
            label2.Text = enbuyuk.ToString();
        }

        
    }
}
