using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test7.Model;
using static System.Console;

namespace test7
{
    class Command
    {
        //All items in the command
        public List<CommandItem> commandItems = new List<CommandItem>();

        /// <summary>
        /// Default constructor (used in the initialization)
        /// </summary>
        public Command() { }

        private CommandItem SelectBurger()
        {
            WriteLine("\nWhich do you want to add to your command? \n" +
                "1. Veggie Burger \n" +
                "2. Healthy Burger \n" +
                "3. Chicken Burger \n" +
                "4. Ham Burger \n" +
                "5. Back to the previous menu");

            switch (Validations.WaitForValidInput(5))
            {
                case 1: return new Model.Burger.VeggyBurger();
                case 2: return new Model.Burger.HealthyBurger();
                case 3: return new Model.Burger.ChickenBurger();
                case 4: return new Model.Burger.HamBurger();
                case 5: return null;
                default:
                    WriteLine("This option is not code ready!");
                    return null;
            }
        }

        private CommandItem SelectPizza()
        {
            WriteLine("\nWhich do you want to add to your command? \n" +
                "1. Hawaiien Pizza \n" +
                "2. Vegetarian Pizza \n" +
                "3. Meat Pizza \n" +
                "4. Back to the previous menu");

            switch (Validations.WaitForValidInput(4))
            {
                case 1: return new Model.Pizza.HawaiianPizza();
                case 2: return new Model.Pizza.VegetarianPizza();
                case 3: return new Model.Pizza.MeatPizza();
                case 4: return null;
                default:
                    WriteLine("This option is not code ready!");
                    return null;
            }
        }

        private CommandItem SelectDonut()
        {
            WriteLine("\nWhich do you want to add to your command? \n" +
                "1. Powdered \n" +
                "2. Ginger \n" +
                "3. Boston \n" +
                "4. Back to the previous menu");

            switch (Validations.WaitForValidInput(4))
            {
                case 1: return new Model.Donut.PowderedDonut();
                case 2: return new Model.Donut.GingerDonut();
                case 3: return new Model.Donut.BostonDonut();
                case 4: return null;
                default:
                    WriteLine("This option is not code ready!");
                    return null;
            }
        }

        private CommandItem SelectDrink()
        {
            WriteLine("\nWhich do you want to add to your command? \n" +
                "1. Long Island Ice Tea \n" +
                "2. Sex on the Beach \n" +
                "3. Long Winded Ice Tea \n" +
                "4. Back to the previous menu");

            switch (Validations.WaitForValidInput(4))
            {
                case 1: return new Model.Drink.LongIslandIceTea();
                case 2: return new Model.Drink.SexOnTheBeach();
                case 3: return new Model.Drink.LongWindedIceTea();
                case 4: return null;
                default:
                    WriteLine("This option is not code ready!");
                    return null;
            }
        }

        public void AddItem() 
        {
            CommandItem newCommandItem = null;

            do
            {
                WriteLine("\nWhich do you want to add to your command? \n" +
                    "1. Burger\n" +
                    "2. Pizza\n" +
                    "3. Donut\n" +
                    "4. Drink\n" +
                    "5. Cancel");

                switch (Validations.WaitForValidInput(5))
                {
                    case 1:
                        newCommandItem = SelectBurger();
                        break;
                    case 2:
                        newCommandItem = SelectPizza();
                        break;
                    case 3:
                        newCommandItem = SelectDonut();
                        break;
                    case 4:
                        newCommandItem = SelectDrink();
                        break;
                    case 5: return;
                    default:
                        WriteLine("This option is not code ready!");
                        break;
                }
            } while (newCommandItem == null);

            bool itemAdded = false;
            foreach (CommandItem item in commandItems)
            {
                if (item.Name() == newCommandItem.Name())
                {
                    item.Quantity(item.Quantity() + 1);
                    itemAdded = true;
                    break;
                }
            }

            if (!itemAdded)
            {
                commandItems.Add(newCommandItem);
            }
        }

        private int SelectItem()
        {
            if (commandItems.Count > 0)
            {
                WriteLine("Select an Item: ");

                int i = 1;
                foreach (CommandItem commandItem in commandItems)
                {
                    WriteLine(i + ". " + commandItem);
                }

                return Validations.WaitForValidInput(commandItems.Count) - 1;
            }
            else
            {
                WriteLine("You need to have something in your command in order to perform this action. ");
                return -1;
            }
        }

        public void ModifyQuantity()
        {
            int id = SelectItem();

            if (id != -1)
            {
                WriteLine("What will be the new quantity?");
                int quantity = Validations.WaitForInt();

                CommandItem selectedItem = commandItems[id];
                selectedItem.Quantity(quantity);

                if (selectedItem.Quantity() < 1)
                {
                    commandItems.Remove(selectedItem);
                }
            }
        }

        public void DeleteItem()
        {
            int id = SelectItem();
            commandItems.Remove(commandItems[id]);
        }
    }
}
