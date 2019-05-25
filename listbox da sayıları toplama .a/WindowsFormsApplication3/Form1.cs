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

        private void button1_Click(object sender, EventArgs e)
           
        { 
           
            int[] a = new int[100];

            int[] b = new int[100];

            int[] toplam = new int[100];

         /* toplam[0] = a[0] + b[0]; 
            toplam[1] = a[1] + b[1];
            toplam[2] = a[2] + b[2];
            toplam[3] = a[3] + b[3]; 
          
            label1.Text = toplam[0].ToString();
            label2.Text = toplam[1].ToString();
            label3.Text = toplam[2].ToString();
            label4.Text = toplam[3].ToString();*/ 
           
            Random salla = new Random();
            
            for (int i = 0; i<100; i++ ) 
            {
              
                a[i] = salla.Next(0, 100);
                b[i] = salla.Next(0, 100);

            /*  a[1] = salla.Next(0, 100);
                a[2] = salla.Next(0, 100);
                a[3] = salla.Next(0, 100);  */


                toplam[i] = a[i] + b[i];
                listBox1.Items.Add(a[i]);
                listBox2.Items.Add(b[i]);
                listBox3.Items.Add(toplam[i]);
               
            }
        }
    }
}
