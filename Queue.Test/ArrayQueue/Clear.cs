using NUnit.Framework;

namespace Queue.Test.ArrayQueue
{
    [TestFixture]
    public class Clear : Base
    {
        // Test: Use Clear() to reset an empty queue
        // Outcome:
        // 1. Count should equal 0
        [Test]
        public void ClearEmptyQueue()
        {
            EmptyArrayQueue.Clear();

            Assert.That(EmptyArrayQueue.Count, Is.EqualTo(0));
        }

        // Test: Use Clear() to reset a single item queue
        // Outcome:
        // 1. Count should equal 0
        [Test]
        public void ClearSingleItemQueue()
        {
            SingleItemArrayQueue.Clear();

            Assert.That(SingleItemArrayQueue.Count, Is.EqualTo(0));
        }


        // Test: Use Clear() to reset a populated queue
        // Outcome:
        // 1. Count should equal 0
        [Test]
        public void ClearPopulatedQueue()
        {
            PopulatedArrayQueue.Clear();

            Assert.That(PopulatedArrayQueue.Count, Is.EqualTo(0));
        }
    }
}
