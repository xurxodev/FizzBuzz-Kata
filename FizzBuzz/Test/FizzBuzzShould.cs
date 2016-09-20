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

    }
}
