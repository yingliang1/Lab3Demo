using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Hello();
            s.ShowAge(20);

            Teacher t = new Teacher();
            t.Hello();
            t.Explain();
            //Console.WriteLine("Hello World!");
        }
    }
}
