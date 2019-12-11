using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace January2020Exam
{
    //declare positions as enum
    public enum Position { GoalKeeper, Defender, Midfielder, Forward }

    class Player : IComparable
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public Position PreferredPosition { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
    
    }
}
