using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity7_3
{
    public abstract class Account
    {
        private int _accountNumber;

        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public abstract string GetAccountInfo();
    }
    public class CheckingAccount : Account
    {
        public override string GetAccountInfo()
        {
            return "Printing checking account info for account number "
                + AccountNumber.ToString();
        }
    }
    public class SavingsAccount : Account
    {
        public override string GetAccountInfo()
        {
            return "Printing savings account info for account number "
                + AccountNumber.ToString();
        }
    }
}
