using System;
using System.Collections.Generic;
using System.Linq;

/* PROBLEM 1
 * https://projecteuler.net/problem=1
 * 
 * 

If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.
*/

//ANSWER: 233168
namespace ProjectEuler
{
	public class Problem1
	{
		public Problem1 ()
		{
			IEnumerable<int> numbers = Enumerable.Range (1, 999);
			var extractMultiplesQuery = from num in numbers 
				where num % 3 == 0
				|| num % 5 == 0
					select num;

			Console.WriteLine (extractMultiplesQuery.Sum ());

		}
	}
}

