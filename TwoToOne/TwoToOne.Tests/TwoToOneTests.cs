namespace TwoToOne.Tests
{
	public class TwoToOneTests
	{

		[Theory]
		[InlineData("aretheyhere", "yestheyarehere", "aehrsty")]
		[InlineData( "loopingisfunbutdangerous", "lessdangerousthancoding", "abcdefghilnoprstu")]
		[InlineData("inmanylanguages", "theresapairoffunctions", "acefghilmnoprstuy")]
		public void should_return_ordered_unique_letters_from_merged_arrays_of_type_string(string s1, string s2, string expected)
		{
			var result = TwoToOneMedler.Longest(s1, s2);
			result.ShouldBe(expected);
		}
	}
}
