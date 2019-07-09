using ExFixacao11TryCatch.Entities.Exceptions;

namespace ExFixacao11TryCatch.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Name { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {

        }

        public Account(int number, string name, double balance, double withdrawLimit)
        {
            Number = number;
            Name = name;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposito(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }

            Balance -= amount;
        }
    }
}
