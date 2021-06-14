using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        public class Expense
        {
            public int Date { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            public int Amount { get; set; }

            public override string ToString()
            {
                return Date + "\t" + Description + "\t" + Category + "\t" + Amount;
            }
        }
        static void Main(string[] args)
        {
            static List<Expense> ShowExpense()
            {
                return new List<Expense>
              {
                new Expense { Date = 20110101, Description = "Food", Category = "Small", Amount = 100 },
                new Expense { Date = 20111231, Description = "Cloths", Category = "Small", Amount = 100 },
                new Expense { Date = 20110101, Description = "Furniture", Category = "Large", Amount = 1000  }
              };
            }
            Menu m = new Menu();
            int option = 3;
            do
            {
                Console.Clear();
                option = m.Print();
                switch (option)
                {
                    case (int)Options.AddNewExpense:
                        HouseholdAccounts a = new HouseholdAccounts();
                        a.AddNewExpense();
                        break;
                    case (int)Options.ShowExpenses:
                        ShowExpense();
                        break;
                    case (int)Options.SearchCosts:
                        Console.WriteLine("Thanks for Visit");
                        break;
                    case (int)Options.ModifyExpense:
                        Console.WriteLine("Thanks for Visit");
                        break;
                     case (int)Options.DeleteExpense:
                        Console.WriteLine("Thanks for Visit");
                        break;
                    case (int)Options.Exit:
                        break;
                    default:
                        Console.WriteLine("Invalid Option !!!!!");
                        break;
                }

                Console.WriteLine("Press Enter to Continue.......");
                Console.ReadLine();


            } while (option != (int)Options.Exit);
        }

    }
}
