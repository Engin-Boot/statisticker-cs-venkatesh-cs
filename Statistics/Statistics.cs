using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class Stats
    {
        public double average { get; set; }
        public double max { get; set; }
        public double min { get; set; }
    }
    public class StatsComputer
    {
        public double average { get; set; }
        public double max { get; set; }
        public double min { get; set; }


        public Stats CalculateStatistics(List<double> numbers)
        {
            Stats stats = new Stats
            {
                average = GetAverage(numbers),
                min = GetMinValue(numbers),
                max = GetMaxValue(numbers)
            };

            average = GetAverage(numbers);
            min = GetMinValue(numbers);
            max = GetMaxValue(numbers);

            return stats;

        }

        private double GetAverage(List<double> numbers)
        {
            if(numbers.Count == 0)
            {
                return Double.NaN;

            }
            return numbers.Average();
        }

        private double GetMaxValue(List<double> numbers)
        {
            if (numbers.Count == 0)
            {
                return Double.NaN;

            }
            return numbers.Max();
        }

        private double GetMinValue(List<double> numbers)
        {
            if (numbers.Count == 0)
            {
                return Double.NaN;

            }
            return numbers.Min();
        }

    }

}
