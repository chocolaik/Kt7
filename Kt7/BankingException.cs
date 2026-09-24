using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kt7
{
    public class BankingException : Exception
    {
        public BankingException() : base()
        {
        }

        public BankingException(string message) : base(message)
        {
        }

        public BankingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

}
