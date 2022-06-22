using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Data
    {
        private string FirstName;
        private string LastName;
        private int Document;
        private double Salary;
        private int WorkedDays;
        private double SubsidyTransport;
        private double SubsidyHealth;
        private double Pension;
        private double TotalAccurred;

        public Data()
        {
        }
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public int Document1 { get => Document; set => Document = value; }
        public double Salary1 { get => Salary; set => Salary = value; }
        public int WorkedDays1 { get => WorkedDays; set => WorkedDays = value; }
        public double SubsidyTransport1 { get => SubsidyTransport; set => SubsidyTransport = value; }
        public double SubsidyHealth1 { get => SubsidyHealth; set => SubsidyHealth = value; }
        public double Pension1 { get => Pension; set => Pension = value; }
        public double TotalAccurred1 { get => TotalAccurred; set => TotalAccurred = value; }
    }
}
