using System;
using System.Collections.Generic;
using System.Linq;

/* PROBLEM 4
 * https://projecteuler.net/problem=4
 * 
 * A palindromic number reads the same both ways. 
 * The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
 * 
 * Find the largest palindrome made from the product of two 3-digit numbers.
*/

//Answer: 906609
namespace ProjectEuler
{
	public class Problem4
	{
		public Problem4 ()
		{
			int maxPalindrome = 0;
			for (int i = 999; i >= 100; i--)
			{
				for (int j = 100; j < i; j++)
				{
					int prod = i * j;
					if (isPalindrome (prod))
					{
						if (prod > maxPalindrome)
						{
							maxPalindrome = prod;
					
						}
				
					}
				}
			}

			Console.WriteLine (maxPalindrome);
		}

		private bool isPalindrome(int n)
		{
			string nStr = Convert.ToString (n);
			bool isPalindrome = true;
			int i = 0;
			int j = nStr.Length - 1;
			while (i < j)
			{
				isPalindrome = isPalindrome && (nStr [i] == nStr [j]);
				i++;
				j--;
			}
			return isPalindrome;
		}
	}
	
}

