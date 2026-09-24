using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kt7
{
    public class InvalidAccountException : BankingException
    {
        public string AccountId { get; }

        public InvalidAccountException() : base()
        {
        }

        public InvalidAccountException(string message)
            : base(message)
        {
        }

        public InvalidAccountException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public InvalidAccountException(string accountId, bool isAccountId)
            : base($"В номере счёёта доллжно быть 6 цифр ")
        {
            AccountId = accountId;
        }
    }
}
