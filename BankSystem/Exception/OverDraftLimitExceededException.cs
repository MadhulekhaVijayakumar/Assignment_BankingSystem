using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Exception
{
    
        public class OverDraftLimitExceededException : IOException
        {
            public OverDraftLimitExceededException(string message) : base(message) { }
        }
}
