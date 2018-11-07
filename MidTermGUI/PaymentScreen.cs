using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void aPayWithRupeesButton_Click(object sender, EventArgs e)
        {

        }

        private void aPayWithCardButton_Click(object sender, EventArgs e)
        {

        }
    }
}
