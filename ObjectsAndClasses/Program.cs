using System;

namespace CSharp101
{
	class Program
	{
		static void Main(string[] args)
		{
			var account = new BankAccount("Adam", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");
        }
	}
}