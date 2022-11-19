﻿using System;
using System.Collections.Generic;

namespace Lab4_Collection_generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee E1 = new Employee()
            {
                ID = 101,
                Name = "Anas",
                Gender = "Male",
                Salary = 20000
            };
            Employee E2 = new Employee()
            {
                ID = 102,
                Name = "Hanna",
                Gender = "Female",
                Salary = 30000
            };
            Employee E3 = new Employee()
            {
                ID = 103,
                Name = "Tobias",
                Gender = "Male",
                Salary = 40000
            };
            Employee E4 = new Employee()
            {
                ID = 104,
                Name = "Sara",
                Gender = "Female",
                Salary = 40000
            };
            Employee E5 = new Employee()
            {
                ID = 105,
                Name = "Anna",
                Gender = "Female",
                Salary = 50000
            };

            Stack<Employee> stEmp = new Stack <Employee>();
            stEmp.Push(E1);
            stEmp.Push(E2);
            stEmp.Push(E3);
            stEmp.Push(E4);
            stEmp.Push(E5);

            Console.WriteLine("Printing all items in Stack ");

            foreach (Employee item in stEmp)
            {
                Console.WriteLine("ID = {0} \n Name = {1} \n Gender = {2} \n Salary = {3}", item.ID, item.Name, item.Gender, item.Salary);
                Console.WriteLine("Item left in stack " + stEmp.Count);
                Console.WriteLine("--------------------------------");

            }

            Console.WriteLine("Retrive Using Pop Method ");

            for(int i = stEmp.Count; i > 0; i--)
            {
                Employee DelEmp =  stEmp.Pop();
                Console.WriteLine("ID = {0} \n Name = {1} \n Gender = {2} \n Salary = {3}", DelEmp.ID, DelEmp.Name, DelEmp.Gender, DelEmp.Salary);
                Console.WriteLine("Item left in stock " + stEmp.Count);
                Console.WriteLine("/////////////////////////////////");


            }

            Console.WriteLine("Restack Employee ");
            stEmp.Push(E1);
            stEmp.Push(E2);
            stEmp.Push(E3);
            stEmp.Push(E4);
            stEmp.Push(E5);

            Console.WriteLine("Element at the top of my list is ");
            Console.WriteLine("----------------------------------");
            Employee PEK = stEmp.Peek();
            Console.WriteLine("ID = {0} \n Name = {1} \n Gender = {2} \n Salary = {3}", PEK.ID, PEK.Name, PEK.Gender, PEK.Salary);
            Console.WriteLine("Items left in stack {0}", stEmp.Count);
            Console.WriteLine();
            Employee PEK2 = stEmp.Peek();
            Console.WriteLine("ID = {0} \n Name = {1} \n Gender = {2} \n Salary = {3}", PEK.ID, PEK.Name, PEK.Gender, PEK.Salary);
            Console.WriteLine("Items left in stack {0}", stEmp.Count);
            Console.WriteLine("------------------------------------");

            


            if (stEmp.Contains(E3))
            {
                Console.WriteLine("Emp3 is in stack ");

            }
            else
            {
                Console.WriteLine("Emp3 is not in stack ");
            }

            Console.WriteLine("------------Del2-----------------------------");

        }

       



    }


}
