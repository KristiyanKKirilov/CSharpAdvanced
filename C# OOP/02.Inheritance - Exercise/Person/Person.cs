﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual int Age
        {
            get { return age; }
            set
            {
                if (age >= 0)
                {
                    age = value;
                }
            }
        }
        public override string ToString() => $"Name: {Name}, Age: {Age}";

    }
}