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
                //This is for the user to select a choice from the screen to update the database.
                WriteLine("\n\t1.Add an employee" +
                    "\n\t2.Delete an employee" +
                    "\n\t3.Print employees" +
                    "\n\t4.Sort by name" +
                    "\n\t5.Sort by salary" +
                    "\n\t6.Sort by title" +
                    "\n\t7.Exit");

                Write("Enter: ");
                int userChoice = Convert.ToInt32(ReadLine());

                    if (userChoice == 1)
                    {
                        AddToDatabase();
                    }
                    else if (userChoice == 2)
                    {
                        delete();
                    }
                    else if (userChoice == 3)
                    {
                        print();
                    }
                    else if (userChoice == 4)
                    {
                        sortByName();
                    }
                    else if (userChoice == 5)
                    {
                        sortBySalary();
                    }
                    else if (userChoice == 6)
                    {
                        sortByTitle();
                    }
                    else if (userChoice == 7)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"An unexpected value ({userChoice})");
                    }
               
               }
        }

        //this method is to add the employee information on to the employee array.
        public static void AddToDatabase()
        {
          //ArrayList emp = new ArrayList();
            Emp emp = new Emp();
            string name, title;
            int salary;
            Write("enter employee Name:");
            emp.name = ReadLine();
            Write("enter employee title:");
            emp.title = ReadLine();
            do
            {
            Write("Enter employee salary: ");
            salary = Convert.ToInt32(ReadLine());
            }
            while (salary <= 0);
            emp.salary = salary;
            Console.WriteLine(emp);
            db.Add(emp);
        }

        //this method is to delete the employee information on to the employee array.
        public static void delete()
        {
            int num;
            do
            {
                print();
                Write("\nwhich employee would you like to delete:");
                num = Convert.ToInt32(ReadLine());
            }
            while (num > db.Count || num < 1);
            db.RemoveAt(num - 1);
        }

        //this method is to sort the employee information based on employee name.
        public static void sortByName()
        {
            do
            {
                db.Sort(Emp.CompareNames);
                WriteLine("sorted by name successfully ");
                print();
            }

            while (db.Count == 0);
            WriteLine("sorted by name successfully");
        }

        //this method is to sort the employee information based on employee salary.
        public static void sortBySalary()
        {
            do
            {
                db.Sort(Emp.CompareSalary);
                WriteLine("sorted by salary successfully ");
                print();
            }

            while (db.Count == 0);
            WriteLine("sorted by salary successfully");
        }

        //this method is to sort the employee information based on employee salary.
        public static void sortByTitle()
        {
            do
            {
                db.Sort(Emp.CompareTitle);
                WriteLine("sorted by title successfully ");
                print();
            }

            while (db.Count == 0);
            WriteLine("sorted by title successfully");
        }

        //this method is to print all the employees information in from the arrayList.
        public static void print()
        {
            if (db.Count == 0)
            {
                WriteLine("the DataBase is Empty");
            }
            else
            {
                WriteLine("#\temployee name\temployee title\tsalary");

                /* for (int i = 0; i < db.Count; i++)
                 {
                     Console.WriteLine(db[i].ToString);
                 }*/
                int count = 1;
                foreach (Emp emp in db)
                {
                    WriteLine(count + "\t" + emp.name + "\t\t" + emp.title + "\t\t" + emp.salary);
                    count++;
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
            return name + "\t" + title + "\t" + salary;

        }
         public static int CompareNames(Emp x, Emp y)
        {
            return x.name.CompareTo(y.name);
        }

        public static int CompareSalary(Emp x, Emp y)
        {
            return x.salary.CompareTo(y.salary);
        }
        public static int CompareTitle(Emp x, Emp y)
        {
            return x.title.CompareTo(y.title);
        }
    }
}
