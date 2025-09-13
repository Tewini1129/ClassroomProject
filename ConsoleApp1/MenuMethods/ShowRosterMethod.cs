using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomProject.MenuMethods
{
    public class ShowRosterMethod
    {
        public static void ShowRoster(List<Student> students)
        {
            foreach (Student s in students)
            {
                Console.WriteLine($"\nName: {s.Name}\tPrograming level: {s.ProgramingLevel}\tIs present: {s.IsPresent}\n");
                
            }
            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();
        }

    }
}
