using System;

namespace InterestCalculator
{
    class InterestCalculatorFixed
    {
        private double sum;
        private double interest;
        private int years;

        public InterestCalculatorFixed(double sum, 
            double interest,
            int years,
            Func<double, double, int, double> interestCalculator)
        {
            this.Sum = sum;
            this.Interest = interest;
            this.Years = years;
            this.TotalSum = interestCalculator(sum, interest, years);
        }

        public double Sum
        {
            get
            {
                return this.sum;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Sum cannot be negative!");
                }

                this.sum = value;
            }
        }

        public double Interest
        {
            get
            {
                return this.interest;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest cannot be negative!");
                }

                this.interest = value;
            }
        }

        public int Years
        {
            get
            {
                return this.years;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Years cannot be negative!");
                }

                this.years = value;
            }
        }

        public double TotalSum { get; set; }

        public override string ToString()
        {
            return string.Format("Money = {0}\nInterest = {1}\nYears = {2}\nTotalSum = {3:F4}\n",this.Sum, 
                this.Interest,
                this.Years,
                this.TotalSum);
        }
    }
}
