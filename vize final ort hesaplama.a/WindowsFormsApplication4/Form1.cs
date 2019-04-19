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

        double vize,final,ort;
          
        private void button1_Click(object sender, EventArgs e)
        {
            vize = Convert.ToDouble(textBox1.Text);
            final = Convert.ToDouble(textBox2.Text);

            ort=(vize*0.4)+(final*0.6);
            label5.Text = ort.ToString();

            if (ort>=88)
            { label6.Text = "AA"; }

            else if (ort >= 81 && ort <88)
            { label6.Text = "BA"; }

            else if (ort >= 74 && ort < 80)
            { label6.Text = "BB"; }

            else if (ort >= 67  && ort < 73)
            { label6.Text = "CB"; }

            else if (ort >= 60 && ort < 66)
            { label6.Text = "CC"; }

            else if (ort >= 53 && ort < 59)
            { label6.Text = "DC"; }

            else if (ort >= 46 && ort < 52)
            { label6.Text = "DD"; }

            else if (ort >= 39 && ort < 45)
            { label6.Text = "FD"; }

            else
            { label6.Text = "FF"; }
        }

        private void button2_Click(object sender, EventArgs e)      //randomla not sallayıp hesaplama yapacak.
        {
            Random not=new Random();
            double vize, final, ort;

            for (int t = 0; t < 100; t++)
            {
                vize = not.Next(0, 101);     //alınabilecek notlar
                final = not.Next(0, 101);

                ort = (vize * 0.4) + (final * 0.6);

                listBox1.Items.Add(vize);
                listBox2.Items.Add(final);
                listBox3.Items.Add(ort);

                if (ort >= 88)
                { label6.Text = "AA"; }

                else if (ort >= 81 && ort < 88)
                { label6.Text = "BA"; }

                else if (ort >= 74 && ort < 80)
                { label6.Text = "BB"; }

                else if (ort >= 67 && ort < 73)
                { label6.Text = "CB"; }

                else if (ort >= 60 && ort < 66)
                { label6.Text = "CC"; }

                else if (ort >= 53 && ort < 59)
                { label6.Text = "DC"; }

                else if (ort >= 46 && ort < 52)
                { label6.Text = "DD"; }

                else if (ort >= 39 && ort < 45)
                { label6.Text = "FD"; }

                else
                { label6.Text = "FF"; }

                listBox4.Items.Add(label6.Text);
            }
        }











      /*  private void textBox2_TextChanged(object sender, EventArgs e)
        {}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {}
        private void label5_Click(object sender, EventArgs e)
        { }*/
    }
}
