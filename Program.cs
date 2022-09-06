namespace PrimeFactorFinder
{
	internal class Program
	{
		static void Main(string[] args)
		{
			long targetVal = 0;
			List<long> primeFactors = new List<long>(); //Initalize a dynamic List of type int to hold the variable number of prime factors

			//Get the Target Number for the solver
			Console.WriteLine("What number are you interested in finding the largest prime factor of? ");
			targetVal = Convert.ToInt64(Console.ReadLine());

			//Load the Prime Factors List

			static bool IsPrime(long number)
			{
				if (number <= 1) return false;
				if (number == 2) return true;
				if (number % 2 == 0) return false;

				var boundary = (int)Math.Floor(Math.Sqrt(number));

				for (long i = 3; i <= boundary; i += 2)
					if (number % i == 0)
						return false;

				return true;
			}

			for (long i = 2; i <= Math.Sqrt(targetVal); ++i)
			{
				if (targetVal % i == 0)  //If the TargetVal is evenly divisible by the current number...
				{
					if (IsPrime(i)) //...and it's a prime number...
					{
						primeFactors.Add(i);    //...add it to the list.
					}
				}
			}

			//Program Output
			Console.WriteLine("The Prime Factors of " + targetVal + " are:");
			foreach (int num in primeFactors)
				Console.WriteLine(num);
			Console.WriteLine("The largest prime factor of " + targetVal + " is: " + primeFactors.Last());
		}
	}
}