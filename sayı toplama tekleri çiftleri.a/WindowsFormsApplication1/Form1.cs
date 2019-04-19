using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int toplam=0;
        int sayi;
        private void button1_Click(object sender, EventArgs e)  
        {
            //kullanıcının textboxa girdiği sayı dahil küçük sayıları toplar
       
             int ust;
            ust = Convert.ToInt32 (textBox1.Text);

            for (int i = 1; i <=ust ; i++ )
            {
                toplam = toplam + i;
            }

            label1.Text = toplam.ToString();
            toplam = 0;         

        }

        private void button2_Click(object sender, EventArgs e)
        {
             //kullanıcının textboxa girdiği sayı dahil tek sayıları toplar
            int toplam=0;
               sayi = Convert.ToInt32 (textBox1.Text);
               int mod;
               mod = sayi % 2;                                       //mod alma
               if (mod == 0)
               {
                   sayi = sayi - 1;

               }
                toplam = toplam + sayi;
                   while (sayi != 1) 
                   {
                       sayi = sayi - 2;
                       toplam = toplam + sayi;
                   } 
               
               label2.Text = toplam.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //kullanıcının textboxa girdiği sayı dahil çift sayıları toplar

            
            int toplam = 0;
            sayi = Convert.ToInt32(textBox1.Text);
            int mod;
            mod = sayi % 2;                                       //mod alma
            if (mod == 1)
            {
                sayi = sayi - 1;

            }
            toplam = toplam + sayi;
            while (sayi != 0)
            {
                sayi = sayi - 2;
                toplam = toplam + sayi;
            }

            label4.Text = toplam.ToString();
        }

        
    }
}
