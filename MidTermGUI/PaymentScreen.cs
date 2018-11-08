using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MidTermGUI
{
    public partial class PaymentScreen : Form
    {
        public int Total { get; set; }
        public int Tax { get; set; }

        public List<Product> ShoppingCart = new List<Product>();


        public PaymentScreen()
        {
            InitializeComponent();

        }

        private void PaymentScreen_Load(object sender, EventArgs e)
        {
            aCheckoutTotalLabel.Text = "" + Total;
            aCheckOutTaxLabel.Text = "" + Tax;
            aCheckOutGrandTotalLabel.Text = "" + (Tax + Total);
        }

        private void aPayWithCheckRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (aPayWithCheckRadioButton.Checked)
            {
                aCheckPanel.Enabled = true;
            }
            else
            {
                aCheckPanel.Enabled = false;
            }
        }

        private void aPayWithRupeesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(aPayWithRupeesRadioButton.Checked)
            {
                aRupeePanel.Enabled = true;
            }
            else
            {
                aRupeePanel.Enabled = false;
            }
        }

        private void aPayWithCardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (aPayWithCardRadioButton.Checked)
            {
                aCardPanel.Enabled = true;
            }
            else
            {
                aCardPanel.Enabled = false;
            }
        }

        private void aPayWithCheckButton_Click(object sender, EventArgs e)
        {
            if(aCheckNumberTextBox.Text.Length == 9 && aRoutingNumberTextBox.Text.Length == 9)
            {
                Receipt.PrintReceipt(Convert.ToInt32(aCheckOutGrandTotalLabel.Text), ShoppingCart, aCheckNumberTextBox.Text);
                this.Close();
            }
            else
            {
                var result = MessageBox.Show("Please check your routing / account numbers!", "Incorrect Routing Or Check Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void aPayWithRupeesButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(aRupeePayTextBox.Text) >= Convert.ToInt32(aCheckOutGrandTotalLabel.Text))
                {
                    Receipt.PrintReceipt(Convert.ToInt32(aCheckOutGrandTotalLabel.Text), ShoppingCart, Convert.ToInt32(aRupeePayTextBox.Text), Convert.ToInt32(aChangeLabel.Text));
                    this.Close();
                }
                else
                {
                    var result = MessageBox.Show("This isn't a charity!!", "YOU NEED MORE RUPEES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                var result = MessageBox.Show("This isn't a charity!!", "NO RUPEES??", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        
            
            
            }

        private void aPayWithCardButton_Click(object sender, EventArgs e)
        {
            DateTime tempDate;
            DateTime.TryParse(aExpirationDateCheckBox.Text, out tempDate);

            if (Regex.IsMatch(aCreditCarNumberTextBox.Text, "[0-9]{4}-[0-9]{4}-[0-9]{4}-[0-9]{4}"))
            {
                if(tempDate >= DateTime.Now)
                {
                    if(aSecurityCodeTextBox.Text.Length == 3 || aSecurityCodeTextBox.Text.Length == 4)
                    {

                        Receipt.PrintReceipt(Convert.ToInt32(aCheckOutGrandTotalLabel.Text), ShoppingCart, aCreditCarNumberTextBox.Text, aExpirationDateCheckBox.Text);
                        this.Close();

                    }
                    else
                    {
                        var result = MessageBox.Show("Please check your card information!!", "Incorrect CVV / Security Code!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    var result = MessageBox.Show("Please check your card information!!", "Incorrect Expiration Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                var result = MessageBox.Show("Please check your card information!!", "Incorrect Card Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void getChange(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(aCheckOutGrandTotalLabel.Text) - Convert.ToInt32(aRupeePayTextBox.Text) < 0)
                {

                    aChangeLabel.Text = "" + (Convert.ToInt32(aRupeePayTextBox.Text) - Convert.ToInt32(aCheckOutGrandTotalLabel.Text));

                }
                else
                {
                    aChangeLabel.Text = "0";
                }
            }
            catch
            {
                aChangeLabel.Text = "0";
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EasterEgg easterEgg = new EasterEgg();

            easterEgg.Show();
        }
    }
}
