using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
	public class DigitalRoot
	{
		public int SumDigits(int num)
		{
			var numArray = num.ToString().ToCharArray();
			var result = numArray.Sum(c => Int32.Parse(c.ToString()));

			if ( result > 9)
			{
				return SumDigits(result);
			}
			return result;
		}
	}
}
