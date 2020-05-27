using Debtor.Core;
using System;

namespace Debtor
{
    class DebtorApp
    {

        public BorrowerManager BorrowerManager { get; set; } = new BorrowerManager();

        public void IntroduceDebtorApp()
        {

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

            BorrowerManager.ListBorrowers();
        }

        public void AskForAction()
        {

        }

    }
}
