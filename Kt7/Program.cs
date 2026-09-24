using System;
using System.Collections.Generic;
using System.Text;

namespace Kt7
{
    class Program
    {
        static void Main()
        {

            Console.OutputEncoding = Encoding.UTF8;
            var operations = new List<Action>
            {
                () =>
                {
                    var account = new BankAccount("12345", 1000m);
                },

                () =>
                {
                    var account = new BankAccount("123456", 1000m);
                    account.Withdraw(2000m);
                },

                () =>
                {
                    var account = new BankAccount("123456", 1000m);
                    account.Withdraw(500m);

                    Console.WriteLine(
                        $"\r\nбаланс становится {account.Balance}, исключений нет");
                },
            };

            foreach (var operation in operations)
            {
                try
                {
                    operation();
                }
                catch (InsufficientFundsException ex)
                {
                    Console.WriteLine(
                        "InsufficientFundsException");

                    Console.WriteLine(
                        $"Запрошено: {ex.RequestedAmount}");

                    Console.WriteLine(
                        $"Доступно: {ex.AvailableBalance}");
                }
                catch (InvalidAccountException ex)
                {
                    Console.WriteLine(
                        "InvalidAccountException");

                    Console.WriteLine(
                        $"Номер счёта: {ex.AccountId}");

                    Console.WriteLine(ex.Message);
                }
                catch (BankingException ex)
                {
                    Console.WriteLine(
                        "Общая банковская ошибка.");

                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine();
            }
        }
    }
}