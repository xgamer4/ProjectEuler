using System;
using System.Collections.Generic;
using System.Linq;

//This file will contain any multi-use functions and other tools
// and the main function (to get the answer to a specific problem, instantiate that class)

//Each problem will be its own file of form 'Prob'*PROBLEM NUMBER*.cs
namespace ProjectEuler
{

	class MainClass
	{

		public static void Main (string[] args)
		{
			new Problem3 ();
		}
	}

	class MathTools
	{
		public MathTools()
		{

		}

		public static List<int> genFib(int maxNumber)
		{
			List<int> fibList = new List<int>();
			int fib1 = 1;
			int fib2 = 2;
			int sum = 0;

			fibList.Add (fib1);
			fibList.Add (fib2);

			while (fib1 + fib2 < maxNumber)
			{
				sum = fib1 + fib2;
				fibList.Add (sum);
				fib1 = fib2;
				fib2 = sum;
			}

			return fibList;

		}


		public static List<long> factor(long numberToFactor, bool onlyPrimes)
		{
			List<long> factors = new List<long> ();
			long sqrt = (long)Math.Floor (Math.Sqrt (numberToFactor));

			List<long> posFactors = new List<long> ();
			for (long i = 2; i <= sqrt; i++)
			{
				posFactors.Add (i);
			}

			foreach (long num in posFactors)
			{
				if (numberToFactor % num == 0)
				{
					factors.Add (num);
					factors.Add (numberToFactor / num);
				}

			}
			factors.Sort ();

			if (onlyPrimes)
			{

				for (int i = 0; i <= factors.Count-1; i++)
				{
					remFactor = factors [i];
					factors.RemoveAll (isFactor);
				}

			}
			return factors;
		}

		public static long remFactor = 2;
		public static bool remSelf = false;

		public static bool isFactor(long n)
		{
			if (n % remFactor == 0)
			{
				if (remSelf && n == remFactor)
				{
					return false;
				}
				else
				{
					return true;
				}
			} 
			else
			{
				return false;
			}
		}
				



	}


}
