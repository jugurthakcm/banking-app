namespace Banking
{
    public class Account
    {
        private string AccountHolder;
        private double Balance;

        // Construct an account (Create it)
        public Account(string name, double amount)
        {
            AccountHolder = name;
            if (amount > 0) Balance = amount;
            else Balance = 0;
        }

        public Account()
        {
            AccountHolder = "";
            Balance = 0;
        }

        //Check Account Status aka Account Holder and Balance
        public void CheckStatus()
        {
            Console.WriteLine($"You are {AccountHolder} and you have {Balance:C}");
        }

        // Make deposit if deposit > 0 and return success message
        public void MakeDeposit(double deposit)
        {
            if (deposit > 0)
            {
                Balance += deposit;
                Console.WriteLine($"Your deposit of {deposit:C} was successful. Your balance is now {Balance:C}");
            }
            else Console.WriteLine("Deposit must superior than 0");
        }

        public void Withdraw(double amount)
        {
            if (Balance < amount) Console.WriteLine($"Error: Your balance is inferior to the amount");
            else
            {
                Balance -= amount;
                Console.WriteLine($"Your withdraw of {amount:C} was successful. Your balance is now {Balance:C}");
            }

        }
    }
}

