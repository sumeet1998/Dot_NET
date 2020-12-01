using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee o1 = new Employee("Amol", 123465, 10);
            Employee o2 = new Employee("Amol", 123465);
            Employee o3 = new Employee("Amol");
            Employee o4 = new Employee();

            

            Console.WriteLine("Net Salary  "+o1.GetNetSalary());

            Console.WriteLine("=====================");

            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);

            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);

            Console.ReadLine();
            
        }
    }

    class Employee
    {
        
        public string name;
        private static int empNo;
        private decimal basic;
        private short deptNo;
        private decimal netsalary;
        static int id = 0;

        public Employee()
        {

        }
        public Employee(string Name, decimal Basic, short DeptNo) {

            id++;
            this.EmpNo = id;
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }

        public Employee(string Name, decimal Basic)
        {
            id++;
            this.EmpNo = id;
            this.Name = Name;
            this.Basic = Basic;
        }

        public Employee(string Name)
        {
            id++;
            this.EmpNo = id;
            this.Name = Name;
        }


        public string Name
        {
            get { return name; }
            set
            {
                if (value != "sumeet")
                {
                    
                    name = value;
                }
                else
                    Console.WriteLine("Invalid Name !!");


            }
        }
        public int EmpNo
        {
            get;
        }

        public decimal Basic
        {
            get { return basic; }
            set
            {
                if (value > 1000 && value < 1000000)
                    basic = value;
                else
                    Console.WriteLine("Invalid salary !!");
            }
        }
        public short DeptNo
        {
            get { return deptNo; }
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("Invalid Depatment Number !!");
            }
        }

        public decimal GetNetSalary()
        {
           
            Console.WriteLine("Enter your Salary");
            netsalary = Convert.ToDecimal(Console.ReadLine());
            
               netsalary = netsalary - Basic;
               return netsalary;
                     
        }
    }
}
