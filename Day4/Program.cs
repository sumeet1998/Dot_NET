﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment4
{
    class Program
    {
        static void Main1(string[] args)
        {
            object[] arr1 = new object[1];
            Employees[] arr = new Employees[3];
            Employees emp1 = new Employees(1, "Sumeet", 3200000);
            Employees emp2 = new Employees(2, "Rohan", 5200000);
            Employees emp3 = new Employees(3, "Ankit", 22000);



            arr[0] = emp1;
            arr[1] = emp2;
            arr[2] = emp3;


            //Method 1
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].EmpSal > arr[j + 1].EmpSal)
                    {

                        Employees temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].EmpSal == arr[arr.Length - 1].EmpSal)
                    Console.WriteLine(arr[i].EmpId + " " + arr[i].EmpName + "  " + arr[i].EmpSal);
            }


            int eno = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].EmpId == eno)
                    Console.WriteLine(arr[i].EmpId + " " + arr[i].EmpName + "  " + arr[i].EmpSal);
            }





            Console.ReadLine();
        }

    }

    class Employees
    {
        private int empId;

        private string empName;
        private decimal empSal;

        public int EmpId
        {
            get;
            set;
        }
        public string EmpName { get; set; }
        public decimal EmpSal { get; set; }

        public Employees(int empId, string empName, decimal empSal)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.EmpSal = empSal;
        }

    }
}

namespace Question2
{
    class Program
    {
        static void Main2()
        {
            Console.Write("Enter Number of Batches : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[b][];
            for (int i = 0; i < b; i++)
            {
                Console.Write($"Enter Number of Student in {i + 1} : ");
                int s = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[s];
                for (int j = 0; j < s; j++)
                {
                    Console.Write($"Enter Marks Batch {i + 1} Student {j + 1} : ");
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine($"Batch {i + 1} Stuendt {j + 1} Marks are :" + arr[i][j]);
                }
            }
            Console.ReadLine();
        }
    }
}

namespace Que3
{
    class Program
    {
        static void Main()
        {

            Console.ReadLine();
        }

    }
    public struct Student
    {
        private string name;
        private int rollNo;
        private decimal marks;

        // public string Name { get { return name; } set { if (value == null) Console.WriteLine("Invalid Name "); else name = value; } }
        public string Name { get; set; }
        // public int RollNo { get { return rollNo; } set { if (value > 0) rollNo = value; else Console.WriteLine("Invalid RollNo"); } }
        public int RollNo { get; set; }
        public decimal Marks { get; set; }

        /*public Student(string name, int rollNo, decimal marks)
        {
            this.Name = name;
            this.RollNo = rollNo;
            this.Marks = marks;
        }*/
    }
}