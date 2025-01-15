using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SOLID.SRP.After
{
    internal class AccountService
    {

        public void Withdrow(decimal amount,Account account) // amount +/-
        {
            var transactionMessage = "";

            if (account.Balance < Math.Abs(amount))
            {
                transactionMessage =
                $"OVERDRAFT when trying to withdraw " +
                $"{Math.Abs(amount).ToString("C2")}," +
                $" current balance {account.Balance.ToString("C2")}";
            }
            else
            {
                account.Balance -= amount;
                transactionMessage =
                   $"OK Withdraw {Math.Abs(amount).ToString("C2")}" +
                   $", current balance {account.Balance.ToString("C2")}";
            }

            EmailClient emailClient = new EmailClient();
            emailClient.Display(transactionMessage, account, DateTime.Now);
        }


        public void Deposit(decimal amount,Account account) // amount +/-
        {
            var transactionMessage = "";

                    account.Balance += amount;

                    transactionMessage =
                        $"OK Deposit {amount.ToString("C2")}" +
                        $", current balance {account.Balance.ToString("C2")}";
           
            EmailClient emailClient = new EmailClient();
            emailClient.Display(transactionMessage, account, DateTime.Now);
        }

       
    }
}
