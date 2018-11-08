using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTermGUI
{
    public static class Receipt
    {
        public static void PrintReceipt(int grandTotal, List<Product> ShoppingCart, int amount, int change)
        {
            int total = Itemizer.GetTotal(ShoppingCart);

            string receipt = "\nYou have purchased the following items...\n\n" + Itemizer.CountDuplicates(ShoppingCart) +
                             "\n\nYou payed with Rupees in the amount of: " + amount + "\nTotal before tax: " + total +
                             "\nGRAND TOTAL: " + grandTotal + "\n\nYou are receiving " +  change + " Rupees in change!";

            var result = MessageBox.Show(receipt, "Thank you for shopping with MALO MART!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }


        public static void PrintReceipt(int grandTotal, List<Product> ShoppingCart, string cardNumber, string expiration)
        {
            int total = Itemizer.GetTotal(ShoppingCart);

            string lastFour = "" + cardNumber[15] + cardNumber[16] + cardNumber[17] + cardNumber[18];

            string receipt = "\nYou have purchased the following items...\n\n" + Itemizer.CountDuplicates(ShoppingCart) +
                             "\n\nYou payed with a card ending in: " + lastFour + "\nTotal before tax: " + total +
                             "\nGRAND TOTAL: " + grandTotal;

            var result = MessageBox.Show(receipt, "Thank you for shopping with MALO MART!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        public static void PrintReceipt(int grandTotal, List<Product> ShoppingCart, string checkNumber)
        {
            int total = Itemizer.GetTotal(ShoppingCart);

            string receipt = "\nYou have purchased the following items...\n\n" + Itemizer.CountDuplicates(ShoppingCart) +
                             "\n\nYou payed with check number: " + checkNumber + "\nTotal before tax: " + total +
                             "\nGRAND TOTAL: " + grandTotal;

            var result = MessageBox.Show(receipt, "Thank you for shopping with MALO MART!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
