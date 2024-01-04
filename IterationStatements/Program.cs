namespace IterationStatements
{
	public class Program
	{

        //Write a method that will print to the console all numbers 1000 through -1000
        public static void PrintNumbersFrom1000toMinus1000()
		{
			for (int i = 1000; i >= -1000; i--)
			{
				Console.Write($"{i} ");
			}
			Console.WriteLine();
		}

		//Write a method that will print to the console numbers 3 through 999 by 3 each time
		public static void PrintNumbersByThree()
		{
			for (int i = 3; i <= 999; i += 3)
			{
				Console.Write($"{i} ");
			}
			Console.WriteLine();
		}

		//Write a method to accept two integers as parameterss and check whether they are equal or not
		public static void CheckEquality(int num1, int num2)
		{
			if (num1 == num2)
			{
				Console.WriteLine("The two numbers are equal.");
			}
			else
			{
				Console.WriteLine("The two numbers are not equal.");
			}
		}

		//Write a method to check whether a given number is even or odd
		public static void CheckEvenOrOdd(int number)
		{
			if (number % 2 == 0)
			{
				Console.WriteLine($"{number} is even.");
			}
			else
			{
				Console.WriteLine($"{number} is odd.");
			}
		}

		//Write a method to check whether a given number is positive or negative
		public static void CheckPositiveOrNegative(int number)
		{
			if (number > 0)
			{
				Console.WriteLine($"{number} is positive.");
			}
			else if (number < 0)
			{
				Console.WriteLine($"{number} is negative.");
			}
			else
			{
				Console.WriteLine($"{number} is zero.");
			}
		}

		//Write a method to read the age of a candidate and determine whether they can vote.
		//Hint: Use Parse or the safer TryParse() for an extra challenge
		//Parse()
		//TryParse()
		public static void CheckVotingEligibility()
		{
			Console.WriteLine("Enter your age:");
			if (int.TryParse(Console.ReadLine(), out int age))
			{
				if (age >= 18)
				{
					Console.WriteLine("You may vote!");
				}
				else
				{
					Console.WriteLine("Looks like you're too young this time!");
				}
			}
			else
			{
				Console.WriteLine("Invalid input. Please enter a valid integer for age.");
			}
		}

        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void CheckInRange()
        {
            Console.WriteLine("Enter an integer:");
            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                if (userInput >= -10 && userInput <= 10)
                {
                    Console.WriteLine($"{userInput} is in the range -10 to 10.");
                }
                else
                {
                    Console.WriteLine($"{userInput} is outside the range -10 to 10.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void DisplayMultiplicationTable()
        {
            Console.WriteLine("Enter an integer to display its multiplication table.");
            if (int.TryParse(Console.ReadLine(), out int multiplier))
            {
                Console.WriteLine($"Multiplication table for {multiplier}:");
                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine($"{multiplier} x {i} = {multiplier * i}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        // Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
			Console.WriteLine("LukeWarm Section:");
			Console.WriteLine("1.");
            PrintNumbersFrom1000toMinus1000();
			Console.WriteLine();

			Console.WriteLine("2.");
            PrintNumbersByThree();
			Console.WriteLine();

			Console.WriteLine("3.");
            CheckEquality(5, 5);
			Console.WriteLine();

			Console.WriteLine("4.");
            CheckEvenOrOdd(7);
			Console.WriteLine();

			Console.WriteLine("5.");
			CheckPositiveOrNegative(-3);
			Console.WriteLine();

			Console.WriteLine("6.");
			CheckVotingEligibility();
			Console.WriteLine();

			Console.WriteLine("Heatin Up Section:");
			Console.WriteLine("1.");
			CheckInRange();
            Console.WriteLine();

			Console.WriteLine("2.");
			DisplayMultiplicationTable();
        }
    }
}
