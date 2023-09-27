using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RunStatisticsTracker
{
    public class TreadmillRun : UserBase
    {
        private string fileName;

        public TreadmillRun(string name, string surname) 
            : base(name, surname)
        {
        }

        public override void SaveNewRecord(int dist)
        {
            throw new System.NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            return statistics;

        }
    }
}