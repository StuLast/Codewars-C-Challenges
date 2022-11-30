using System.Linq;
using System;

public class TwoToOneMedler
{

	public static string Longest(string s1, string s2)
	{
		var allLetters = String.Concat(s1.ToLower(), s2.ToLower()).Distinct();
		return new String(allLetters.OrderBy(c => c).ToArray());
	}
}