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

            ResetMainMenu();

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

            aLineTotalLabel.Text = "";

        }

        private void aShieldsButton_Click(object sender, EventArgs e)
        {

            ResetMainMenu();

            aCategoryNameLabel.Text = "Shields";


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

            aLineTotalLabel.Text = "";
        }

        private void aPotionsButton_Click(object sender, EventArgs e)
        {

            ResetMainMenu();

            aCategoryNameLabel.Text = "Potions";


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

            aLineTotalLabel.Text = "";
        }

        private void aMasksButton_Click(object sender, EventArgs e)
        {

            ResetMainMenu();

            aCategoryNameLabel.Text = "Masks";

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
            aLineTotalLabel.Text = "";
        }

        private void aConsumablesButton_Click(object sender, EventArgs e)
        {

            ResetMainMenu();

            aCategoryNameLabel.Text = "Consumables";

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
            aLineTotalLabel.Text = "";
        }


        private void aAddToCartButton_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(aGrandTotalLabel.Text) > 99999999)
            {
                aClearCartButton.PerformClick();

                var result = MessageBox.Show( "We don't have that much in stock of anything!\n\nCLEARING CART!", "Are you crazy?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            for (int i = 1; i <= aItemNumeric.Value; i++)
            {



                if (aCategoryListBox.SelectedIndex != -1)
                {
                    aShoppingCartList.Items.Add(aCategoryListBox.SelectedItem);


                    var selectedProduct = (Product)aCategoryListBox.SelectedItem;

                    aTotalCostLabel.Text = "" + (Convert.ToInt32(aTotalCostLabel.Text) + selectedProduct.Price);

                    aTaxCostLabel.Text = "" + (int)(Convert.ToInt32(aTotalCostLabel.Text) * 0.06);

                    aGrandTotalLabel.Text = "" + (Convert.ToInt32(aTaxCostLabel.Text) + Convert.ToInt32(aTotalCostLabel.Text));

                    aLineTotalLabel.Text = "" + selectedProduct.Price;
                }
            }

            aItemNumeric.Value = 1;

        }

        private void aClearCartButton_Click(object sender, EventArgs e)
        {
            aShoppingCartList.Items.Clear();

            aLineTotalLabel.Text = "";

            aItemPictureBox.Image = MidTermGUI.Properties.Resources.treasurechest;

            aTotalCostLabel.Text = "0";

            aTaxCostLabel.Text = "0";

            aGrandTotalLabel.Text = "0";

            aItemDescriptionLabel.Text = "";

            aCategoryNameLabel.Text = "";

            aCategoryListBox.Items.Clear();

            aItemNumeric.Value = 1;
        }

        private void aCategoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (aCategoryNameLabel.Text == "Swords")
                {

                    var newItem = aCategoryListBox.SelectedItem as Swords;

                    aItemDescriptionLabel.Text = newItem.Description + "\n\nDamage: " + newItem.Damage + ("\n\nPRICE: " + newItem.Price + " Rupees");

                    aLineTotalLabel.Text = "" + (newItem.Price * aItemNumeric.Value);

                    switch (newItem.Name)
                    {
                        case "Biggoron's Sword":
                            aItemPictureBox.Image = MidTermGUI.Properties.Resources.biggoronssword;
                            break;
                        case "Butterfly Net":
                            aItemPictureBox.Image = MidTermGUI.Properties.Resources.butterflynet;
                            break;
                        case "Kokiri Sword":
                            aItemPictureBox.Image = MidTermGUI.Properties.Resources.kokirisword;
                            break;
                        case "Master Sword":
                            aItemPictureBox.Image = MidTermGUI.Properties.Resources.mastersword;
                            break;
                    }
                }

                else if (aCategoryNameLabel.Text == "Shields")
                {
                    var newItem = aCategoryListBox.SelectedItem as Shields;

                    aItemDescriptionLabel.Text = newItem.Description + "\n\nEffect: " + newItem.Effect + ("\n\nPRICE: " + newItem.Price + " Rupees");

                    aLineTotalLabel.Text = "" + (newItem.Price * aItemNumeric.Value);

                    switch (newItem.Name)
                    {
                        case "Hylian Shield":
                            aItemPictureBox.Image = MidTermGUI.Properties.Resources.hylianshield;
                            break;
                        case "Lynel Shield":
                            aItemPictureBox.Image = MidTermGUI.Properties.Resources.lynelshield;
                            break;
                        case "Mirror Shield":
                            aItemPictureBox.Image = MidTermGUI.Properties.Resources.mirrorshield;
                            break;
                        case "Wooden Shield":
                            aItemPictureBox.Image = MidTermGUI.Properties.Resources.woodshield;
                            break;
                    }

                }
                else if (aCategoryNameLabel.Text == "Potions")
                {
                    var newItem = aCategoryListBox.SelectedItem as Potions;

                    aItemDescriptionLabel.Text = newItem.Description + "\n\nIngrediants: " + newItem.Ingrediants + "\n\nEffect: " + newItem.Effects + ("\n\nPRICE: " + newItem.Price + " Rupees");

                    aLineTotalLabel.Text = "" + (newItem.Price * aItemNumeric.Value);

                    switch (newItem.Name)
                    {
                        case "Blue Potion":
                            aItemPictureBox.Image = MidTermGUI.Properties.Resources.bluepotion;
                            break;
                        case "Green Potion":
                            aItemPictureBox.Image = MidTermGUI.Properties.Resources.greenpotion;
                            break;
                        case "Red Potion":
                            aItemPictureBox.Image = MidTermGUI.Properties.Resources.redpotion;
                            break;
                    }

                }
                else if (aCategoryNameLabel.Text == "Masks")
                {
                    var newItem = aCategoryListBox.SelectedItem as Masks;

                    aItemDescriptionLabel.Text = newItem.Description + "\n\nEffect: " + newItem.Effects + "\n\nRumors: " + newItem.Rumors + ("\n\nPRICE: " + newItem.Price + " Rupees");

                    aLineTotalLabel.Text = "" + (newItem.Price * aItemNumeric.Value);

                    switch (newItem.Name)
                    {
                        case "Bunny Hood":
                            aItemPictureBox.Image = MidTermGUI.Properties.Resources.bunnyhood;
                            break;
                        case "Keaton Mask":
                            aItemPictureBox.Image = MidTermGUI.Properties.Resources.keatonmask;
                            break;
                        case "Majora's Mask":
                            aItemPictureBox.Image = MidTermGUI.Properties.Resources.majorasmask;
                            break;
                        case "Mask of Truth":
                            aItemPictureBox.Image = MidTermGUI.Properties.Resources.maskoftruth;
                            break;
                    }

                }
                else if (aCategoryNameLabel.Text == "Consumables")
                {
                    var newItem = aCategoryListBox.SelectedItem as Consumables;

                    aItemDescriptionLabel.Text = newItem.Description + "\n\nOther Uses : " + newItem.Additional + "\n\nNeeds Container: " + newItem.NeededContainer + ("\n\nPRICE: " + newItem.Price + " Rupees");

                    aLineTotalLabel.Text = "" + (newItem.Price * aItemNumeric.Value);

                    switch (newItem.Name)
                    {
                        case "Arrows (x5)":
                            aItemPictureBox.Image = MidTermGUI.Properties.Resources.arrows;
                            break;
                        case "Bombs (x5)":
                            aItemPictureBox.Image = MidTermGUI.Properties.Resources.bombs;
                            break;
                        case "Deku Seeds (x10)":
                            aItemPictureBox.Image = MidTermGUI.Properties.Resources.dekunuts;
                            break;
                        case "Fairy":
                            aItemPictureBox.Image = MidTermGUI.Properties.Resources.fairy;
                            break;
                        case "Hearts (x3)":
                            aItemPictureBox.Image = MidTermGUI.Properties.Resources.hearts;
                            break;
                    }

                }
            }
            catch
            {
                aItemPictureBox.Image = MidTermGUI.Properties.Resources.treasurechest;
            }

        }

        private void aCheckoutButton_Click(object sender, EventArgs e)
        {

            if (aShoppingCartList.Items.Count == 0)
            {
                var result = MessageBox.Show( "No items in your cart!", "Empty Cart!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                PaymentScreen payment = new PaymentScreen();
                payment.Tax = Convert.ToInt32(aTaxCostLabel.Text);
                payment.Total = Convert.ToInt32(aTotalCostLabel.Text);

                for (int i = 0; i < aShoppingCartList.Items.Count; i++)
                {
                    payment.ShoppingCart.Add((Product)aShoppingCartList.Items[i]);
                }

                payment.Show();

                aClearCartButton.PerformClick();

                aItemPictureBox.Image = null;

                aDeleteButton.Enabled = false;

            }
        }

        private void aMusicButton_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"assets\Audio\malomarttheme.wav");
            player.PlayLooping();
            aTitleTimer.Enabled = true;

            aSwordsButton.BackColor = Color.Magenta;
            aShieldsButton.BackColor = Color.LimeGreen;
            aMasksButton.BackColor = Color.Red;
            aPotionsButton.BackColor = Color.Yellow;
            aConsumablesButton.BackColor = Color.Turquoise;

            this.BackColor = Color.Purple;

            aCategoryListBox.BackColor = Color.PowderBlue;
            aShoppingCartList.BackColor = Color.PeachPuff;
            aAddToCartButton.BackColor = Color.DarkViolet;
            aCheckoutButton.BackColor = Color.DarkViolet;

            aDeleteButton.BackColor = Color.LightPink;
            aClearCartButton.BackColor = Color.Red;

            aItemNumeric.BackColor = Color.YellowGreen;

        }

        private void aItemPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void aItemNumeric_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedProduct = aCategoryListBox.SelectedItem as Product;

                aLineTotalLabel.Text = "" + (selectedProduct.Price * aItemNumeric.Value);
            }
            catch
            {
                aLineTotalLabel.Text = "";
            }


        }

        private void aDeleteButton_Click(object sender, EventArgs e)
        {
            aShoppingCartList.Items.Remove(aShoppingCartList.SelectedItem);
        }

        private void aShoppingCartList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aShoppingCartList.SelectedItem != null)
            {
                aDeleteButton.Enabled = true;
            }
            else
            {
                aDeleteButton.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random myRand = new Random();

            int red = myRand.Next(1, 256);
            int green = myRand.Next(1, 256);
            int blue = myRand.Next(1, 256);

            aTitleLabel.ForeColor = Color.FromArgb(red, green, blue);

            aCheckoutButton.ForeColor = Color.FromArgb(red, green, blue);

            aAddToCartButton.ForeColor = Color.FromArgb(red,green,blue);

        }


        public void ResetMainMenu()
        {
            aItemDescriptionLabel.Text = "";

            aItemNumeric.Value = 1;

            aItemPictureBox.Image = MidTermGUI.Properties.Resources.treasurechest;

            aCategoryListBox.Items.Clear();
        }

    }
}
