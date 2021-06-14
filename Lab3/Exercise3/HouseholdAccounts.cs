using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
   
    class HouseholdAccounts
    {
        public int Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Amount { get; set; }

        public void AddNewExpense()
        {
            Console.Write("Enter your expense date => ");
            Date = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your expense description => ");
            Description = Console.ReadLine();

            Console.Write("Enter Department => ");
            Category = Console.ReadLine();

            Console.Write("Enter Email Id => ");
            Amount = Convert.ToInt32(Console.ReadLine());
        }
    }
}
