using System.Security.Cryptography.X509Certificates;

namespace ClassroomProject
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Tool[] Tools = new Tool[]
            {
                new Tool { Name = "C#", Difficulty = 5, Description = "BasicPrograming"},
                new Tool { Name = "Git", Difficulty = 5, Description = "Source Control"},
                new Tool { Name = "Debugging", Difficulty = 5, Description = "Solve problem"},
                new Tool { Name = "Javacript", Difficulty = 10, Description = "Poop"},
            };



            List<Student> students = new List<Student>()
            {
                new Student {Name = "William", ProgramingLevel = 0, IsPresent = false},
            };

            


            while (ClassroomHelper.Quit == false)
            {
                ClassroomHelper.Menu(students, Tools);
            }



        }
    }
}
