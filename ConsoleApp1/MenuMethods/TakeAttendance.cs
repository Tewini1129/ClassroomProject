using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomProject.MenuMethods
{
    public class TakeAttendanceMethod
    {
        public static int PresentStudents = 0;
        public static void TakeAttendance(List<Student> students)
        {
            for(int i = 0; i <= students.Count-1; i++)
            {
                ClassroomHelper.Continue = false;


                Console.WriteLine($"\nIs {students[i].Name} present? Yes/No");

                while (ClassroomHelper.Continue == false)
                {
                    string? answere = Console.ReadLine();

                    if(answere!.ToLower() == "yes")
                    {
                        students[i].IsPresent = true;
                        PresentStudents++;
                        ClassroomHelper.Continue = true;
                    }
                    else if(answere!.ToLower() == "no")
                    {
                        ClassroomHelper.Continue = true;
                    }
                    else
                    {
                        Console.Write("Invalid answere, try again: ");
                    }
                }





            }
        }
    }
}
