using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            //make a new UI class
            UserInterface ui = new UserInterface();

            //new employee being created using the default
            //constructor that we wrote in the employee class
            //we are going to create an array of them.
            Employee myEmployee = new Employee();

            //lets make an array to hold a bunch of instances of employees
            Employee[] employees = new Employee[10];

            //hard coded employees added to array
            employees[0] = new Employee("David", "Barnes", 835.00m);
            employees[1] = new Employee("James", "Kirk", 453.00m);
            employees[2] = new Employee("Jean~Luc", "Picard", 290.00m);
            employees[3] = new Employee("Benjamin", "Sisko", 587.00m);
            employees[4] = new Employee("Kathryn", "Janeway", 194.00m);
            employees[5] = new Employee("Johnathan", "Archer", 135.00m);

            //get user input
            int choice = ui.GetUserInput();

            //loop until 2
            while (choice != 2){
                string outputString = "";
                if (choice == 1)
                {                   
                    //print out the employees of the array
                    foreach (Employee employee in employees)
                    {

                        if (employee != null)
                        {
                            outputString += employee.ToString() + Environment.NewLine;
                        }

                    }
                }
                ui.Output(outputString);
                //re enter input
                choice = ui.GetUserInput();
            }

        }
    }
}
