using SOLID.LSP.After;

namespace SOLID.LSP
{
    class Program
    {
        public static void Main(string[] args)
        {
            var account = new FixedDepositAccount("Ahmed",5000);
            account.Deposit(500);
           // account.Withdraw(200); //rejected
            Console.ReadKey();
        
        }
    }
}