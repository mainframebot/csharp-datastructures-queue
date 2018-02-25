using NUnit.Framework;

namespace Queue.Test.LinkedListQueue
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
            foreach (var item in PopulatedLinkedListQueue)
            {
                counter++;
            }

            Assert.That(PopulatedLinkedListQueue.Count, Is.EqualTo(counter));
        }
    }
}
