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

        string[] yarismaci = new string[] {"talha","samet","polat","muhammed","sema","sümeyye","melek","uğur","halit","dilek"};
        string[] soyad = new string[]     {"aydın","güngör","kütük", "polat","özer","tekin","demir","kaya","efeler","yücel"};
        Random salla = new Random();
     // int sayac=0;

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for(int i=0; i< yarismaci.Length; i++)  //yarışmacı sayısı kadar dönmesi için lenght ekledik
            {
                listBox1.Items.Add(yarismaci[i]);
            }

            int kazanan;
            kazanan = salla.Next(0,yarismaci.Length);
            MessageBox.Show("kazanan isim=" + yarismaci[kazanan]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < 100; a++)
            {
                dataGridView1.Rows.Add();
                int kazanan, soyisim;
                kazanan = salla.Next(0, yarismaci.Length);
                soyisim = salla.Next(0, soyad.Length);

                dataGridView1.Rows[a].Cells[0].Value = yarismaci[kazanan];  //kazananın adını ekler
                dataGridView1.Rows[a].Cells[1].Value = soyad[soyisim];      //kazananın soyadını ekler
            //    sayac++;  //butona kaç defa tıklandığını hesaplar


                dataGridView1.Rows[a].Cells[2].Value = salla.Next(1,100);  
            }


        }
    }
}
