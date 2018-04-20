using System;
using System.Windows;

namespace PizzaCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FileHandler handler = new FileHandler();

            handler.ReadMenu();

            string[] items = handler.GetMenuItems();
            decimal[] prices = handler.GetMenuPrices();

            for(int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i] + " ");
                Console.Write(prices[i] + "\n");
            }
        }
    }
}
