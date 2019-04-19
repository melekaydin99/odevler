using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kimlikkontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UInt64 tcNo , bol=1;
        UInt64[] dizi=new UInt64[12];                               //dizi açma komutu

        private void button1_Click(object sender, EventArgs e)
        {
            tcNo = Convert.ToUInt64(textBox1.Text);
            UInt64 kontrol, kontrol2;   
        
            for (int i=11; i >= 1; i--)
            {
                dizi[i] = (tcNo / bol) % 10;
                listBox1.Items.Add(dizi[i]);
                bol = bol * 10;
            }

            kontrol = (dizi[1] + dizi[3] + dizi[5] + dizi[7] + dizi[9]) * 7 - ( dizi[2] + dizi[4] + dizi[6] + dizi[8]);
            kontrol = kontrol % 10;

            kontrol2= (dizi[1] + dizi[2] + dizi[3] + dizi[4] + dizi[5] + dizi[6] + dizi[7] + dizi[8] + dizi[9] + dizi[10]);
            kontrol2 = kontrol2 % 10;

            label3.Text = kontrol.ToString();
            label4.Text = kontrol2.ToString();

            if (kontrol == dizi[10] && kontrol2 == dizi[11])
            {
                MessageBox.Show("Doğru");
            }

            else { MessageBox.Show("Yanlış"); }



          /*  b2 = tcNo/10 % 10;
            listBox1.Items.Add(b2);
            
            b3 = tcNo/100 % 10;
            listBox1.Items.Add(b3);

            b4 = tcNo / 1000 % 10;
            listBox1.Items.Add(b4);

            b5 = tcNo/10000 % 10;
            listBox1.Items.Add(b5);
            */

            label2.Text = tcNo.ToString();
        }
    }
}
