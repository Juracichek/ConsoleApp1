using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConsoleApp1.Tests
{
    public class newClassTests
    {
        //Equal
        [Fact]
        public void now_year()
        {
            int currentYear = 2021;
            int birthYear = 2002;
            int expected = 19;
            Program program = new Program();
            Assert.Equal(expected, program.years(currentYear, birthYear));
        }

        [Fact]
        public void grade_for_semester()
        {
            int number = 5;
            string expected = "Отлично";
            Program program = new Program();
            Assert.Equal(expected, program.grade(number));
        }

        [Fact]
        public void exponentiation()
        {
            int a = 2;
            int expected = 8;
            Program program = new Program();
            Assert.Equal(expected, program.exp(a));
        }

        // True
        [Fact]
        public void comp()
        {
            int a = 5;
            int b = 7;
            bool expected = true;
            Program program = new Program();
            Assert.True(expected, program.comparison(a, b));
        }

        [Fact]
        public void sNull()
        {
            string s1 = "";
            string s2 = "hello";
            bool expected = true;
            Program program = new Program();
            Assert.True(expected, program.str_null(s1, s2));
        }

        [Fact]
        public void even()
        {
            int number = 46;
            bool expected = true;
            Program program = new Program();
            Assert.True(expected, program.even_number(number));
        }

        //Throws<Exception>
        [Theory]
        [InlineData(-6)]
        [InlineData(0)]
        [InlineData(231)]
        public void height_human_less_null(int height)
        {
            Program program = new Program();
            Assert.Throws<Exception>(() => program.height_human(height));
        }

        //[Fact]
        //public void height_human_null()
        //{
        //    Program program = new Program();
        //    Assert.Throws<Exception>(() => program.height_Human(0));
        //}

        //[Fact]
        //public void height_human_above_210sm()
        //{
        //    Program program = new Program();
        //    Assert.Throws<Exception>(() => program.heightHuman(231));
        //}
    }
}
