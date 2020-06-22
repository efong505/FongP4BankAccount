using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FongP4BankAccount
{
    ///Class that handles the exception handling for the withdrawl overdrafts
    ///<summary>
    ///Inherits the <c>Exception</c> class
    ///Class that handles the overdrawing of the account.
    ///</summary>
    ///<remarks>
    ///<para>
    ///This class inherits from the Exception class but has custom exeption handling
    ///</para>
    ///<para>It is used to handle instances where user may or will overdrarft their account and return "Insufficient
    ///funds" error message. </para>
    ///</remarks>
    class WithrawlExceptionHandle :Exception
    {
        ///<returns>
        ///Returns an "Insufficient Funds" message.
        ///</returns>
        ///<exception cref="WithrawlExceptionHandle"></exception>
        public WithrawlExceptionHandle() :base("Insufficient Funds.")
        {
        }
    }
}
