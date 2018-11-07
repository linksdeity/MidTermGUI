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

        }

        private void aPayWithRupeesRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void aPayWithCardRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
