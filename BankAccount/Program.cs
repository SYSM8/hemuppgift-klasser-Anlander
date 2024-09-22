namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee(Förnamn: "Philip", Efternamn: "Anlander");
            //employee.GetAnnualSalary();
            //employee.GiveRaise();

            BankAccount bankAccount = new BankAccount(AccountNumber: "123123123", AccountHolder: "Philip", Saldo: 1000);
            bankAccount.GetBankAccountInfo();


            Console.WriteLine($"{bankAccount.Deposit(300)}");
            Console.WriteLine($"{bankAccount.Withdraw(500)}");

            bankAccount.Balance();
        }
    }

}
