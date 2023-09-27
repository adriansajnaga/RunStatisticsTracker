using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RunStatisticsTracker
{
    public interface iUser
    {
        string Name { get; set; }
        string Surname { get; set; }

        Statistics GetStatistics();
        public void SaveNewRecord(int dist);
        public int ReadDistance(string km, string m);
    }
}