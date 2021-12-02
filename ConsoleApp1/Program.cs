using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        //Assert.Equal
        public int years(int currentYear, int birthYear)
        {
            return currentYear - birthYear;
        }

        public string grade(int number)
        {
            if (number == 5) return "Отлично";
            else if (number == 4) return "Хорошо";
            else if (number == 3) return "Удовлетворительно";
            else if (number == 2) return "Неудовлетворительно";
            else if (number == 1) return "Единица";
            else return "Такой оценки нет!";
        }

        public int exp(int a)
        {
            return a * a * a;
        }

        // Assert.True
        public string comparison(int a, int b)
        {
            if(a > b) return "a больше b";
            else return "b больше a";
        }

        public string str_null(string s1, string s2)
        {
            if (s1 == null) return "s1 - пустая";
            else return "s2 - пустя";
        }

        public string even_number(int number)
        {
            if (number % 2 == 0) return "Число чётное";
            else return "Число не чётное";
        }

        //Assert.Throws<Exception>
        public int height_human(int height)
        {
            if(height < 0)
            {
                throw new Exception();
            }

            if (height == 0)
            {
                throw new Exception();
            }
            if (height > 210)
            {
                throw new Exception();
            }

            return height;
        }

        
    }
}
