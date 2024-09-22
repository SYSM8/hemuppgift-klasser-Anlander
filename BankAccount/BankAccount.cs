namespace BankAccount
{
    public class BankAccount
    {
        string? AccountNumber { get; set; }
        string? AccountHolder { get; set; }
        decimal Saldo { get; set; }

        public BankAccount(string AccountNumber, string AccountHolder, decimal Saldo)
        {
            this.AccountNumber = AccountNumber;
            this.AccountHolder = AccountHolder;
            this.Saldo = Saldo;
        }

        public void GetBankAccountInfo()
        {
            Console.WriteLine($"Holder: {AccountHolder}, AccountNmr: {AccountNumber}, Saldo: {Saldo}");
        }

        public string Deposit(decimal amount)
        {
            return $"Deposited: {amount}, New Balance: {Saldo += amount}";
        }
        public string Withdraw(decimal amount)
        {
            if (amount <= Saldo)
            {
                Saldo -= amount;
                return $"Withdrew: {amount} New Balance: {Saldo}.";
            }
            else
            {
                return "Uttaget kan inte genomföras, otillräckliga medel.";
            }
        }

        public void Balance()
        {
            Console.WriteLine($"Balance: {Saldo}");
        }
    }
}