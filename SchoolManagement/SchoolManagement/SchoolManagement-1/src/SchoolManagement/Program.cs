using System;

namespace SchoolManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the School Management System!");

            // Initialize the StudentManager and SchoolManager
            var studentManager = new Services.StudentManager();
            var schoolManager = new Services.SchoolManager();

            // Main application loop
            while (true)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display Students");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Add School");
                Console.WriteLine("6. Display Schools");
                Console.WriteLine("0. Exit");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Logic to add a student
                        break;
                    case "2":
                        // Logic to display students
                        break;
                    case "3":
                        // Logic to update a student
                        break;
                    case "4":
                        // Logic to delete a student
                        break;
                    case "5":
                        // Logic to add a school
                        break;
                    case "6":
                        // Logic to display schools
                        break;
                    case "0":
                        Console.WriteLine("Exiting the application.");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}