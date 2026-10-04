using System;

struct Student
{
    public string StudentNumber, Name, Program;
    public int YearLevel;
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[10];
        int count = 0;
        int choice;

        do
        {
            Console.WriteLine("\n============================");
            Console.WriteLine("STUDENT RECORDS MANAGEMENT");
            Console.WriteLine("============================");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display All Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                if (count >= 10)
                {
                    Console.WriteLine("Cannot add more than 10 students.");
                }
                else
                {
                    Student s = new Student();
                    Console.Write("Enter Student Number: ");
                    s.StudentNumber = Console.ReadLine();
                    Console.Write("Enter Name: ");
                    s.Name = Console.ReadLine();
                    Console.Write("Enter Program: ");
                    s.Program = Console.ReadLine();
                    Console.Write("Enter Year Level: ");
                    s.YearLevel = int.Parse(Console.ReadLine());
                    students[count++] = s;
                    Console.WriteLine("Student added successfully!");
                }
            }
            else if (choice == 2)
            {
                if (count == 0)
                {
                    Console.WriteLine("No records found.");
                }
                else
                {
                    Console.WriteLine("\n============================");
                    Console.WriteLine("STUDENT RECORDS");
                    Console.WriteLine("============================");
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine("\nStudent Number: " + students[i].StudentNumber);
                        Console.WriteLine("Name: " + students[i].Name);
                        Console.WriteLine("Program: " + students[i].Program);
                        Console.WriteLine("Year Level: " + students[i].YearLevel);
                    }
                }
            }
            else if (choice == 3)
            {
                Console.Write("Enter Student Number to search: ");
                string num = Console.ReadLine();
                int idx = Find(students, count, num);
                if (idx == -1)
                    Console.WriteLine("Student not found.");
                else
                {
                    Console.WriteLine("\nStudent Found!");
                    Console.WriteLine("Student Number: " + students[idx].StudentNumber);
                    Console.WriteLine("Name: " + students[idx].Name);
                    Console.WriteLine("Program: " + students[idx].Program);
                    Console.WriteLine("Year Level: " + students[idx].YearLevel);
                }
            }
            else if (choice == 4)
            {
                Console.Write("Enter Student Number to update: ");
                string num = Console.ReadLine();
                int idx = Find(students, count, num);
                if (idx == -1)
                    Console.WriteLine("Student not found.");
                else
                {
                    Console.Write("Enter New Name: ");
                    students[idx].Name = Console.ReadLine();
                    Console.Write("Enter New Program: ");
                    students[idx].Program = Console.ReadLine();
                    Console.Write("Enter New Year Level: ");
                    students[idx].YearLevel = int.Parse(Console.ReadLine());
                    Console.WriteLine("Student updated successfully!");
                }
            }
            else if (choice == 5)
            {
                Console.Write("Enter Student Number to delete: ");
                string num = Console.ReadLine();
                int idx = Find(students, count, num);
                if (idx == -1)
                    Console.WriteLine("Student not found.");
                else
                {
                    for (int i = idx; i < count - 1; i++)
                        students[i] = students[i + 1];
                    count--;
                    Console.WriteLine("Student deleted successfully!");
                }
            }
            else if (choice == 6)
            {
                Console.WriteLine("Program exited.");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

        } while (choice != 6);
    }

    static int Find(Student[] arr, int n, string num)
    {
        for (int i = 0; i < n; i++)
            if (arr[i].StudentNumber == num) return i;
        return -1;
    }
}
