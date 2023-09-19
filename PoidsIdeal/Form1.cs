using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoidsIdeal
{
    public partial class Form1 : Form
    {
        public void videPoids()
        {
            txtPoidsIdeal.Text = "";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpNaiss.MaxDate = DateTime.Today;
        }

        private void cmdCalcul_Click(object sender, EventArgs e)
        {
            try
            {
                int taille = int.Parse(txtTaille.Text);
                int age = ((dtpNaiss.Value.Date - DateTime.Today).Days)/365;
                if (grbGracile.Checked)
                {
                    txtPoidsIdeal.Text = (((taille - 100 + (age / 10)) * 0.9)*0.9).ToString();
                }
                if (grbNormale.Checked)
                {
                    txtPoidsIdeal.Text = ((taille - 100 + (age / 10)) * 0.9).ToString();
                }
                if (grbLarge.Checked)
                {
                    txtPoidsIdeal.Text = (((taille - 100 + (age / 10)) * 0.9)*1.1).ToString();
                }
            }
            catch(Exception ex)
            {
                txtTaille.Text = "";
            }
        }
    }
}
