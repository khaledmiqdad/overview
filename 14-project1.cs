using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace overview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      




        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbsmall.Checked)
            {
                lblsizepizza.Text = "Small";
                return;
            }

            if (rbmedium.Checked)
            {
                lblsizepizza.Text = "Medium";
                return;
            }

            if (rblarge.Checked)
            {
                lblsizepizza.Text = "Large";
                return;
            }

         

            

          

           











          

                











            


          
        }

        void UpdateTotalPrice()
        {
            lbltotalprice.Text = "$" + CalculateTotalPrice().ToString();
        }

        float GetSelectedSizePrice()
        {
            if (rbsmall.Checked)
            {
                return Convert.ToSingle(rbsmall.Tag);
            }
            else if (rbmedium.Checked)
            {
                return Convert.ToSingle(rbmedium.Tag);
            }
            else
            {
                return Convert.ToSingle(rblarge.Tag);
            }
        }

        float CalculateToppingsPrice()
        {
            float ToppingsTotalPrice = 0;

            if (chextrachees.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chextrachees.Tag);
            }

            if (chmusrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chmusrooms.Tag);
            }

            if (chtomatoos.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chtomatoos.Tag);
            }

            if (chonion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chonion.Tag);
            }

            if (cholives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(cholives.Tag);
            }

            if (chgreenpepers.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chgreenpepers.Tag);
            }

            return ToppingsTotalPrice;

        }

        float GetSelectedCrustPrice()
        {
            if (rbthin.Checked)
                return Convert.ToSingle(rbthin.Tag);
            else
                return Convert.ToSingle(rbthink.Tag);
        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrustPrice();
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (rbthin.Checked)
            {
                lblcrust.Text = "Think Crust";
                return;
            }

            if (rbthink.Checked)
            {
                lblcrust.Text = "Thick Crust";
                return;
            }
        }

        void Updatewheretoeat()
        {
            if(rbeatin.Checked)
            {
                lblwheretoeat.Text = "Eat in";
                return;
            }

            if (rbout.Checked)
            {
                lblwheretoeat.Text = "Take Out";
                return;
            }

        }

        void UpdateToppings()
        {
            UpdateTotalPrice();
            string sToppings = "";

            if(chextrachees.Checked)
            {
                sToppings = "Extra Chees";
            }

            if (chmusrooms.Checked)
            {
                sToppings += " , Mushrooms";
            }

            if (chtomatoos.Checked)
            {
                sToppings += " , Tomatos";
            }

            if (chonion.Checked)
            {
                sToppings += " , Onion";
            }

            if (cholives.Checked)
            {
                sToppings += " , Olives";
            }

            if (chgreenpepers.Checked)
            {
                sToppings += " , Green pappers";
            }

            if(sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if(sToppings == "")
            
                sToppings = "No Toppings";
            lbltoppings.Text = sToppings;
            
        }

        void ResetForm()
        {
            gpsize.Enabled = true;
            gpToppings.Enabled = true;
            gpCrust.Enabled = true;
            gpwheretoeat.Enabled = true;

            rbmedium.Checked = true;

            chextrachees.Checked = false;
            chtomatoos.Checked = false;
            chonion.Checked = false;
            chgreenpepers.Checked = false;
            chmusrooms.Checked = false;
            cholives.Checked = false;

            rbthin.Checked = true;

            rbeatin.Checked = true;

            btnOrderPizza.Enabled = true;
        }

        void UpdateOrderSummary()
        {
            UpdateToppings();
            UpdateSize();
            UpdateCrust();
            Updatewheretoeat();
            UpdateTotalPrice();
        }






        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
            this.BackColor = Color.Purple;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Order" , "Confirm" , MessageBoxButtons.OKCancel
                , MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOrderPizza.Enabled = false;
                gpsize.Enabled = false;
                gpToppings.Enabled = false;
                gpCrust.Enabled = false;
                gpwheretoeat.Enabled = false;
            }
            

      
        }

        private void rbsmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbmedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rblarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbthin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbthink_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void chextrachees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chmusrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chtomatoos_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chonion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void cholives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chgreenpepers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void rbeatin_CheckedChanged(object sender, EventArgs e)
        {
            Updatewheretoeat();
        }

        private void rbout_CheckedChanged(object sender, EventArgs e)
        {
            Updatewheretoeat();
        }
    }
}
