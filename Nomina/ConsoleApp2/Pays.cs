using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Pays
    {
        Data data = new Data();

        
        public void Calculations()
        {
            try
            {
                Console.WriteLine("Insert your first name: ");
                data.FirstName1 = Console.ReadLine();
                Console.WriteLine("Insert your last name: ");
                data.LastName1 = Console.ReadLine();
                Console.WriteLine("Insert your document: ");
                data.Document1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Insert your salary: ");
                data.Salary1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Insert your Worked Days: ");
                data.WorkedDays1 = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Typing Error");
            }
                data.TotalAccurred1 = data.Salary1 / 30 * data.WorkedDays1;
                data.SubsidyHealth1 = data.TotalAccurred1 * 0.04;
                data.Pension1 = data.TotalAccurred1 * 0.04;
                
                if (data.Salary1 <= 2000000)
                {
                  data.SubsidyTransport1 = 117172 / 30 * data.WorkedDays1;
                  data.TotalAccurred1 = data.TotalAccurred1 + data.SubsidyTransport1;
                }
                else
                {
                  data.TotalAccurred1 = data.TotalAccurred1;
                }     
        }

        public void Print()
        {

            Console.WriteLine("\n----------------------------------------------------------------------");
            Console.WriteLine("First Name: " + data.FirstName1);
            Console.WriteLine("Last Name: " + data.LastName1);
            Console.WriteLine("Document: " + data.Document1);
            Console.WriteLine("Salary: " + data.Salary1);
            Console.WriteLine("Worked Days: " + data.WorkedDays1);
            Console.WriteLine("Subsidy Health: " + data.SubsidyHealth1);
            Console.WriteLine("Pension: " + data.Pension1);
            Console.WriteLine("Total Accurred: " + data.TotalAccurred1);
        }
        public void SaveFile()
        {
            Program numberemployee = new Program();
            TextWriter File = new StreamWriter("C:\\Payroll.txt", true);
            File.WriteLine("Employee: " + numberemployee.main);
            File.WriteLine("First Name: " + data.FirstName1);
            File.WriteLine("Last Name: " + data.LastName1);
            File.WriteLine("Document: " + data.Document1);
            File.WriteLine("Salary: " + data.Salary1);
            File.WriteLine("Worked Days: " + data.WorkedDays1);
            File.WriteLine("Subsidy Health: " + data.SubsidyHealth1);
            File.WriteLine("Pension: " + data.Pension1);
            File.WriteLine("Total Accurred: " + data.TotalAccurred1);
            File.WriteLine("");
            File.WriteLine("----------------------------------------------------");
            File.WriteLine("");
            File.Close();
        }
    }
}
