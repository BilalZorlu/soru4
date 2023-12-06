using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        int sayac;
        private void Form1_Load(object sender, EventArgs e)
        {

            
            timer1.Start();
            

           


        }
        
        private void pb_top_Click(object sender, EventArgs e)
        {
            sayac++;
            lbl_skor.Text = sayac.ToString();
            if (sayac==10)
            {
                timer1.Stop();
                MessageBox.Show("Tebrikle Oyunu Kazandınız");
                Application.Exit();
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pb_top.Top = r.Next(0, 350);
            pb_top.Left = r.Next(0, 350);
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            sayac--;
            lbl_skor.Text = sayac.ToString();
            if (sayac == 10)
            {
                timer1.Stop();
                MessageBox.Show("Tebrikle Oyunu Kazandınız");
                Application.Exit();

            }
            

        }
    }
}
