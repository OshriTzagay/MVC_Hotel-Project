using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam_ExampleForTest_17_01.Models
{
    public class CEO
    {
        public CEO(int id, string name, int age, string email, int budget)
        {
            Id = id;
            Name = name;
            Age = age;
            Email = email;
            Budget = budget;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
        public string Email { get; set; }
        public int Budget { get; set; }
    }
}