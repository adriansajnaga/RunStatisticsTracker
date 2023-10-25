using RunStatisticsTracker;
namespace RunStatisticsTracker.Tests


{

    public class AddRunnerTest
    {
        [Test]
        public void WhenAddRunnerinFile_ShouldReturnNameAdrian()
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

        [Test]
        public void WhenAddRunnerinMemory_ShouldReturnNameAdrian()
        {
            //ARRANGE
            var runner = new RunnerInMemory("Adrian", "Sajnaga");

            //Act
            var name = runner.Name;
            var surname = runner.Surname;

            //ASSERT
            Assert.AreEqual("Adrian", name);
            Assert.AreEqual("Sajnaga", surname);
        }
    }
}