namespace RunStatisticsTracker
{
    public class TreadmillRun : UserBase
    {
        public delegate void DistanceSavedDelegate(object sender, EventArgs args);

        public event DistanceSavedDelegate DistanceSaved;

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

            if (DistanceSaved != null)
            {
                DistanceSaved(this, new EventArgs());
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