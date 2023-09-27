using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace RunStatisticsTracker
{
    public abstract class UserBase     : iUser
    {
        public UserBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }

        public abstract Statistics GetStatistics();

        public int ReadDistance(string km, string m)
        {
            int distance = 10;
            return distance;
        }
        public abstract void SaveNewRecord(int dist);
    }
}