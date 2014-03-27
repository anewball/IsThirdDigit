using System;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", IsThirdDigit(1400, 4));
        }

        public static bool IsThirdDigit(int num, double target)
        {
            int num1     = num / 100;
            double resul = num1 % 10;

            return (resul == target ? true : false);
        }
    }
}
