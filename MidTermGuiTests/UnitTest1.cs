using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MidTermGUI;
using System.Windows;
using System.Collections.Generic;


namespace MidTermGuiTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CountDuplicatesTest_GiveDuplicatesAndSIngleItems_WillPrintThemGrouped()
        {
            Swords testSword = new Swords();
            testSword.Name = "testSword";
            testSword.Price = 5;
            Shields testShield = new Shields();
            testShield.Name = "testShield";
            testShield.Price = 10;
            Consumables testConsumable = new Consumables();
            testConsumable.Name = "testConsumable";
            testConsumable.Price = 15;
            Potions testPotion = new Potions();
            testPotion.Name = "testPotion";
            testPotion.Price = 20;
            Masks testMask = new Masks();
            testMask.Name = "testMask";
            testMask.Price = 25;

            List<Product> testCart = new List<Product>();

            for (int i = 0; i < 5; i++)
            {
                testCart.Add(testSword);
            }

            for (int i = 0; i < 132; i++)
            {
                testCart.Add(testShield);
            }

            testCart.Add(testConsumable);

            for (int i = 0; i < 45; i++)
            {
                testCart.Add(testPotion);
            }

            for (int i = 0; i < 98; i++)
            {
                testCart.Add(testMask);
            }

            string expected = "testSword x 5 - - - 25 Rupees\n\ntestShield x 132 - - - 1320 Rupees\n\ntestConsumable" + 
                              " x 1 - - - 15 Rupees\n\ntestPotion x 45 - - - 900 Rupees\n\ntestMask x 98 - - - 2450 Rupees\n\n";

            string itemizerTest = Itemizer.CountDuplicates(testCart);

            Assert.AreEqual(expected, itemizerTest);

        }


        [TestMethod]
        public void GetTotalTest_GiveRandomPricedProducts_WillPrintTheTotalPrice()
        {

            Swords testSword = new Swords();
            testSword.Name = "testSword";
            testSword.Price = 5;
            Shields testShield = new Shields();
            testShield.Name = "testShield";
            testShield.Price = 10;
            Consumables testConsumable = new Consumables();
            testConsumable.Name = "testConsumable";
            testConsumable.Price = 15;
            Potions testPotion = new Potions();
            testPotion.Name = "testPotion";
            testPotion.Price = 20;
            Masks testMask = new Masks();
            testMask.Name = "testMask";
            testMask.Price = 25;

            List<Product> testCart = new List<Product>();

            for (int i = 0; i < 5; i++)
            {
                testCart.Add(testSword);
            }

            for (int i = 0; i < 132; i++)
            {
                testCart.Add(testShield);
            }

            testCart.Add(testConsumable);

            for (int i = 0; i < 45; i++)
            {
                testCart.Add(testPotion);
            }

            for (int i = 0; i < 98; i++)
            {
                testCart.Add(testMask);
            }

            int actual = Itemizer.GetTotal(testCart);

            Assert.AreEqual(4710, actual);

        }












    }
}
