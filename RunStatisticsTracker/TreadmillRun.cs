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
            fileName = $"{name}_{surname}_treademilRuns.txt";
        }

        public override void SaveNewRecord(double distance)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(distance);
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

                using (var reader = File.OpenText($"{fileName}"))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    { 
                        var distance = double.Parse(line);
                        statistics.AddRecords(distance);
                    }
                }

            return statistics;
        }
        public override bool StatExists()
        {
            if (File.Exists($"{fileName}"))
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