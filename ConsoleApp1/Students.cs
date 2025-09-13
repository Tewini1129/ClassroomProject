using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomProject
{
    public class Student
    {
        public string Name;
        public int ProgramingLevel;
        public bool IsPresent = false;
        public List<Tool> KnownTools = new List<Tool>();

        public Student()
        {
            

        }
        


        public void LearnTool(Tool selectedTool)
        {
            bool alreadyKnow = false;
            foreach(Tool CheckForTool in KnownTools)
            {
                if(CheckForTool == selectedTool)
                {
                    alreadyKnow = true;
                    break;
                }
                
            }
            if(alreadyKnow!)
            {
                KnownTools.Add(selectedTool);
                ProgramingLevel += selectedTool.Difficulty;

            }
        }

    }
}
