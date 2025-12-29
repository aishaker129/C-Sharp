
namespace Student_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();
            int choice;

            do
            {
                Console.WriteLine("\nStudent Management System");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Search Student by ID");
                Console.WriteLine("6. Search Student by Email");
                Console.WriteLine("7. Search Student by Name");
                Console.WriteLine("8. Search Student by University");
                Console.WriteLine("9. Search Student by Intake");
                Console.WriteLine("10. Search Student by Section");
                Console.WriteLine("11. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Student Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Student Email: ");
                        string emial = Console.ReadLine();
                        Console.Write("Student Department: ");
                        string dept = Console.ReadLine();
                        Console.Write("Student Intake: ");
                        int intake = int.Parse(Console.ReadLine());
                        Console.Write("Student Section: ");
                        int section = int.Parse(Console.ReadLine());
                        Console.Write("Student University: ");
                        string uni = Console.ReadLine();
                        studentService.AddStudent(name, emial, dept, intake, section, uni);
                        break;
                    case 2:
                        // Code to view students
                        studentService.ViewStudents();
                        break;
                    case 3:
                        // Code to update student
                        Console.Write("Enter Student ID to update: ");
                        int updateId = int.Parse(Console.ReadLine());
                        Console.Write("Student Name: ");
                        string updateName = Console.ReadLine();
                        Console.Write("Student Email: ");
                        string updateEmial = Console.ReadLine();
                        Console.Write("Student Department: ");
                        string updateDept = Console.ReadLine();
                        Console.Write("Student Intake: ");
                        int updateIntake = int.Parse(Console.ReadLine());
                        Console.Write("Student Section: ");
                        int updateSection = int.Parse(Console.ReadLine());
                        Console.Write("Student University: ");
                        string updateUni = Console.ReadLine();
                        studentService.UpdateStudents(updateId, updateName, updateEmial, updateIntake, updateSection);
                        break;
                    case 4:
                        // Code to delete student
                        Console.Write("Enter Student ID to delete: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        studentService.DeleteStudent(deleteId);
                        break;
                    case 5:
                        // Code to search student by ID
                        Console.Write("Enter Student ID to search: ");
                        int searchId = int.Parse(Console.ReadLine());
                        studentService.SearchStudent(searchId);
                        break;
                    case 6:
                        // Code to search student by email
                        Console.Write("Enter Student Email to search: ");
                        string searchEmail = Console.ReadLine();
                        studentService.SearchStudentByEmail(searchEmail);
                        break;
                    case 7:
                        // Code to search student by name
                        Console.Write("Enter Student Name to search: ");
                        string searchName = Console.ReadLine();
                        studentService.SearchStudentByName(searchName);
                        break;
                    case 8:
                        // Code to search student by university
                        Console.Write("Enter Student University to search: ");
                        string searchUniversity = Console.ReadLine();
                        studentService.SearchStudentByUniversity(searchUniversity);
                        break;
                    case 9:
                        // Code to search student by intake
                        Console.Write("Enter Student Intake to search: ");
                        int searchIntake = int.Parse(Console.ReadLine());
                        studentService.SearchStudentByIntake(searchIntake);
                        break;
                    case 10:
                        // Code to search student by section
                        Console.Write("Enter Student Section to search: ");
                        int searchSection = int.Parse(Console.ReadLine());
                        studentService.SearchStudentBySection(searchSection);
                        break;
                    case 11:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 11);
        }
            
    }
}
