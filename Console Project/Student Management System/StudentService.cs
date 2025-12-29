using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace Student_Management_System
{
    internal class StudentService
    {
        private List<Student> students = new List<Student>();
        private int idTracker = 0;

        public void AddStudent(string name,string email, string department, int intake, int section, string university)
        {
            students.Add(new Student
            {
                Id = idTracker++,
                Name = name,
                Email = email,
                Department = department,
                Intake = intake,
                Section = section,
                University = university
            });
            Console.WriteLine("Student added successfully..");
        }

        public void ViewStudents()
        {
            if (students.Count > 0)
            {
                foreach (Student student in students)
                {
                    Console.WriteLine($"ID: {student.Id} - Name: {student.Name} - Email: {student.Email}" +
                        $"- Department: {student.Department} - Intake: {student.Intake} - Section: {student.Section} - " +
                        $"University: {student.University}");
                }
            }
            else
            {
                Console.WriteLine("Student not found");
            }
        }

        public void UpdateStudents(int id,string name,string emile,int intake, int section)
        {
            Student student = students.FirstOrDefault(x => x.Id == id);

            if(student == null)
            {
                Console.WriteLine("Student not found..");
            }
            else
            {
                student.Name = name;
                student.Email = emile;
                student.Intake = intake;
                student.Section = section;

                Console.WriteLine("Student updated successfully..");
            }
        }

        public void DeleteStudent(int id)
        {
            Student student = students.FirstOrDefault(x => x.Id == id);

            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student updated successfully..");
            }
            else
            {
                Console.WriteLine("Student not found..");
            }
        }

        public void SearchStudent(int id)
        {
            Student student = students.FirstOrDefault(x => x.Id == id);
            if (student != null)
            {
                Console.WriteLine($"ID: {student.Id} - Name: {student.Name} - Email: {student.Email}" +
                       $"- Department: {student.Department} - Intake: {student.Intake} - Section: {student.Section} - " +
                       $"University: {student.University}");
            }
            else
            {
                Console.WriteLine("Student not found..");
            }
           

        }

        public void SearchStudentByEmail(string email)
        {
            Student student = students.FirstOrDefault(x => x.Email == email);
            if (student != null)
            {
                Console.WriteLine($"ID: {student.Id} - Name: {student.Name} - Email: {student.Email}" +
                       $"- Department: {student.Department} - Intake: {student.Intake} - Section: {student.Section} - " +
                       $"University: {student.University}");
            }
            else
            {
                Console.WriteLine("Student not found..");
            }


        }

        public void SearchStudentByName(string name)
        {

            List<Student> std = students.Where(x => x.Name == name).ToList();

            if (std.Count > 0)
            {
                foreach (Student student in std)
                {
                    Console.WriteLine($"ID: {student.Id} - Name: {student.Name} - Email: {student.Email}" +
                           $"- Department: {student.Department} - Intake: {student.Intake} - Section: {student.Section} - " +
                           $"University: {student.University}");
                }
            }
            else
            {
                Console.WriteLine("Student not found..");
            }

        }

        public void SearchStudentByUniversity(string university)
        {
            List<Student> std = students.Where(x => x.University == university).ToList();

            if (std.Count > 0)
            {
                foreach (Student student in std)
                {
                    Console.WriteLine($"ID: {student.Id} - Name: {student.Name} - Email: {student.Email}" +
                           $"- Department: {student.Department} - Intake: {student.Intake} - Section: {student.Section} - " +
                           $"University: {student.University}");
                }
            }
            else
            {
                Console.WriteLine("Student not found..");
            }
        }

        public void SearchStudentByIntake(int intake)
        {
            List<Student> std = students.Where(x => x.Intake == intake).ToList();

            if (std.Count > 0)
            {
                foreach (Student student in std)
                {
                    Console.WriteLine($"ID: {student.Id} - Name: {student.Name} - Email: {student.Email}" +
                           $"- Department: {student.Department} - Intake: {student.Intake} - Section: {student.Section} - " +
                           $"University: {student.University}");
                }
            }
            else
            {
                Console.WriteLine("Student not found..");
            }
        }

        public void SearchStudentBySection(int section)
        {
            List<Student> std = students.Where(x => x.Section == section).ToList();

            if (std.Count > 0)
            {
                foreach (Student student in std)
                {
                    Console.WriteLine($"ID: {student.Id} - Name: {student.Name} - Email: {student.Email}" +
                           $"- Department: {student.Department} - Intake: {student.Intake} - Section: {student.Section} - " +
                           $"University: {student.University}");
                }
            }
            else
            {
                Console.WriteLine("Student not found..");
            }
        }


    }
}
