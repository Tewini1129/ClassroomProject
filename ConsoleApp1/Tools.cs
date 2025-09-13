using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomProject
{
    public class Tool
    {
        public string Name;
        public int Difficulty;
        public string Description;


        public Tool(string name, int difficulty, string description)
        {
            Name = name;
            Difficulty = difficulty;
            Description = description;
            
        }
        public Tool()
        {

        }
    }
}
