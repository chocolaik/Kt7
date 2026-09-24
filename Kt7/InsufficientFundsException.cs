using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kt7
{
    public class InsufficientFundsException : BankingException
    {
        public decimal RequestedAmount { get; }
        public decimal AvailableBalance { get; }

        public InsufficientFundsException() : base()
        {
        }

        public InsufficientFundsException(string message)
            : base(message)
        {
        }

        public InsufficientFundsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public InsufficientFundsException(
            decimal requestedAmount,
            decimal availableBalance)
            : base(
                $"Недостаточно средств. " +
                $"Запрошенно == {requestedAmount}, " +
                $"Имеется == {availableBalance}.")
        {
            RequestedAmount = requestedAmount;
            AvailableBalance = availableBalance;
        }
    }
}
