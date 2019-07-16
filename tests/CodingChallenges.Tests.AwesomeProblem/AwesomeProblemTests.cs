using System;
using System.IO;
using Xunit;

namespace CodingChallenges.Tests.AwesomeProblem
{
	public class AwesomeProblemTests
	{
		[Fact]
		public void Test1()
		{
			var input = "000100001" + Environment.NewLine
+ "100000000" + Environment.NewLine
+ "100000000" + Environment.NewLine
+ "000010000" + Environment.NewLine
+ "110000100" + Environment.NewLine
+ "100100000" + Environment.NewLine
+ "000000100" + Environment.NewLine
+ "000001000" + Environment.NewLine
+ "000000000";
			var output = new Problems.AwesomeProblem.Solution().Solve(input);
			Assert.Equal("111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "000000000", output);
		}

		[Fact]
		public void Test2()
		{
			var input = "0000010" + Environment.NewLine
+ "0001100" + Environment.NewLine
+ "0100000" + Environment.NewLine
+ "0100010" + Environment.NewLine
+ "0000000" + Environment.NewLine
+ "0000100" + Environment.NewLine
+ "1000011";
			var output = new Problems.AwesomeProblem.Solution().Solve(input);
			Assert.Equal("1111111" + Environment.NewLine
+ "1111111" + Environment.NewLine
+ "1111111" + Environment.NewLine
+ "1111111" + Environment.NewLine
+ "1111111" + Environment.NewLine
+ "1111111" + Environment.NewLine
+ "1111111", output);
		}

		[Fact]
		public void Test3()
		{
			var input = "000010010" + Environment.NewLine
+ "000011010" + Environment.NewLine
+ "001100000" + Environment.NewLine
+ "000000100" + Environment.NewLine
+ "000011000" + Environment.NewLine
+ "001000000" + Environment.NewLine
+ "000010010" + Environment.NewLine
+ "000000000" + Environment.NewLine
+ "000000100";
			var output = new Problems.AwesomeProblem.Solution().Solve(input);
			Assert.Equal("001111110" + Environment.NewLine
+ "001111110" + Environment.NewLine
+ "001111110" + Environment.NewLine
+ "001111110" + Environment.NewLine
+ "001111110" + Environment.NewLine
+ "001111110" + Environment.NewLine
+ "001111110" + Environment.NewLine
+ "001111110" + Environment.NewLine
+ "001111110", output);
		}

		[Fact]
		public void Test4()
		{
			var input = "0000010" + Environment.NewLine
+ "1100000" + Environment.NewLine
+ "0000010" + Environment.NewLine
+ "0000001" + Environment.NewLine
+ "0110000" + Environment.NewLine
+ "0000000" + Environment.NewLine
+ "0001000";
			var output = new Problems.AwesomeProblem.Solution().Solve(input);
			Assert.Equal("0000011" + Environment.NewLine
+ "1100011" + Environment.NewLine
+ "0000011" + Environment.NewLine
+ "0000011" + Environment.NewLine
+ "0110000" + Environment.NewLine
+ "0000000" + Environment.NewLine
+ "0001000", output);
		}

		[Fact]
		public void Test5()
		{
			var input = "000000000" + Environment.NewLine
+ "101000000" + Environment.NewLine
+ "010000010" + Environment.NewLine
+ "010000001" + Environment.NewLine
+ "001000001" + Environment.NewLine
+ "000000010" + Environment.NewLine
+ "010100000" + Environment.NewLine
+ "000100000" + Environment.NewLine
+ "010000000";
			var output = new Problems.AwesomeProblem.Solution().Solve(input);
			Assert.Equal("000000000" + Environment.NewLine
+ "111100000" + Environment.NewLine
+ "111100011" + Environment.NewLine
+ "111100011" + Environment.NewLine
+ "111100011" + Environment.NewLine
+ "111100011" + Environment.NewLine
+ "111100000" + Environment.NewLine
+ "111100000" + Environment.NewLine
+ "111100000", output);
		}

		[Fact]
		public void Test6()
		{
			var input = "11000000" + Environment.NewLine
+ "00100000" + Environment.NewLine
+ "00100000" + Environment.NewLine
+ "01000001" + Environment.NewLine
+ "01000001" + Environment.NewLine
+ "00000000" + Environment.NewLine
+ "00010010" + Environment.NewLine
+ "00001000";
			var output = new Problems.AwesomeProblem.Solution().Solve(input);
			Assert.Equal("11100000" + Environment.NewLine
+ "11100000" + Environment.NewLine
+ "11100000" + Environment.NewLine
+ "11100001" + Environment.NewLine
+ "11100001" + Environment.NewLine
+ "00000000" + Environment.NewLine
+ "00011110" + Environment.NewLine
+ "00011110", output);
		}

		[Fact]
		public void Test7()
		{
			var input = "000000000" + Environment.NewLine
+ "000000100" + Environment.NewLine
+ "001001100" + Environment.NewLine
+ "100000000" + Environment.NewLine
+ "011010000" + Environment.NewLine
+ "100000001" + Environment.NewLine
+ "000000010" + Environment.NewLine
+ "000000001" + Environment.NewLine
+ "001000100";
			var output = new Problems.AwesomeProblem.Solution().Solve(input);
			Assert.Equal("000000000" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111", output);
		}

		[Fact]
		public void Test8()
		{
			var input = "00010000" + Environment.NewLine
+ "00000000" + Environment.NewLine
+ "10000001" + Environment.NewLine
+ "00000010" + Environment.NewLine
+ "00000000" + Environment.NewLine
+ "00000000" + Environment.NewLine
+ "01000000" + Environment.NewLine
+ "00100000";
			var output = new Problems.AwesomeProblem.Solution().Solve(input);
			Assert.Equal("00010000" + Environment.NewLine
+ "00000000" + Environment.NewLine
+ "10000011" + Environment.NewLine
+ "00000011" + Environment.NewLine
+ "00000000" + Environment.NewLine
+ "00000000" + Environment.NewLine
+ "01100000" + Environment.NewLine
+ "01100000", output);
		}

		[Fact]
		public void Test9()
		{
			var input = "011000001" + Environment.NewLine
+ "000000100" + Environment.NewLine
+ "000100000" + Environment.NewLine
+ "000000000" + Environment.NewLine
+ "000000000" + Environment.NewLine
+ "000111000" + Environment.NewLine
+ "000000000" + Environment.NewLine
+ "000000111" + Environment.NewLine
+ "100000001";
			var output = new Problems.AwesomeProblem.Solution().Solve(input);
			Assert.Equal("011000001" + Environment.NewLine
+ "000000100" + Environment.NewLine
+ "000100000" + Environment.NewLine
+ "000000000" + Environment.NewLine
+ "000000000" + Environment.NewLine
+ "000111000" + Environment.NewLine
+ "000000000" + Environment.NewLine
+ "000000111" + Environment.NewLine
+ "100000111", output);
		}

		[Fact]
		public void Test10()
		{
			var input = "00010000" + Environment.NewLine
+ "00000100" + Environment.NewLine
+ "00000000" + Environment.NewLine
+ "10101000" + Environment.NewLine
+ "10000000" + Environment.NewLine
+ "11100100" + Environment.NewLine
+ "00001010" + Environment.NewLine
+ "00000000";
			var output = new Problems.AwesomeProblem.Solution().Solve(input);
			Assert.Equal("11111110" + Environment.NewLine
+ "11111110" + Environment.NewLine
+ "11111110" + Environment.NewLine
+ "11111110" + Environment.NewLine
+ "11111110" + Environment.NewLine
+ "11111110" + Environment.NewLine
+ "11111110" + Environment.NewLine
+ "00000000", output);
		}

		[Fact]
		public void Test11()
		{
			var input = "000011010" + Environment.NewLine
+ "010001000" + Environment.NewLine
+ "001000000" + Environment.NewLine
+ "100011001" + Environment.NewLine
+ "000000000" + Environment.NewLine
+ "000001000" + Environment.NewLine
+ "001000000" + Environment.NewLine
+ "000100000" + Environment.NewLine
+ "100011010";
			var output = new Problems.AwesomeProblem.Solution().Solve(input);
			Assert.Equal("111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111", output);
		}

		[Fact]
		public void Test12()
		{
			var input = "00000001" + Environment.NewLine
+ "11000000" + Environment.NewLine
+ "00010000" + Environment.NewLine
+ "01000110" + Environment.NewLine
+ "10100110" + Environment.NewLine
+ "00000001" + Environment.NewLine
+ "00000100" + Environment.NewLine
+ "00001110";
			var output = new Problems.AwesomeProblem.Solution().Solve(input);
			Assert.Equal("11111111" + Environment.NewLine
+ "11111111" + Environment.NewLine
+ "11111111" + Environment.NewLine
+ "11111111" + Environment.NewLine
+ "11111111" + Environment.NewLine
+ "11111111" + Environment.NewLine
+ "11111111" + Environment.NewLine
+ "11111111", output);
		}

		[Fact]
		public void Test13()
		{
			var input = "100001000" + Environment.NewLine
+ "000010000" + Environment.NewLine
+ "000010110" + Environment.NewLine
+ "000001010" + Environment.NewLine
+ "010000011" + Environment.NewLine
+ "001000100" + Environment.NewLine
+ "110110000" + Environment.NewLine
+ "000000010" + Environment.NewLine
+ "111010000";
			var output = new Problems.AwesomeProblem.Solution().Solve(input);
			Assert.Equal("111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111" + Environment.NewLine
+ "111111111", output);
		}

		[Fact]
		public void Test14()
		{
			var input = "00100000" + Environment.NewLine
+ "00001001" + Environment.NewLine
+ "00100000" + Environment.NewLine
+ "00000000" + Environment.NewLine
+ "10101010" + Environment.NewLine
+ "10001000" + Environment.NewLine
+ "00000000" + Environment.NewLine
+ "11000000";
			var output = new Problems.AwesomeProblem.Solution().Solve(input);
			Assert.Equal("11111111" + Environment.NewLine
+ "11111111" + Environment.NewLine
+ "11111111" + Environment.NewLine
+ "11111111" + Environment.NewLine
+ "11111111" + Environment.NewLine
+ "11111111" + Environment.NewLine
+ "11111111" + Environment.NewLine
+ "11111111", output);
		}

		[Fact]
		public void Test15()
		{
			var input = "0000000" + Environment.NewLine
+ "0001100" + Environment.NewLine
+ "0000001" + Environment.NewLine
+ "1000010" + Environment.NewLine
+ "1100101" + Environment.NewLine
+ "0000100" + Environment.NewLine
+ "0100000";
			var output = new Problems.AwesomeProblem.Solution().Solve(input);
			Assert.Equal("0000000" + Environment.NewLine
+ "1111111" + Environment.NewLine
+ "1111111" + Environment.NewLine
+ "1111111" + Environment.NewLine
+ "1111111" + Environment.NewLine
+ "1111111" + Environment.NewLine
+ "1111111", output);
		}

		[Fact]
		public void Test16()
		{
			var input = "11000000" + Environment.NewLine
+ "01001010" + Environment.NewLine
+ "10000010" + Environment.NewLine
+ "00000001" + Environment.NewLine
+ "10000000" + Environment.NewLine
+ "00000000" + Environment.NewLine
+ "10000000" + Environment.NewLine
+ "00000100";
			var output = new Problems.AwesomeProblem.Solution().Solve(input);
			Assert.Equal("11000000" + Environment.NewLine
+ "11001111" + Environment.NewLine
+ "11001111" + Environment.NewLine
+ "11001111" + Environment.NewLine
+ "11000000" + Environment.NewLine
+ "11000000" + Environment.NewLine
+ "11000000" + Environment.NewLine
+ "00000100", output);
		}

		[Fact]
		public void Test17()
		{
			var input = "0000000" + Environment.NewLine
+ "0000000" + Environment.NewLine
+ "0000000" + Environment.NewLine
+ "0010000" + Environment.NewLine
+ "0000110" + Environment.NewLine
+ "1100001" + Environment.NewLine
+ "0100001";
			var output = new Problems.AwesomeProblem.Solution().Solve(input);
			Assert.Equal("0000000" + Environment.NewLine
+ "0000000" + Environment.NewLine
+ "0000000" + Environment.NewLine
+ "0010000" + Environment.NewLine
+ "0000111" + Environment.NewLine
+ "1100111" + Environment.NewLine
+ "1100111", output);
		}

		[Fact]
		public void Test18()
		{
			var input = "00000000" + Environment.NewLine
+ "00011000" + Environment.NewLine
+ "00000001" + Environment.NewLine
+ "00110000" + Environment.NewLine
+ "00000100" + Environment.NewLine
+ "00000000" + Environment.NewLine
+ "01100000" + Environment.NewLine
+ "00001010";
			var output = new Problems.AwesomeProblem.Solution().Solve(input);
			Assert.Equal("00000000" + Environment.NewLine
+ "01111111" + Environment.NewLine
+ "01111111" + Environment.NewLine
+ "01111111" + Environment.NewLine
+ "01111111" + Environment.NewLine
+ "01111111" + Environment.NewLine
+ "01111111" + Environment.NewLine
+ "01111111", output);
		}

		[Fact]
		public void Test19()
		{
			var input = "0101100" + Environment.NewLine
+ "1000000" + Environment.NewLine
+ "1000111" + Environment.NewLine
+ "0100000" + Environment.NewLine
+ "0000000" + Environment.NewLine
+ "0000100" + Environment.NewLine
+ "1100000";
			var output = new Problems.AwesomeProblem.Solution().Solve(input);
			Assert.Equal("1111111" + Environment.NewLine
+ "1111111" + Environment.NewLine
+ "1111111" + Environment.NewLine
+ "1111111" + Environment.NewLine
+ "1111111" + Environment.NewLine
+ "1111111" + Environment.NewLine
+ "1111111", output);
		}

		[Fact]
		public void Test20()
		{
			var input = "10000001" + Environment.NewLine
+ "11101100" + Environment.NewLine
+ "00010100" + Environment.NewLine
+ "01001100" + Environment.NewLine
+ "01001000" + Environment.NewLine
+ "00000000" + Environment.NewLine
+ "00101000" + Environment.NewLine
+ "10000000";
			var output = new Problems.AwesomeProblem.Solution().Solve(input);
			Assert.Equal("11111111" + Environment.NewLine
+ "11111111" + Environment.NewLine
+ "11111111" + Environment.NewLine
+ "11111111" + Environment.NewLine
+ "11111111" + Environment.NewLine
+ "11111111" + Environment.NewLine
+ "11111111" + Environment.NewLine
+ "11111111", output);
		}
	}
}
