using System;
using Xunit;
using Statistics;
using System.Collections.Generic;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics( new List<double> {1.5, 8.9, 3.2, 4.5} );
            Assert.True(Math.Abs(computedStats.average - 4.525) <= double.Epsilon);
            Assert.True(Math.Abs(computedStats.max - 8.9) <= double.Epsilon);
            Assert.True(Math.Abs(computedStats.min - 1.5) <= Double.Epsilon);
        }

        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(new List<double>{});
            Assert.True(computedStats.average.Equals(double.NaN));
            Assert.True(computedStats.max.Equals(double.NaN));
            Assert.True(computedStats.min.Equals( Double.NaN));
            //All fields of computedStats (average, max, min) must be
            //Double.NaN (not-a-number), as described in
            //https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1
        }

        [Fact]
        public void WhenNaNIsPassedStatsIsNaN()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(new List<double> { double.NaN });
            Assert.Equal(computedStats.average, double.NaN);
            Assert.Equal(computedStats.max, double.NaN);
            Assert.Equal(computedStats.min, double.NaN);
        }
    }
}
