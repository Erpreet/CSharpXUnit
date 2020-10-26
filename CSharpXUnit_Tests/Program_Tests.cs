using System;
using Xunit;
using CSharpXunit;


namespace CSharpXUnit_Tests
{
    public class Program_Tests
    {
        [Theory]
        [InlineData(2,1)]
        [InlineData(4, 2)]
        [InlineData(3, 1)]
        [InlineData(0, 0)]
        [InlineData(-2, -1)]
        [InlineData(int.MaxValue, 1073741823 )]
        [InlineData(int.MinValue, -1073741824 )]

        public void DivideByTwo_Valid(int input, int expected)
        {
            int output;

            output = Program.DivideByTwo(input);

            Assert.Equal(expected, output);



        }

        [Theory]
        [InlineData(4, true)]
        [InlineData(3, false)]
        public void PerfectSquare_Valid(int input, bool expected)
        {
            bool output;

            output = Program.PerfectSquare(input);

            Assert.Equal(expected, output);


        }
        [Fact]
        public void MathPi_Value()
        {
            Assert.Equal(3.14, Math.PI);
        }

        [Fact]
        public void Exception_Test()
        {
            Assert.Throws<FormatException>(() => {
                Program.ThrowsFormatException();
            });
            
        }
    }
}
