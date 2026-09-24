using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kt7
{
    public class BankAccount
    {
        public string AccountId { get; }
        public decimal Balance { get; private set; }

        public BankAccount(string accountId, decimal initialBalance)
        {
            if (!IsValidAccountId(accountId))
            {
                throw new InvalidAccountException(accountId, true);
            }

            AccountId = accountId;
            Balance = initialBalance;
        }

        private static bool IsValidAccountId(string accountId)
        {
            if (accountId == null || accountId.Length != 6)
            {
                return false;
            }

            foreach (char c in accountId)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }

            return true;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new InsufficientFundsException(
                    amount,
                    Balance);
            }

            Balance -= amount;
        }
    }
}
