using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGT_h2_24eyl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSonuc.Text = "Merhaba";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string ad;
            ad = txtboxAd.Text;
            lblSonuc.Text = "Merhaba " + ad;
        }
    }
}
