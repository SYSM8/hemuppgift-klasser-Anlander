namespace BankAccount
{
    public class Employee
    {
        string? Förnamn { get; set; }
        string? Efternamn { get; set; }
        double Lön = 200000;

        public Employee(string Förnamn, string Efternamn)
        {
            this.Förnamn = Förnamn;
            this.Efternamn = Efternamn;
        }



        public void GetAnnualSalary()
        {
            Console.WriteLine($"Annual salary {Lön}");

        }

        public void GiveRaise()
        {
            double raise = 10;

            if (raise > 0)
            {
                Lön += Lön * (raise / 100);
            }

            Console.WriteLine($"New monthly salary {Math.Round(Lön / 12)}");
            Console.WriteLine($"New annual salary {Lön}");
        }



    }
}
