using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace test7
{
    public static class Validations
    {
        public static int WaitForValidInput(int nbOfChoices)
        {
            for (; ; )
            {
                if (int.TryParse(ReadLine(), out int choice))
                {
                    if (choice > 0 && choice <= nbOfChoices)
                    {
                        return choice;
                    }
                }

                WriteLine("Sorry, we didn't get that, can you select the number again?");
            }
        }

        public static int WaitForInt()
        {
            for (; ; )
            {
                if (int.TryParse(ReadLine(), out int integer))
                {
                    return integer;
                }

                WriteLine("Please answer with an integer.");
            }
        }
    }
}
