using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Person
    {
        private int age;
        public void Hello()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge(int n) {
            this.age = n;
        }
        public int getAge()
        {
            return age;
        }

    }
    class Student : Person {
        public void GoToClasses() {
            Console.WriteLine("I’m going to class.");
        }

        public void ShowAge(int age) {
            SetAge(age);
            Console.WriteLine($"My age is: {getAge()} years old");
        }
    }

    class Teacher : Person
    {
        private string subject;
        public void Explain()
        {
            subject = "Explanation begins";
            Console.WriteLine(subject);
        }
    }
}
