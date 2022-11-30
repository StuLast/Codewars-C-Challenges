
namespace SumOfDigits.Test
{
	public class SumOfDigitsTests
	{
		private DigitalRoot _digitalRoot;
		public SumOfDigitsTests()
		{
			_digitalRoot = new DigitalRoot();
		}

		[Theory]
		[InlineData(5, 5)]
		[InlineData(11, 2)]
		[InlineData(16, 7)]
		[InlineData(942, 6)]
		[InlineData(132189, 6)]
		[InlineData(493193, 2)]
		public void Should_Sum_Digits_Of_Any_Number_To_Singular_Integer(int value, int expected)
		{
			var digitalRoot = _digitalRoot.SumDigits(value);
			digitalRoot.ShouldBe(expected);
		}
	}
}
