using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomProject.MenuMethods
{
    public class ShowSpecificStudentMethod
    {
        public static bool Continue = false;
        public static bool found = false;
        public static void ShowSpecificStudent(List<Student> students)
        {
            Continue = false;

            Console.WriteLine("Please enter the name of the student you would like to see:");

            while(Continue == false)
            {
                string? chosenStudent = Console.ReadLine();
                
                foreach(Student s in students)
                {
                    if(chosenStudent.ToLower() == s.Name.ToLower())
                    {
                        found = true;
                        Continue = true;
                        Console.WriteLine($"\nName: {s.Name}\nPrograming level: {s.ProgramingLevel}\nIs present: {s.IsPresent}\n");
                        foreach(Tool t in s.KnownTools)
                        {
                            Console.WriteLine($"Name: {t.Name}\nDifficulty: {t.Difficulty}\nDescription: {t.Description}");
                        }
                        Console.WriteLine($"\n\nPress any button to continue");
                        Console.ReadKey();
                    }
                    else if (chosenStudent.ToLower() == "leave")
                    {
                        found = true;
                        Continue = true;
                    }
                    
                }
                if (found == false)
                {
                    Console.WriteLine("Sorry, we could not find the student you were looking for\nTry again or enter \"Leave\":");
                }
                
            }


        }
    }
}
