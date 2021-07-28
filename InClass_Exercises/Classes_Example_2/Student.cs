using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Example_2
{
    public class Student
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string ClassTaken { get; set; }

        public Student()
        {
            ID = 0;
            Name = string.Empty;
            ClassTaken = string.Empty;
        }

    }
}
