using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace EmployeeDatabese
{
    class MainClass
    {
        private static List<Emp> db = new List<Emp>();
        public static void Main(string[] args)
        {
            WriteLine("Welcome to the Yash Data base!");
            while (true)
            {
                WriteLine("\n\t1.Add an employee\n\t2.Delete an employee" +
                    "\n\t3.Print employees\n\t4.Sort by name" +
                    "\n\t5.Sort by salary\n\t6.Exit");
                Write("Enter: ");
                int x = Convert.ToInt32(ReadLine());
                if (x == 1)
                {
                    add();
                }else if (x == 2)
                {
                    delete();
                }else if (x == 3)
                {
                    print();
                }else if (x == 4)
                {
                    sortByName();
                }else if (x == 5)
                {
                    sortBySalary();
                }else if (x == 6)
                {
                    break;
                }
                else
                {
                    WriteLine("Wrong choice try again!");
                }

            }
        }
        public static void add()
        {
            //ArrayList emp = new ArrayList();
            Emp emp = new Emp();

            string name,title;
            int salary;
            Write("enter employee Name:");
            name= ReadLine();
            emp.name=name;/*
            Write("enter employee title:");
            title = ReadLine();
            emp.title=title;    
            do
            {
                Write("Enter employee salary: ");
                salary = Convert.ToInt32(ReadLine());
            } while (salary <= 0);
            emp.salary=salary;
            // db.Add(emp);*/
            db.Add(emp);
        }
        public static void delete()
        {
            int num;
            do
            {
                print();
                Write("\nwhich employee would you like to delete:");
                num =Convert.ToInt32(ReadLine());
            } while (num > db.Count || num < 1);
            db.RemoveAt(num - 1);
        }
        public static void sortByName()
        {
            
          //  db.Sort();
            WriteLine("sorted by name successfully");
        }
        public static void sortBySalary()
        {
            db.Sort();
            WriteLine("sorted by salary successfully");
        }
        public static void print()
        {  
            if (db.Count ==0)
            {
                WriteLine("the DataBase is Empty");
            }
            else {
                WriteLine("#\temployee name\temployee title\tsalary");
                
                for (int i = 0; i < db.Count; i++)
                {
                    Console.WriteLine((i+1)+db[i].ToString());
                }
             
            }
        }
    }
    class Emp
    {
        public string name { get; set; }// prob (tab tab)
        public string title { get; set; }
        public int salary { get; set; }

        public override string ToString()
        {
            return "\t" +name + "\t\t" +title + "\t\t" + salary;
           // return name+"\t"+title+
        }
    }
}
