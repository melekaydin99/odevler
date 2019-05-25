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
        //Fibonacci

        int[] fibo = new int[101];


        private void button1_Click(object sender, EventArgs e)
        {
            fibo[0] = 1;
            fibo[1] = 1;
            
            listBox1.Items.Add(fibo[0]);
            listBox1.Items.Add(fibo[1]);

            int kac;
            kac = Convert.ToInt32(textBox1.Text);

            for (int i = 2; i <= kac; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
                listBox1.Items.Add(fibo[i]);
            }

            label1.Text = fibo[kac].ToString();
        }
    }
}
