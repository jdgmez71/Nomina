using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public int main = 1;
        public static void Main(string[] args)
        {
                Program program = new Program();
                Pays pays = new Pays();
                Console.WriteLine("Welcome to Payroll");
                Console.WriteLine("1. Add Employee \n2. Exit the program");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:                        
                        {                            
                            do
                            {
                                Console.WriteLine("Employee: " + program.main);
                                pays.Calculations();
                                pays.Print();
                                pays.SaveFile();
                                Console.WriteLine("\n1.Do you want to add another employee?");
                                Console.WriteLine("2.Exit the program");
                                menu = int.Parse(Console.ReadLine());
                                program.main++;
                            } while (menu != 2);
                          break;
                        }
                    case 2:
                        {                            
                            Console.WriteLine("Exit the program");                            
                            break;
                        }
                   default:
                    {
                        Console.WriteLine("Typing Error");
                        break;
                    } 
                }           
        }
    }
}
