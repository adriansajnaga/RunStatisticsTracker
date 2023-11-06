namespace RunStatisticsTracker.Tests


{

    public class Tests
    {
        [Test]
        public void WhenAddRunnerinMemoryAdrian_ShouldReturnNameAdrian()
        {
            //ARRANGE
            var runner = new RunnerInFile("Adrian", "Sajnaga");

            //Act
            var name = runner.Name;
            var surname = runner.Surname;

            //ASSERT
            Assert.AreEqual("Adrian", name);
            Assert.AreEqual("Sajnaga", surname);
        }
    }
}