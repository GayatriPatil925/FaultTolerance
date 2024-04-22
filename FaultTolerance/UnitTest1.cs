namespace FaultTolerance
{
    public class Tests
    {
        [Test]
        public void FaultTolerance()
        {
            int expectedVal = 1000;
            int actualVal = 900;
            int tolerance = 100;

            Assert.That(actualVal, Is.InRange(expectedVal-tolerance,expectedVal+tolerance));
        }
    }
}