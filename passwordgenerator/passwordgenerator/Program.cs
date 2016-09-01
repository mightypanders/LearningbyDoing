using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordgenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            pwgen gen = new pwgen();
            while (true)
            {
                gen.generatePW();
                Console.ReadKey();

            }
        }
    }

    class pwgen
    {
        static int pwl = 8;
        char[] result = new char[pwl];
        int numbercount = 0;
        int position = 0;
        Random rand = new Random();
        List<char> numbers = new List<char> { '1', '2', '3', '4', '5','6','7','8','9','0' };
        public pwgen()
        {
        }
        
        public void generatePW()
        {
            result = new char[pwl];
            numbercount = 0;
            position = 0;
            while (numbercount != 2)
            {
                if (position < result.Length - 1)
                {
                    position++;
                }
                else
                {
                    position = 0;
                }
                
                char nextChar = Convert.ToChar(rand.Next(33, 127));

                if (numbers.Contains(nextChar))
                {
                    numbercount++;
                }
                result[position] = nextChar;
            }
            Console.WriteLine(result);
        }
    }
    

}

