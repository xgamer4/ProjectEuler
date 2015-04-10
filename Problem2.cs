using System;
using System.Collections.Generic;
using System.Linq;

/* PROBLEM 2
 * https://projecteuler.net/problem=2
 * 
 * Each new term in the Fibonacci sequence is generated by adding the previous two terms. 
 * By starting with 1 and 2, the first 10 terms will be:

1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
find the sum of the even-valued terms.
*/

//ANSWER: 4613732
namespace ProjectEuler
{
	public class Problem2
	{
		public Problem2 ()
		{
			List<int> fibList = MathTools.genFib (4000000);

			var fibEvenQuery = from num in fibList 
				where num % 2 == 0
					select num;
			Console.WriteLine (fibEvenQuery.Sum ());
		}
	}
}

