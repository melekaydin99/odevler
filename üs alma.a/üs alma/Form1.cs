using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace üs_alma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int taban;
            int us;
            taban = Convert.ToInt32(textBox1.Text);
            us = Convert.ToInt32(textBox2.Text);
            int carpım = 1;
            for (int i = 1; i <=us; i++ )
            {
                carpım = carpım*taban;
            }

            label1.Text = carpım.ToString();
        }


       

        

        
    }
}
