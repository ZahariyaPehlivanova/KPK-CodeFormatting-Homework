using System;

namespace InterestCalculator
{
    class Program
    {
        private const int n = 12;

        static void Main(string[] args)
        {
            Func<double, double, int, double> simple = GetSimpleInterest;
            Func<double, double, int, double> compound = GetCompoundInterest;

            var icalc1 = new InterestCalculator(500, 5.6, 10, compound);
            var icalc2 = new InterestCalculator(2500, 7.2, 15, simple);

            Console.WriteLine(icalc1);
            Console.WriteLine(icalc2);
        }

        private static double GetCompoundInterest(double sum, double interest, int years)
        {
            return sum * Math.Pow((1 + (interest / 100 / n)), years * n);
        }

        private static double GetSimpleInterest(double sum, double interest, int years)
        {
            return sum * (1 + (interest / 100 * years));
        }
    }
}
