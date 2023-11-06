namespace RunStatisticsTracker.Tests


{

    public class StatisticsTest
    {
        [Test]
        public void WhenAddDistance_ShouldFindShortest()
        {
            var runner = new RunnerInMemory("Adrian", "Sajnaga");
            runner.SaveNewRecord(55);
            runner.SaveNewRecord("3");
            runner.SaveNewRecord(22);
            runner.SaveNewRecord("20");
            var statistics = runner.GetStatistics();
            Assert.AreEqual(3, statistics.ShortestDist);
        }

        [Test]
        public void WhenAddDistance_ShouldFindLongest()
        {
            var runner = new RunnerInMemory("Adrian", "Sajnaga");
            runner.SaveNewRecord(55);
            runner.SaveNewRecord("3");
            runner.SaveNewRecord(22);
            runner.SaveNewRecord("20");
            var statistics = runner.GetStatistics();
            Assert.AreEqual(55, statistics.LongestDist);
        }

        [Test]
        public void WhenAddDistance_ShouldCalcAvg()
        {
            var runner = new RunnerInMemory("Adrian", "Sajnaga");
            runner.SaveNewRecord(55);
            runner.SaveNewRecord("3");
            runner.SaveNewRecord(22);
            runner.SaveNewRecord("20");
            var statistics = runner.GetStatistics();
            Assert.AreEqual(25, statistics.AvgDist);
        }

        [Test]
        public void WhenAddDistance_ShouldCount()
        {
            var runner = new RunnerInMemory("Adrian", "Sajnaga");
            runner.SaveNewRecord(55);
            runner.SaveNewRecord("3");
            runner.SaveNewRecord(22);
            runner.SaveNewRecord("20");
            var statistics = runner.GetStatistics();
            Assert.AreEqual(4, statistics.Count);
        }


    }
}