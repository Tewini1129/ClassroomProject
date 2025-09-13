using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomProject.MenuMethods
{
    public class AddStudent
    {
        public static bool Continue;
        public static void Add(List<Student> students)
        {
            Console.Write("Please enter the students name: ");
            string? newName = Console.ReadLine();
            Console.Write("\nPlease enter the students programing level: ");
            Continue = false;
            while (Continue == false)
            {
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int newProgramingLevel))
                {
                    Student StudentToAdd = new Student()
                    {
                        Name = newName,
                        ProgramingLevel = 0,
                        IsPresent = false,
                        KnownTools = new List<Tool>()
                    };
                    students.Add(StudentToAdd);
                    Continue = true;
                }
                else
                {
                    Console.Write("Invalid input, try something else: ");
                }
            }
            

            


        }
    }
}
