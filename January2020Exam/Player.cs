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
        private int _age;
        public int Age
        {
            get
            {
                _age = DateTime.Now.Year - DateOfBirth.Year;
                if (DateOfBirth.DayOfYear > DateTime.Now.DayOfYear)
                    _age--;
                return _age;
            }
        }

    }
}
