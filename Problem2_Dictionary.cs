using System;
using System.Collections.Generic;

struct Student
{
    public string StudentNumber, Name, Program;
    public int YearLevel;
}

class Program
{
    static void Main()
    {
        Dictionary<string, Student> studentDict = new Dictionary<string, Student>();
        int choice;

        do
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("STUDENT LOOKUP USING DICTIONARY");
            Console.WriteLine("================================");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Search Student");
            Console.WriteLine("3. Display All Students");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Student s = new Student();
                Console.Write("Enter Student Number: ");
                s.StudentNumber = Console.ReadLine();
                if (studentDict.ContainsKey(s.StudentNumber))
                {
                    Console.WriteLine("Duplicate Student Number not allowed.");
                }
                else
                {
                    Console.Write("Enter Name: ");
                    s.Name = Console.ReadLine();
                    Console.Write("Enter Program: ");
                    s.Program = Console.ReadLine();
                    Console.Write("Enter Year Level: ");
                    s.YearLevel = int.Parse(Console.ReadLine());
                    studentDict.Add(s.StudentNumber, s);
                    Console.WriteLine("Student added successfully!");
                }
            }
            else if (choice == 2)
            {
                Console.Write("Enter Student Number: ");
                string num = Console.ReadLine();
                if (studentDict.TryGetValue(num, out Student s))
                {
                    Console.WriteLine("\nStudent Found!");
                    Console.WriteLine("Student Number: " + s.StudentNumber);
                    Console.WriteLine("Name: " + s.Name);
                    Console.WriteLine("Program: " + s.Program);
                    Console.WriteLine("Year Level: " + s.YearLevel);
                }
                else
                {
                    Console.WriteLine("Student does not exist.");
                }
            }
            else if (choice == 3)
            {
                if (studentDict.Count == 0)
                {
                    Console.WriteLine("No records found.");
                }
                else
                {
                    foreach (var kvp in studentDict)
                    {
                        Student s = kvp.Value;
                        Console.WriteLine("\nStudent Number: " + s.StudentNumber);
                        Console.WriteLine("Name: " + s.Name);
                        Console.WriteLine("Program: " + s.Program);
                        Console.WriteLine("Year Level: " + s.YearLevel);
                    }
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine("Program exited.");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

        } while (choice != 4);
    }
}
