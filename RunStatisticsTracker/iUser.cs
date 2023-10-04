using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RunStatisticsTracker
{
    public interface iUser
    {
        string Name { get; }
        string Surname { get; }

        Statistics GetStatistics();
        public void SaveNewRecord(double distance);
        public void ReadDistance(string distance);
        public bool StatExists();
    }
}