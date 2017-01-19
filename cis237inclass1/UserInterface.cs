using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class UserInterface
    {
        //no variables, constructors, or properties
        //ONLY METHODS BWAHAHAHAHA
        
        //Methods
        public int GetUserInput()
        {
            //print out a menu
            PrintMenu();
            //get the input from the user
            String input = Console.ReadLine();
            //while the input is not valid, re-get input
            while (input != "1" && input != "2")
            {
                //print error message
                PrintErrorMessage();
                PrintMenu();
                input = Console.ReadLine();
            }

            //at this point I know the input is good, so return it
            return int.Parse(input);
        }

        public void Output(String s)
        {
            Console.WriteLine(s);
        }

        private void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Exit");
        }

        private void PrintErrorMessage()
        {
            Console.WriteLine("That is not a valid value.");
            Console.WriteLine("Please make a valid choice.");
            Console.WriteLine();
        }

        
    }
}
