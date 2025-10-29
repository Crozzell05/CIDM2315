namespace Homework10;
using System;
using System.Collections.Generic;
using System.Linq;



    // 1. Create a Student class
    public class Student
    {
        private int studentID;
        private string studentName;

        // Public static list to store all Student objects
        public static List<Student> studentList = new List<Student>();

        // Constructor
        public Student(int id, string name)
        {
            studentID = id;
            studentName = name;

            // Add this object to the static list
            studentList.Add(this);
        }

        // Public method to print student info
        public void PrintInfo()
        {
            Console.WriteLine($"Student ID: {studentID}, Name: {studentName}");
        }

        // Property to get the student name (needed for Dictionary lookups)
        public string Name
        {
            get { return studentName; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 2. Create 4 students
            Student s1 = new Student(111, "Alice");
            Student s2 = new Student(222, "Bob");
            Student s3 = new Student(333, "Cathy");
            Student s4 = new Student(444, "David");

            // 3. Create Dictionary for gradebook
            Dictionary<string, double> gradebook = new Dictionary<string, double>();
            gradebook["Alice"] = 4.0;
            gradebook["Bob"] = 3.6;
            gradebook["Cathy"] = 2.5;
            gradebook["David"] = 1.8;

            // 4. Check if "Tom" is in gradebook; if not, add him
            if (!gradebook.ContainsKey("Tom"))
            {
                gradebook["Tom"] = 3.3;
            }

            // 5. Calculate average GPA
            double averageGPA = gradebook.Values.Average();
            Console.WriteLine($"\nAverage GPA: {averageGPA:F2}\n");

            // 6. Print students with GPA greater than average
            Console.WriteLine("Students with GPA greater than the average:");
            foreach (var entry in gradebook)
            {
                if (entry.Value > averageGPA)
                {
                    // Match student name from list
                    Student matchedStudent = Student.studentList.Find(s => s.Name == entry.Key);
                    if (matchedStudent != null)
                    {
                        matchedStudent.PrintInfo();
                        Console.WriteLine($"GPA: {entry.Value}\n");
                    }
                    else
                    {
                        // For Tom (who’s not in the Student list)
                        Console.WriteLine($"Name: {entry.Key}, GPA: {entry.Value}\n");
                    }
                }
            }
        }
    }
