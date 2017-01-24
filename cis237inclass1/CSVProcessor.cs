using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cis237inclass1
{
    class CSVProcessor
    {

        public bool InportCsv(string pathToCSVFile, Employee[] employees)
        {
            //declare stream reader
            StreamReader streamReader = null;

            try
            {
                //declare a string for the line
                string line;

                //Instaciate the stream reader
                streamReader = new StreamReader(pathToCSVFile);

                int counter = 0;

                //while we are still reading a line from the file
                while ((line = streamReader.ReadLine()) != null)
                {
                    //Process the line
                    ProcessLine(line, employees, counter++);
                }
                return true;
            }
            catch (Exception e)
            {
                //output the exception and the statck trace for the exception
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);

                return false;
            }
            finally
            {
                //if stream reader was instanciated, make sure it is closed
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }           
        }

        private void ProcessLine(string line, Employee[] employees, int index)
        {
            string[] parts = line.Split(',');
            string firstName = parts[0];
            string lastName = parts[1];
            decimal salary = decimal.Parse(parts[2]);

            //add a new employee into the array that was passed in.
            employees[index] = new Employee(firstName, lastName, salary);
        }
    }
}
