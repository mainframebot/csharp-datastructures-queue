using NUnit.Framework;

namespace Queue.Test.ArrayQueue
{
    [TestFixture]
    public class Enumeration : Base
    {
        // Test: Use enumeration to traverse the queue
        // Outcome:
        // 1. Counter is equal to stack count
        [Test]
        public void EnumeratePopulatedQueue()
        {
            int counter = 0;
            foreach (var item in PopulatedArrayQueue)
            {
                counter++;
            }

            Assert.That(PopulatedArrayQueue.Count, Is.EqualTo(counter));
        }
    }
}
