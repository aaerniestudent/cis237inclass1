using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Employee
    {
        //variable / backing fields

        private string firstName;
        private string lastName;
        private decimal weeklySalary;

        //properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public decimal WeeklySalary
        {
            get { return weeklySalary; }
            set { weeklySalary = value; }
        }

        //Public Methods
        public string FirstAndLastName()
        {
            return firstName + " " + lastName;
        }

        public override string ToString()
        {
            return firstName + " " + lastName + " " + weeklySalary.ToString("C");
        }

        //constructors
        public Employee(string FirstName, string LastName, decimal WeeklySalary)
        {
            firstName = FirstName;
            lastName = LastName;
            weeklySalary = WeeklySalary;
        }

        public Employee()
        {
            //nothing
        }

    }
}
