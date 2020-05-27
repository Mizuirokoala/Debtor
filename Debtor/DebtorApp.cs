using Debtor.Core;
using System;

namespace Debtor
{
    class DebtorApp
    {

        public BorrowerManager BorrowerManager { get; set; } = new BorrowerManager();

        public void IntroduceDebtorApp()
        {
            Console.WriteLine("Witaj w aplikacji Dłużnik");
        }

        public void AddBorrower()
        {
            Console.WriteLine("Podaj nazwę oraz kwotę dłużnika");

            var userName = Console.ReadLine();

            Console.WriteLine();

            var userAmount = Console.ReadLine();
            var amountInDecimal = default(decimal);



            while (!decimal.TryParse(userAmount, out amountInDecimal))
            {
                Console.WriteLine("Niepoprawne dane");
                Console.WriteLine();
                userAmount = Console.ReadLine();
            }
            BorrowerManager.AddBorrower(userName, amountInDecimal);

        }

        public void DeleteBoorrower()
        {
            Console.WriteLine("Podaj nazwę dłużnika do usunięcia");

            var userName = Console.ReadLine();
            BorrowerManager.DeleteBorrower(userName);

            Console.WriteLine("Powiodło się usuniecie dłużnika");


        }

        public void ListAllBorrowers()
        {
            Console.WriteLine("Lista dłużników");

            foreach (var borrower in BorrowerManager.ListBorrowers())
            {
                Console.WriteLine(borrower);
            }
        }

        public void AskForAction()
        {
            Console.WriteLine("Podaj czynność do wykonania: ");
            var userInput = default(string);

            while (userInput != "exit")
            {
                Console.WriteLine("add - Dodawanie dłużnika");
                Console.WriteLine("del - Usuwanie dłużnika");
                Console.WriteLine("list - Wypisanie listy dłużników");
                Console.WriteLine("exit - Wyjście z programu");

                userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "add":
                        AddBorrower();
                        break;
                    case "del":
                        DeleteBoorrower();
                        break;
                    case "list":
                        ListAllBorrowers();
                        break;

                    default:
                        Console.WriteLine("zła odpowiedź");
                        break;
                }
            }

        }


    }
}
