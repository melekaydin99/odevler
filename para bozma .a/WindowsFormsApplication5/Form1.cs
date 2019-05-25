using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int para;
       int sayac2;
        int [] paraustu= new int[] {1,5,10,20,50,100,200} ;

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();       //boş satır açar listelemek için 

            para = Convert.ToInt32(textBox1.Text);
            int sayac=0;
            for(int i=6 ; i>=0 ; i--)
            {
                sayac=0;
                    while (para >= paraustu[i])
                { 
                    para = para - paraustu[i];
                    sayac++;
                    dataGridView1.Rows[sayac2].Cells[i].Value = sayac;
                }
          }
            sayac2++;
            
            /* int sayac = 0;

            while (para >= 200)
            { 
                para = para - 200;
                sayac++;
                dataGridView1.Rows[0].Cells[6].Value = sayac;
            }
            sayac = 0;

            while (para >= 100)
            {
                para = para - 100;
                sayac++;
                dataGridView1.Rows[0].Cells[5].Value = sayac;
            }

            sayac = 0;

            while (para >= 50)
            {
                para = para - 50;
                sayac++;
                dataGridView1.Rows[0].Cells[4].Value = sayac;
            }

            sayac = 0;

            while (para >= 20)
            {
                para = para -20;
                sayac++;
                dataGridView1.Rows[0].Cells[3].Value = sayac;
            }

            sayac = 0;

            while (para >= 10)
            {
                para = para - 10;
                sayac++;
                dataGridView1.Rows[0].Cells[2].Value = sayac;
            }

            sayac = 0;

            while (para >= 5)
            {
                para = para - 5;
                sayac++;
                dataGridView1.Rows[0].Cells[1].Value = sayac;
            }

            sayac = 0;

            while (para >= 1)
            {
                para = para - 1;
                sayac++;
                dataGridView1.Rows[0].Cells[0].Value = sayac;
            }

*/
        }
    }
}
