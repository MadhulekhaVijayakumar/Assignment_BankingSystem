using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Exception
{
    public class InvalidAccountException : IOException
    {
        public InvalidAccountException(string message) : base(message) { }
    }
}
