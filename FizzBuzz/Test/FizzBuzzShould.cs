using KataBizzBuzz.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KataBizzBuzz.Test
{
    public class FizzBuzzShould
    {
        [Fact]
        public void Generate_First_Number_If_MaxNumber_Is_One()
        {
            Assert.Equal(new String[] {"1"},FizzBuzz.GenerateOutput(1));
        }

        [Fact]
        public void Generating_The_First_Two_Numbers_If_MaxNumber_Is_Two()
        {
            Assert.Equal(new String[] { "1","2" }, FizzBuzz.GenerateOutput(2));
        }

        [Fact]
        public void Generating_The_First_Two_Numbers_And_Fizz_If_MaxNumber_Is_Three()
        {
            Assert.Equal(new String[] { "1", "2", "Fizz" }, FizzBuzz.GenerateOutput(3));
        }

        [Fact]
        public void Generating_The_First_Four_Numbers_If_MaxNumber_Is_Four()
        {
            Assert.Equal(new String[] { "1", "2", "Fizz", "4" }, FizzBuzz.GenerateOutput(4));
        }

        [Fact]
        public void Generating_The_First_Five_Numbers_With_Bizz_And_Buzz_If_MaxNumber_Is_Five()
        {
            Assert.Equal(new String[] { "1", "2", "Fizz", "4","Buzz" }, FizzBuzz.GenerateOutput(5));
        }
    }
}
