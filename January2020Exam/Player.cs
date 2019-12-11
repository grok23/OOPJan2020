using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace January2020Exam
{
    //declare positions as enum
    public enum Position { Goalkeeper, Defender, Midfielder, Forward }

    class Player //: IComparable  //add later to allow sorting of players
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
        
        //constructors
        public Player()  //base constructor
        {

        }
        public Player(string firstName, string surname, DateTime DoB, Position prefPosition )  //base constructor
        {
            FirstName = firstName;
            Surname = Surname;
            DateOfBirth = DoB;
            PreferredPosition = prefPosition;
        }






        //overrride of ToString to output player name, age and position
        public override string ToString()
        {
            return $"{FirstName} {Surname} ({Age}){PreferredPosition}";
        }
    }
}
