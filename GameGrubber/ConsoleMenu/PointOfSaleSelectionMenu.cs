﻿namespace GameGrubber.ConsoleMenu
{
    internal class PointOfSaleSelectionMenu
    {
        public void Execute()
        {
            while (true)
            {
                Console.Clear();
                Console.Write(@"
____________________________________

Point of sale selection menu
____________________________________

Make a sale ..................... 1
Settings ........................ 2
Go back ......................... B
Quit to desktop ................. Q
");

                string posMenuChoice = Console.ReadLine();
                if (posMenuChoice == "1")
                {
                    CheckoutMenu checkoutMenu = new CheckoutMenu();
                    checkoutMenu.Execute();
                }
                else if (posMenuChoice == "2")
                {
                    PointOfSaleSettingsMenu settingsMenu = new PointOfSaleSettingsMenu();
                    settingsMenu.Execute();
                }
                else if (posMenuChoice.ToUpper() == "B") return;
                else if (posMenuChoice.ToUpper() == "Q") Environment.Exit(0);
            }
        }
    }
}
