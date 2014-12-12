using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity7_3
{
    public interface IAccount
    {
        string GetAccountInfo();
       /* private int _accountNumber;

        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public abstract string GetAccountInfo();*/
    }
    public class CheckingAccount : IAccount
    {
        private int _accountNumber;

        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        
        public string GetAccountInfo()
        {
            return "Printing checking account info for account number "
                + AccountNumber.ToString();
        }
    }
    //all the following errors are in this last segment.
    public class SavingsAccount : IAccount
    {
        private int _accountNumber;

        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        public string GetAccountInfo()
        {
            return "Printing savings account info for account number "
             + AccountNumber.ToString();
        }
    }
}
