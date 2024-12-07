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
            SaladTb.Text = "0";
            BurgerTb.Text = "0";
            FriesTb.Text = "0";
            SandwichTb.Text = "0";
            ChickenTb.Text = "0";
            CheeseTb.Text = "0";
            TeaTb.Text = "0";
            ColaTb.Text = "0";
            WaterTb.Text = "0";
            CHocolateTb.Text = "0";
            PancakesTb.Text = "0";
            OrangeTb.Text = "0";
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
                FriesTb.Enabled = true;
            }
            if (FriesCb.Checked == false)
            {

                FriesTb.Enabled = false;
                FriesTb.Text = "0";
            }
        }

        private void BurgerCb_CheckedChanged(object sender, EventArgs e)
        {
            if (BurgerCb.Checked == true)
            {
                BurgerTb.Enabled = true;
            }
            if (BurgerCb.Checked == false)
            {

                BurgerTb.Enabled = false;
                BurgerTb.Text = "0";
            }
        }

        private void SaladCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SaladCb.Checked == true)
            {
                SaladTb.Enabled = true;
            }
            if (SaladCb.Checked == false)
            {

                SaladTb.Enabled = false;
                SaladTb.Text = "0";
            }
        }

        private void SandwichCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SandwichCb.Checked == true)
            {
                SandwichTb.Enabled = true;
            }
            if (SandwichCb.Checked == false)
            {

                SandwichTb.Enabled = false;
                SandwichTb.Text = "0";
            }
        }
       
        private void CheeseCb_CheckedChanged(object sender, EventArgs e)
        {
            if (CheeseCb.Checked == true)
            {
                CheeseTb.Enabled = true;
            }
            if (CheeseCb.Checked == false)
            {

                CheeseTb.Enabled = false;
                CheeseTb.Text = "0";
            }
        }
        private void TeaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (TeaCb.Checked == true)
            {
                TeaTb.Enabled = true;
            }
            if (TeaCb.Checked == false)
            {

                TeaTb.Enabled = false;
                TeaTb.Text = "0";
            }
        }
        private void ColaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ColaCb.Checked == true)
            {
                ColaTb.Enabled = true;
            }
            if (ColaCb.Checked == false)
            {

                ColaTb.Enabled = false;
                ColaTb.Text = "0";
            }
        }
        private void WaterCb_CheckedChanged(object sender, EventArgs e)
        {
            if (WaterCb.Checked == true)
            {
                WaterTb.Enabled = true;
            }
            if (WaterCb.Checked == false)
            {

                WaterTb.Enabled = false;
                WaterTb.Text = "0";
            }
        }
        private void CHocolateCb_CheckedChanged(object sender, EventArgs e)
        {
            if (CHocolateCb.Checked == true)
            {
                CHocolateTb.Enabled = true;
            }
            if (CHocolateCb.Checked == false)
            {

                CHocolateTb.Enabled = false;
                CHocolateTb.Text = "0";
            }
        }
        private void PancakesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (PancakesCb.Checked == true)
            {
                PancakesTb.Enabled = true;
            }
            if (SandwichCb.Checked == false)
            {

                PancakesTb.Enabled = false;
                PancakesTb.Text = "0";
            }
        }
        private void OrangeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (OrangeCb.Checked == true)
            {
                OrangeTb.Enabled = true;
            }
            if (OrangeCb.Checked == false)
            {

                OrangeTb.Enabled = false;
                OrangeTb.Text = "0";
            }
        }
        private void ChickenCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChickenCb.Checked == true)
            {
                ChickenTb.Enabled = true;
            }
            if (ChickenCb.Checked == false)
            {

                ChickenTb.Enabled = false;
                ChickenTb.Text = "0";
            }
        }


        private void closelbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //price
        double friestup = 50, burgerup = 80, saladup=180, sandwichup=75, chickenup = 170, colaup=44, cheeseup=47, orangetup=75, pancaketup=75, watertup=5, teatup=12, chocolatetup=40;

        private void FriesTb_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(FriesTb.Text, out _))
            {
                FriesTb.BackColor = Color.LightCoral;
            }
            else
            {
                FriesTb.BackColor = Color.White;
            }
        }
        private void BurgerTb_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(BurgerTb.Text, out _))
            {
                BurgerTb.BackColor = Color.LightCoral;
            }
            else
            {
                BurgerTb.BackColor = Color.White;
            }
        }
        private void SaladTb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SaladTb.Text) || double.TryParse(SaladTb.Text, out _))
            {
                SaladTb.BackColor = Color.White;
            }
            else
            {
                SaladTb.BackColor = Color.LightCoral;
            }
        }

        private void SandwichTb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SandwichTb.Text) || double.TryParse(SandwichTb.Text, out _))
            {
                SandwichTb.BackColor = Color.White;
            }
            else
            {
                SandwichTb.BackColor = Color.LightCoral;
            }
        }

        private void ChickenTb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ChickenTb.Text) || double.TryParse(ChickenTb.Text, out _))
            {
                ChickenTb.BackColor = Color.White;
            }
            else
            {
                ChickenTb.BackColor = Color.LightCoral;
            }
        }

        private void CheeseTb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CheeseTb.Text) || double.TryParse(CheeseTb.Text, out _))
            {
                CheeseTb.BackColor = Color.White;
            }
            else
            {
                CheeseTb.BackColor = Color.LightCoral;
            }
        }

        private void TeaTb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TeaTb.Text) || double.TryParse(TeaTb.Text, out _))
            {
                TeaTb.BackColor = Color.White;
            }
            else
            {
                TeaTb.BackColor = Color.LightCoral;
            }
        }

        private void ColaTb_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ColaTb.Text) || double.TryParse(ColaTb.Text, out _))
            {
                ColaTb.BackColor = Color.White;
            }
            else
            {
                ColaTb.BackColor = Color.LightCoral;
            }
        }

        private void WaterTb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(WaterTb.Text) || double.TryParse(WaterTb.Text, out _))
            {
                WaterTb.BackColor = Color.White;
            }
            else
            {
                WaterTb.BackColor = Color.LightCoral;
            }
        }

        private void CHocolateTb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CHocolateTb.Text) || double.TryParse(CHocolateTb.Text, out _))
            {
                CHocolateTb.BackColor = Color.White;
            }
            else
            {
                CHocolateTb.BackColor = Color.LightCoral;
            }
        }

        private void PancakesTb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PancakesTb.Text) || double.TryParse(PancakesTb.Text, out _))
            {
                PancakesTb.BackColor = Color.White;
            }
            else
            {
                PancakesTb.BackColor = Color.LightCoral;
            }
        }

        private void OrangeTb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(OrangeTb.Text) || double.TryParse(OrangeTb.Text, out _))
            {
                OrangeTb.BackColor = Color.White;
            }
            else
            {
                OrangeTb.BackColor = Color.LightCoral;
            }
        }

        private void taxlbl_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ReceiptTb.Text + "Subtotal "+Subtotallbl.Text+"Tax:"+taxlbl.Text+"Grand Total"+Grdtotallbl.Text,new Font("Century Gothic",12,FontStyle.Regular),Brushes.Blue,new Point(130));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }

        }


        //
        double frisetp,burgertp,saladtp,sandwichtp, chickentp, colatp, cheesetp, orangetp, pancaketp,watertp,teatp,chocolatetp;
        double Subtotale = 0,tax,grdtotal;
       
        private void addBtn_Click(object sender, EventArgs e)
        {

            frisetp = friestup * Convert.ToDouble(FriesTb.Text);
            burgertp = burgerup * Convert.ToDouble(BurgerTb.Text);
            saladtp = saladup * Convert.ToDouble(SaladTb.Text);
            sandwichtp = sandwichup * Convert.ToDouble(SandwichTb.Text);
            chickentp = chickenup * Convert.ToDouble(ChickenTb.Text);
            cheesetp = cheeseup * Convert.ToDouble(CheeseTb.Text);
            //drinks
            teatp = teatup * Convert.ToDouble(TeaTb.Text);
            colatp = colaup * Convert.ToDouble(ColaTb.Text);
            watertp = watertup * Convert.ToDouble(WaterTb.Text);
            chocolatetp = chocolatetup * Convert.ToDouble(CHocolateTb.Text);
            pancaketp = pancaketp * Convert.ToDouble(PancakesTb.Text);
            orangetp = orangetp * Convert.ToDouble(OrangeTb.Text);
            ReceiptTb.Clear();
            tax = 0;
            grdtotal = 0;
            Subtotale = 0;
            ReceiptTb.AppendText(Environment.NewLine);
            ReceiptTb.AppendText("\t\t\tCODESPACE RESTAURENT\t\t"+Datelbl.Text+Environment.NewLine);
            ReceiptTb.AppendText("\t\t\t*********************"+ Environment.NewLine);
            //
            if(FriesCb.Checked == true)
            {
                ReceiptTb.AppendText("\tFries:\t"+ frisetp + "EG"+Environment.NewLine);
                Subtotale = Subtotale + frisetp;
                Subtotallbl.Text = "EG" + Subtotale;
            }
            if (BurgerCb.Checked == true)
            {
                ReceiptTb.AppendText("\tBurger:\t" + burgertp + "EG" + Environment.NewLine);
                Subtotale = Subtotale + burgertp;
                Subtotallbl.Text = "EG" + Subtotale;
            }
            if (SaladCb.Checked == true)
            {
                ReceiptTb.AppendText("\tSalad:\t" + saladtp + "EG" + Environment.NewLine);
                Subtotale = Subtotale + saladtp;
                Subtotallbl.Text = "EG" + Subtotale;
            }
            if (SandwichCb.Checked == true)
            {
                ReceiptTb.AppendText("\tSandwich:\t" + sandwichtp + "EG" + Environment.NewLine);
                Subtotale = Subtotale + sandwichtp;
                Subtotallbl.Text = "EG" + Subtotale;
            }
            if (ColaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tCola:\t" + colatp + "EG" + Environment.NewLine);
                Subtotale = Subtotale + colatp;
                Subtotallbl.Text = "EG" + Subtotale;
            }
            if (CheeseCb.Checked == true)
            {
                ReceiptTb.AppendText("\tCheese:\t" + cheesetp + "EG" + Environment.NewLine);
                Subtotale = Subtotale + cheesetp;
                Subtotallbl.Text = "EG" + Subtotale;
            }
            if (OrangeCb.Checked == true)
            {
                ReceiptTb.AppendText("\tOrange:\t" + orangetp + "EG" + Environment.NewLine);
                Subtotale = Subtotale + orangetp;
                Subtotallbl.Text = "EG" + Subtotale;
            }
            if (PancakesCb.Checked == true)
            {
                ReceiptTb.AppendText("\tPancakes:\t" + pancaketp + "EG" + Environment.NewLine);
                Subtotale = Subtotale + pancaketp;
                Subtotallbl.Text = "EG" + Subtotale;
            }
            if (WaterCb.Checked == true)
            {
                ReceiptTb.AppendText("\tWater:\t" + watertp + "EG" + Environment.NewLine);
                Subtotale = Subtotale + watertp;
                Subtotallbl.Text = "EG" + Subtotale;
            }
            if (TeaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tTea:\t" + teatp + "EG" + Environment.NewLine);
                Subtotale = Subtotale + teatp;
                Subtotallbl.Text = "EG" + Subtotale;
            }
            if (CHocolateCb.Checked == true)
            {
                ReceiptTb.AppendText("\tCHocolate:\t" + chocolatetp + "EG" + Environment.NewLine);
                Subtotale = Subtotale + chocolatetp;
                Subtotallbl.Text = "EG" + Subtotale;
            }
            if (ChickenCb.Checked == true)
            {
                ReceiptTb.AppendText("\tChicken:\t" + chickentp + "EG" + Environment.NewLine);
                Subtotale = Subtotale + chickentp;
                Subtotallbl.Text = "EG" + Subtotale;
            }
            tax = Subtotale * 0.16;
            grdtotal = tax + Subtotale;
            taxlbl.Text = "EG" + tax;
            Grdtotallbl.Text = "EG" + grdtotal;
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            FriesCb.Checked = false;
            ChickenCb.Checked = false;
            SaladCb.Checked = false;
            SandwichCb.Checked = false;
            CheeseCb.Checked = false;
            BurgerCb.Checked = false;
            TeaCb.Checked = false;
            ColaCb.Checked = false;
            WaterCb.Checked = false;
            CHocolateCb.Checked = false;
            PancakesCb.Checked = false;
            OrangeCb.Checked = false;
            taxlbl.Text = "EG/...";
            Grdtotallbl.Text = "EG/...";
            Subtotallbl.Text = "EG/...";
            ReceiptTb.Clear();
        }
        private void ReceiptTb_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SubTotal_label_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

    }
}
