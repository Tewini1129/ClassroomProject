using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomProject.MenuMethods
{
    public class RunLectureMethod
    {
        public static bool Continue = false;
        public static Tool selectedTool;
        public static void RunLecture(List<Student> students, Tool[] Tools)
        {
            if(TakeAttendanceMethod.PresentStudents == 0)
            {
                return;
            }
            else
            {
                for (int i = 0; i <= (Tools.Length-1); i++)
                {
                    Console.WriteLine($"[{i+1}] Name: {Tools[i].Name}\tDifficulty: {Tools[i].Difficulty}\tDescription: {Tools[i].Description}\n");
                }
                Console.Write("Please enter which subject you want to teach: ");
                Continue = false;
                while(Continue == false)
                {
                    string? answer = Console.ReadLine();

                    switch (answer)
                    {
                        case "1":
                            Continue = true;
                            selectedTool = Tools[0];
                            break;

                        case "2":
                            Continue = true;
                            selectedTool = Tools[1];

                            break;

                        case "3":
                            Continue = true;
                            selectedTool = Tools[2];

                            break;

                        case "4":
                            Continue = true;
                            selectedTool = Tools[3];

                            break;

                        default:
                            Console.Write("Invalid answer, try again: ");
                            break;
                    }
                }

                for(int i = 0; i <= (students.Count-1); i++)
                {
                    if (students[i].IsPresent )
                    {
                        students[i].LearnTool(selectedTool);
                    }
                }

                

                Console.WriteLine($"\n\nLesson has been taught, {TakeAttendanceMethod.PresentStudents} was present and learned");
                Console.WriteLine("Press any butoon to continue");
                Console.ReadKey();
            }
        }
    }
}
