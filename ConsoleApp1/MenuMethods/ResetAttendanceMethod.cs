using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomProject.MenuMethods
{
    public class ResetAttendanceMethod
    {
        public static void ResetAttendance(List<Student> students)
        {
            foreach(Student s in students)
            {
                s.IsPresent = false;
                
            }
            Console.WriteLine("Attendance is now reset\nPress any button to continue:");
            Console.ReadKey();
        }
    }
}
