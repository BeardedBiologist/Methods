using System;
namespace Methods
{
	public static class ConsoleMessages
    {
		public static void SayHi(string firstName)
		{
			Console.WriteLine($"Hello {firstName}!");
		}

        // TUPLE
        public static (string, string) GetFullName()
        {
            Console.Write("What is your first name?: ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name?: ");
            string lastName = Console.ReadLine();

            return (firstName, lastName);
        }

        public static void SayGoodybe()
        {
            Console.WriteLine("Goodbye User!");
        }
    }

}

