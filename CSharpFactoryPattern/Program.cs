using AdmissionManagement.FactoryPattern;
using AdmissionManagement.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionManagement
{
     class Program
    {
        static void Main(string[] args)
        {
            // Create factories
            var studentFactory = new StudentFactory();

            // Create repositories
            var studentRepository = new StudentRepository();

            //AddCommand();
            bool isRunning = true;
            while (isRunning)
            {
                AddCommand();
                try 
                {
                    var command = Console.ReadLine().ToLower();
                    if (command == "c")
                    {
                        AddCommand();
                    }
                    else if (command == "x")
                    {
                        isRunning = false;
                    }
                    else if (command == "rp")
                    {
                        Console.WriteLine("Type a Student id");
                        var StudentId = Convert.ToInt32(Console.ReadLine());
                        // Read and display student
                        var retrievedStudent = studentRepository.Read(StudentId) as Student;
                        Console.WriteLine($"Student: {retrievedStudent.StudentName}");
                    }
                    else if (command == "cp")
                    {
                        Console.WriteLine("Type a Student name");
                        var name = Console.ReadLine();
                        // Create a new student
                        var student = studentFactory.CreateEntity() as Student;
                        student.StudentName = name;
                        studentRepository.Create(student);
                    }
                    else if (command == "up")
                    {
                        Console.WriteLine("Type a student Id");
                        var id = Convert.ToInt32(Console.ReadLine());
                        var updatedStudent = studentRepository.Read(1) as Student;
                        Console.WriteLine($"Updated Student: {updatedStudent.StudentName}");

                        Console.WriteLine("Type a student name to update");
                        var name = Console.ReadLine();
                        // Update student
                        updatedStudent.StudentName = name;
                        studentRepository.Update(updatedStudent);
                    }
                    else if (command == "dp")
                    {
                        Console.WriteLine("Type a Student Id");
                        var StudentId = Convert.ToInt32(Console.ReadLine());

                        // Confirm deletion
                        var deletedStudent = studentRepository.Read(StudentId);
                        Console.WriteLine($"Deleted Student: {deletedStudent.StudentName}");
                        studentRepository.Delete(StudentId);
                    }
                }
                catch { }
            }
        }

        static void AddCommand()
        {
            Console.WriteLine("Press 'CP' for Creation of Student");
            Console.WriteLine("Press 'RP' for Read a Student");       
            Console.WriteLine("Press 'UP' for Update of Student");
            Console.WriteLine("Press 'DP' for Deletion of Student");
            Console.WriteLine("Press 'C' for clear window and 'X' for exit");
        }
    }
}
