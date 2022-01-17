using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam_ExampleForTest_17_01.Models
{
    public class Guest
    {
        public Guest(int id, string firstName, string lastName, string gender, int birthday, int checkedIn)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Birthday = birthday;
            CheckedIn = checkedIn;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public int Birthday { get; set; }

        public int CheckedIn { get; set; }

        public Guest() { }
    }
}