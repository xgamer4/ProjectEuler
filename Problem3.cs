using System;
using System.Collections.Generic;
using System.Linq;

/* PROBLEM 3
 * https://projecteuler.net/problem=3
 * 
 * The prime factors of 13195 are 5, 7, 13 and 29.
 *
 * What is the largest prime factor of the number 600851475143 ?
*/

//ANSWER: 6857
namespace ProjectEuler
{
	public class Problem3
	{
		public Problem3 ()
		{
			List<long> factors = MathTools.factor (600851475143, true);
			Console.WriteLine (factors [factors.Count - 1]);
		}
	}
}

