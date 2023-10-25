using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RunStatisticsTracker
{
    public class RunnerInMemory : UserBase
    {
        public delegate void DistanceSavedDelegate(object sender, EventArgs args);

        public event DistanceSavedDelegate DistanceSaved;

        private List<double> listOfRecords = new List<double>();

        public RunnerInMemory(string name, string surname)
            : base(name, surname)
        {

        }

        public override void SaveNewRecord(double distance)
        {
            this.listOfRecords.Add(distance);

            if (DistanceSaved != null)
            {
                DistanceSaved(this, new EventArgs());
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

                    foreach (var record in this.listOfRecords)
                    {
                        statistics.AddRecords(record);
                    }  

            return statistics;
        }

        public override bool StatExists()
        {
            if (listOfRecords.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}