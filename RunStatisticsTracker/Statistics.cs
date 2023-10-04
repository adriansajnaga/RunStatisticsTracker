using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RunStatisticsTracker
{
    public class Statistics
    {
        public int Count { get; set; }
        public double DistSum { get; set; }
        public double LongestDist { get; set; }
        public double ShortestDist { get; set; }
        public double AvgDist
        {
            get
            {
                return this.DistSum / this.Count;
            }
        }
        public Statistics()
        {
            this.Count = 0;
            this.DistSum = 0;
            this.LongestDist = 0;
            this.ShortestDist = double.MaxValue;
        }
        public void AddRecords(double distance)
        {
            this.LongestDist = Math.Max(this.LongestDist, distance);
            this.ShortestDist = Math.Min(this.ShortestDist, distance);
            this.DistSum += distance;
            this.Count++;
        }

    }
}