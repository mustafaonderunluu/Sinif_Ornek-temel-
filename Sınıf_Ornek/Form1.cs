using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınıf_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba rb=new Araba();
            rb.renk = "Kırmızı";
            rb.hız = 200;
            rb.motor = 1245.56;
            rb.fiyat = 50000;
            rb.durum = 's';

            label1.Text= rb.renk;
            label2.Text=rb.hız.ToString();
            label4.Text=rb.motor.ToString();
            label5.Text=rb.fiyat.ToString();
            label6.Text=rb.durum.ToString();
          
        }
    }
}
