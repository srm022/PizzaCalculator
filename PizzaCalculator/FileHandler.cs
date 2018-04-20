using System;
using System.IO;

namespace PizzaCalculator
{
    class FileHandler
    {
        string[] menuItems;
        decimal[] menuPrices;

        string path = "menu.txt";

        public void ReadMenu()
        {
            string[] lines = File.ReadAllLines(path);          // czyta linie
            menuItems = new string[lines.Length];
            menuPrices = new decimal[lines.Length];
            
            for (int i = 0; i < lines.Length; i++)
            {
                string[] twoLines = lines[i].Split(new char[0], StringSplitOptions.RemoveEmptyEntries);         // oddziela pierwsza czesc od drugiej
                string item = twoLines[0];                                              // przypisuje pierwsza czesc do item...
                decimal price = Decimal.Parse(twoLines[1]);                             // ...a druga konwertuje do decimal i przypisuje do price
                SetMenuItemAtIndex(i, item);                                            // przydziela do tablicy
                SetMenuPriceAtIndex(i, price);                                          // j.w.
            }
        }

        private void SetMenuPriceAtIndex(int i, decimal price)
        {
            menuPrices[i] = price;
        }

        private void SetMenuItemAtIndex(int i, string item)
        {
            menuItems[i] = item;
        }

        public string[] GetMenuItems()
        {
            return menuItems;
        }

        public decimal[] GetMenuPrices()
        {
            return menuPrices;
        }
    }
}
