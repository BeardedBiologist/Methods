using System;
namespace Methods
{
	public static class ConsoleMessages
    {
		public static void SayHi(string firstName)
		{
			Console.WriteLine($"Hello {firstName}!");
		}

        public static string GetUsersName()
        {
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            return name;
        }

        public static void SayGoodybe()
        {
            Console.WriteLine("Goodbye User!");
        }
    }

}

