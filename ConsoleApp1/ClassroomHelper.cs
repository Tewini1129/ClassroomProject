using ClassroomProject.MenuMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomProject
{
    public class ClassroomHelper
    {
        public static bool Continue = false;
        public static bool Quit = false;
        public static void Menu(List<Student> students, Tool[] Tools)
        {
            Console.Clear();
            Console.WriteLine("=== CLASSROOM ===\n");
            Console.WriteLine("[1] Add student");
            Console.WriteLine("[2] Take attendance");
            Console.WriteLine("[3] Run lecture");
            Console.WriteLine("[4] Show Student roster");
            Console.WriteLine("[5] Show specific student");
            Console.WriteLine("[6] Reset attendance");
            Console.WriteLine("[7] Quit\n");
            Console.WriteLine("=================\n\n");
            Console.Write("Choose your action: ");

            Continue = false;
            while (Continue == false)
            {
                string? userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("=== Add Student ===");
                        AddStudent.Add(students);
                        Continue = true;
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("=== Take Attendance ===");
                        TakeAttendanceMethod.TakeAttendance(students);
                        Continue = true;
                        break;

                    case "3":
                        Console.WriteLine("=== Run Lecture ===");
                        RunLectureMethod.RunLecture(students, Tools);
                        Continue = true;
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("=== Show Student Roster ===");
                        ShowRosterMethod.ShowRoster(students);
                        Continue = true;
                        break;

                    case "5":
                        Console.WriteLine("=== Show Specific Student ===");
                        ShowSpecificStudentMethod.ShowSpecificStudent(students);
                        Continue = true;
                            break;

                    case "6":
                        Console.WriteLine("=== Reset Attendence ===");
                        ResetAttendanceMethod.ResetAttendance(students);
                        Continue = true;
                        break;

                    case "7":
                        Console.WriteLine("Quit");
                        Quit = true;
                        Continue = true;
                        break;

                    default:
                        Console.Write("Invalid choice, try something else: ");
                        break;
                }    
            }

        }


    }
}
