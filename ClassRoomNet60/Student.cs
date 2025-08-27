using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {
        private int _birthdayMonth;
        private int _birthDay;

        public string Name { get; private set; }

        public int BirthDay
        {
            get { return _birthDay; }

            private set
            {
                if (_birthdayMonth < 1) throw new Exception("The month must be set beforehand.");
                if (value < 0) throw new ArgumentException("Days need to have a positive whole numerical value.");
                if(value > 32) throw new ArgumentException("There are no months with more than 31 days.");
                if (_birthdayMonth == 2 && value > 29) throw new ArgumentException("February has at most 29 days. 29 days is already unlikely.");
                if(_birthdayMonth%2 == 0 && value > 30) throw new ArgumentException("This month has at most 30 days.");
                if(_birthdayMonth%2 == 1 && value > 31) throw new ArgumentException("This month has at most 31 days.");
                _birthDay = value;
            }
        }

        public int BirthdayMonth
        {
            get { return _birthdayMonth;}

            private set
            {
                if(value < 13 && value > 0)
                {
                    _birthdayMonth = value;
                    return;
                }
                if(value < 1) throw new ArgumentException("Months need to have a positive whole numerical value.");
                throw new ArgumentException("There are only 12 months in a year.");
            }
        }

        public Student(string name, int birthdayMonth, int birthDay)
        {
            Name = name;
            BirthdayMonth = birthdayMonth;
            BirthDay = birthDay;
        }


    }
}
