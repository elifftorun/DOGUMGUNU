using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOĞUMGÜNÜ_GÜNSAYISI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dogumTarihi=new DateTime(2024,8,8);
            DateTime bugun = DateTime.Today;
            TimeSpan kalansure = dogumTarihi-bugun;
            int kalangun=kalansure.Days;
            label1.Text = kalangun.ToString();
        }
    }
}
