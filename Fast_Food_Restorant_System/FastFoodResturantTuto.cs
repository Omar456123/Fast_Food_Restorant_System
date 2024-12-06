using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_Food_Restorant_System
{
    public partial class FastFoodResturantTuto : Form
    {
        public FastFoodResturantTuto()
        {
            InitializeComponent();
        }

        private void FastFoodResturantTuto_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void FriseCb_CheckedChanged(object sender, EventArgs e)
        {
            if (FriesCb.Checked == true)
            {
                FriesCb.Enabled = true;
            }
            if (FriesCb.Checked == false)
            {

                FriesCb.Enabled = false;
                FriesCb.Text = "0";
            }
        }

        private void BurgerCb_CheckedChanged(object sender, EventArgs e)
        {
            if (BurgerCb.Checked == true)
            {
                BurgerCb.Enabled = true;
            }
            if (BurgerCb.Checked == false)
            {

                BurgerCb.Enabled = false;
                BurgerCb.Text = "0";
            }
        }

        private void SaladCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SaladCb.Checked == true)
            {
                SaladCb.Enabled = true;
            }
            if (SaladCb.Checked == false)
            {

                SaladCb.Enabled = false;
                SaladCb.Text = "0";
            }
        }

        private void SandwichCb_Checked_Changed(object sender, EventArgs e)
        {
            if (SandwichCb.Checked == true)
            {
                SandwichCb.Enabled = true;
            }
            if (SandwichCb.Checked == false)
            {

                SandwichCb.Enabled = false;
                SandwichCb.Text = "0";
            }
        }

        private void closelbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
