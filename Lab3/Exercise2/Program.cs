﻿using System;

namespace Exercise2
{
    class Program
    {
        static void Main()
        {
            bool debug = true;

            SmallApartment mySmallApartament = new SmallApartment();
            Person myPerson = new Person();

            myPerson.Name = "Kishore";
            myPerson.House = mySmallApartament;
            myPerson.ShowData();

            if (debug)
                Console.ReadLine();
        }
    }
}
