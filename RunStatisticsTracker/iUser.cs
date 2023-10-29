namespace RunStatisticsTracker
{
    public interface IUser
    {
        string Name { get; }
        string Surname { get; }

        Statistics GetStatistics();
        public void SaveNewRecord(double distance);
        public void ReadDistance(string distance);
        public bool StatExists();
    }
}