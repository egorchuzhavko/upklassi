using System;
using System.Collections.Generic;
using System.Text;

namespace obwee
{
    class Person
    {
        private string fullName;
        private int age;

        public void SetName(string fullname)
        {
            this.fullName = fullname;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }

        public Person()
        {
            fullName = "anonimous";
            age = 18; ;
        }
        public Person(string fullName, int age)
        {
            this.fullName = fullName;
            this.age = age;
        }

        public string Talk() { return $"Говорит {fullName}"; }
        public string Move() { return $"{fullName} - {age} лет."; }
    }
}
