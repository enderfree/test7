using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace test7
{
    class Program
    {
        /// <summary>
        /// The main job is only to start the program
        /// </summary>
        static void Main(string[] args)
        {
            new Program();
            ReadKey(); //Let see the display even after the program terminated
        }

        private void DisplayCommand(Command command)
        {
            if (!command.commandItems.Equals(new List<Model.CommandItem>()))
            {
                Decimal total = 0;

                WriteLine("\n");
                foreach (Model.CommandItem commandItem in command.commandItems)
                {
                    total += commandItem.Price() * commandItem.Quantity();
                    WriteLine(commandItem);
                }
                WriteLine("\nTotal: " + total.ToString("0.00") + "$");
            }
            else
            {
                WriteLine("The command was canceled.");
            }
        }

        private void ManageCommand()
        {
            Command command = new Command();
            bool clientIsDone = false;

            do
            {
                WriteLine("Would you like too: \n" +
                    "1. Add an item to the command. \n" +
                    "2. Change the quantity of something you already in the command. \n" +
                    "3. Remove entirely something from the command. \n" +
                    "4. I am done. " +
                    "5. Cancel. ");

                switch (Validations.WaitForValidInput(5))
                {
                    case 1:
                        command.AddItem();
                        break;
                    case 2:
                        command.ModifyQuantity();
                        break;
                    case 3:
                        command.DeleteItem();
                        break;
                    case 4:
                        clientIsDone = true;
                        break;
                    case 5:
                        command.commandItems = new List<Model.CommandItem>();
                        clientIsDone = true;
                        break;
                    default:
                        WriteLine("This option is not code ready!");
                        break;
                }
            } while (!clientIsDone);

            DisplayCommand(command);
        }

        private Program() 
        {
            WriteLine("Hello and welcome to Wendies, what can I do for you?\n" +
                "1. Pass a command. \n" +
                "2. Exit.");

            switch (Validations.WaitForValidInput(2)) //parametter == last number in the above menu
            {
                case 1:
                    ManageCommand();
                    break;
                case 2:
                    WriteLine("See you next time then!");
                    return;
                default:
                    WriteLine("This option is not code ready!");
                    break;
            }
        }
    }
}
