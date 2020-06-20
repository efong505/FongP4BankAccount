using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FongP4BankAccount
{
    class WithrawlExceptionHandle:Exception
    {
        public WithrawlExceptionHandle() :base("Insufficient Funds.")
        {
        }
    }
}
