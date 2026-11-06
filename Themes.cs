using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_styles
{
    public class Themes
    {
        public string Name { get; set; } = new("Тема");

        
        public int Grade { get; set; } = new();

        public Themes(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }
        public Themes() { } 
    }
}
