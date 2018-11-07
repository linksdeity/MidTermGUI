using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MidTermGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void aSwordsButton_Click(object sender, EventArgs e)
        {
            aItemDescriptionLabel.Text = "";

            aCategoryListBox.Items.Clear();

            aCategoryNameLabel.Text = "Swords";

            string path = "assets/swords";

            //list to store all of the items we instantiate
            List<Product> itemList = new List<Product>();


            //loops through each file, instantiates an object with the values in the text file
            foreach (var file in Directory.EnumerateFiles(path, "*.txt"))
            {


                StreamReader fileReader = new StreamReader(file);

                List<string> objectStorer = new List<string>();

                string lineSaver;

                while ((lineSaver = fileReader.ReadLine()) != null)
                {
                    objectStorer.Add(lineSaver);
                }

                Swords newSword = new Swords();
                newSword.Name = objectStorer[0];
                newSword.Category = objectStorer[1];
                newSword.Description = objectStorer[2];
                newSword.Price = Convert.ToInt32(objectStorer[3]);
                newSword.Damage = objectStorer[4];

                itemList.Add(newSword);

                aCategoryListBox.Items.Add(newSword);
            }

        }

        private void aShieldsButton_Click(object sender, EventArgs e)
        {
            aItemDescriptionLabel.Text = "";

            aCategoryNameLabel.Text = "Shields";

            aCategoryListBox.Items.Clear();

            string path = "assets/shields";

            //list to store all of the items we instantiate
            List<Product> itemList = new List<Product>();


            //loops through each file, instantiates an object with the values in the text file
            foreach (var file in Directory.EnumerateFiles(path, "*.txt"))
            {

                StreamReader fileReader = new StreamReader(file);

                List<string> objectStorer = new List<string>();

                string lineSaver;

                while ((lineSaver = fileReader.ReadLine()) != null)
                {
                    objectStorer.Add(lineSaver);
                }

                Shields newShield = new Shields();
                newShield.Name = objectStorer[0];
                newShield.Category = objectStorer[1];
                newShield.Description = objectStorer[2];
                newShield.Price = Convert.ToInt32(objectStorer[3]);
                newShield.Effect = objectStorer[4];

                itemList.Add(newShield);

                aCategoryListBox.Items.Add(newShield);
            }
        }

        private void aPotionsButton_Click(object sender, EventArgs e)
        {
            aItemDescriptionLabel.Text = "";

            aCategoryNameLabel.Text = "Potions";

            aCategoryListBox.Items.Clear();

            string path = "assets/potions";

            //list to store all of the items we instantiate
            List<Product> itemList = new List<Product>();


            //loops through each file, instantiates an object with the values in the text file
            foreach (var file in Directory.EnumerateFiles(path, "*.txt"))
            {

                StreamReader fileReader = new StreamReader(file);

                List<string> objectStorer = new List<string>();

                string lineSaver;

                while ((lineSaver = fileReader.ReadLine()) != null)
                {
                    objectStorer.Add(lineSaver);
                }

                Potions newPotion = new Potions();
                newPotion.Name = objectStorer[0];
                newPotion.Category = objectStorer[1];
                newPotion.Description = objectStorer[2];
                newPotion.Price = Convert.ToInt32(objectStorer[3]);
                newPotion.Ingrediants = objectStorer[4];
                newPotion.Effects = objectStorer[5];


                itemList.Add(newPotion);

                aCategoryListBox.Items.Add(newPotion);
            }
        }

        private void aMasksButton_Click(object sender, EventArgs e)
        {
            aItemDescriptionLabel.Text = "";

            aCategoryNameLabel.Text = "Masks";

            aCategoryListBox.Items.Clear();

            string path = "assets/masks";

            //list to store all of the items we instantiate
            List<Product> itemList = new List<Product>();


            //loops through each file, instantiates an object with the values in the text file
            foreach (var file in Directory.EnumerateFiles(path, "*.txt"))
            {

                StreamReader fileReader = new StreamReader(file);

                List<string> objectStorer = new List<string>();

                string lineSaver;

                while ((lineSaver = fileReader.ReadLine()) != null)
                {
                    objectStorer.Add(lineSaver);
                }

                Masks newMask = new Masks();
                newMask.Name = objectStorer[0];
                newMask.Category = objectStorer[1];
                newMask.Description = objectStorer[2];
                newMask.Price = Convert.ToInt32(objectStorer[3]);
                newMask.Effects = objectStorer[4];
                newMask.Rumors = objectStorer[5];

                itemList.Add(newMask);

                aCategoryListBox.Items.Add(newMask);
            }
        }

        private void aConsumablesButton_Click(object sender, EventArgs e)
        {
            aItemDescriptionLabel.Text = "";

            aCategoryNameLabel.Text = "Consumables";

            aCategoryListBox.Items.Clear();

            string path = "assets/consumables";

            //list to store all of the items we instantiate
            List<Product> itemList = new List<Product>();


            //loops through each file, instantiates an object with the values in the text file
            foreach (var file in Directory.EnumerateFiles(path, "*.txt"))
            {

                StreamReader fileReader = new StreamReader(file);

                List<string> objectStorer = new List<string>();

                string lineSaver;

                while ((lineSaver = fileReader.ReadLine()) != null)
                {
                    objectStorer.Add(lineSaver);
                }

                Consumables newConsumable = new Consumables();
                newConsumable.Name = objectStorer[0];
                newConsumable.Category = objectStorer[1];
                newConsumable.Description = objectStorer[2];
                newConsumable.Price = Convert.ToInt32(objectStorer[3]);
                newConsumable.NeededContainer = objectStorer[4];
                newConsumable.Additional = objectStorer[5];

                itemList.Add(newConsumable);

                aCategoryListBox.Items.Add(newConsumable);
            }
        }


        private void aAddToCartButton_Click(object sender, EventArgs e)
        {

            if (aCategoryListBox.SelectedIndex != -1)
            {
                aShoppingCartList.Items.Add(aCategoryListBox.SelectedItem);


                var selectedProduct = (Product)aCategoryListBox.SelectedItem;

                aTotalCostLabel.Text = "" + (Convert.ToInt32(aTotalCostLabel.Text) + selectedProduct.Price);

                aTaxCostLabel.Text = "" + (int)(Convert.ToInt32(aTotalCostLabel.Text) * 0.06);

                aGrandTotalLabel.Text = "" + (Convert.ToInt32(aTaxCostLabel.Text) + Convert.ToInt32(aTotalCostLabel.Text));
            }
        }

        private void aClearCartButton_Click(object sender, EventArgs e)
        {
            aShoppingCartList.Items.Clear();

            aTotalCostLabel.Text = "0";

            aTaxCostLabel.Text = "0";

            aGrandTotalLabel.Text = "0";

            aItemDescriptionLabel.Text = "";

            aCategoryNameLabel.Text = "";

            aCategoryListBox.Items.Clear();
        }

        private void aCategoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //need to prevent error where no item is sleceted, but an item IS unselected / clear space clicked on with no active selection

            if(aCategoryNameLabel.Text == "Swords")
            {
                var newItem = aCategoryListBox.SelectedItem as Swords;

                aItemDescriptionLabel.Text = newItem.Description + "\n\nDamage: " + newItem.Damage + ("\n\nPRICE: " + newItem.Price + " Rupees");


            }
            else if (aCategoryNameLabel.Text == "Shields")
            {
                var newItem = aCategoryListBox.SelectedItem as Shields;

                aItemDescriptionLabel.Text = newItem.Description + "\n\nEffect: " + newItem.Effect + ("\n\nPRICE: " + newItem.Price + " Rupees");

            }
            else if (aCategoryNameLabel.Text == "Potions")
            {
                var newItem = aCategoryListBox.SelectedItem as Potions;

                aItemDescriptionLabel.Text = newItem.Description + "\n\nIngrediants: " + newItem.Ingrediants + "\n\nEffect: " + newItem.Effects + ("\n\nPRICE: " + newItem.Price + " Rupees");

            }
            else if (aCategoryNameLabel.Text == "Masks")
            {
                var newItem = aCategoryListBox.SelectedItem as Masks;

                aItemDescriptionLabel.Text = newItem.Description + "\n\nEffect: " + newItem.Effects + "\n\nRumors: " + newItem.Rumors + ("\n\nPRICE: " + newItem.Price + " Rupees");

            }
            else if (aCategoryNameLabel.Text == "Consumables")
            {
                var newItem = aCategoryListBox.SelectedItem as Consumables;

                aItemDescriptionLabel.Text = newItem.Description + "\n\nOther Uses : " + newItem.Additional + "\n\nNeeds Container: " + newItem.NeededContainer + ("\n\nPRICE: " + newItem.Price + " Rupees");

            }


        }

        private void aCheckoutButton_Click(object sender, EventArgs e)
        {
            PaymentScreen payment = new PaymentScreen();
            payment.Tax = Convert.ToInt32(aTaxCostLabel.Text);
            payment.Total = Convert.ToInt32(aTotalCostLabel.Text);

            for (int i = 0; i < aShoppingCartList.Items.Count; i++)
            {
                payment.ShoppingCart.Add( (Product) aShoppingCartList.Items[i]);
            }

            payment.Show();
        }
    }
}
