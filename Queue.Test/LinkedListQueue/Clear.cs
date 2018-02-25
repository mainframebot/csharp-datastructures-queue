using NUnit.Framework;

namespace Queue.Test.LinkedListQueue
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
            EmptyLinkedListQueue.Clear();

            Assert.That(EmptyLinkedListQueue.Count, Is.EqualTo(0));
        }
        
        // Test: Use Clear() to reset a single item queue
        // Outcome:
        // 1. Count should equal 0
        [Test]
        public void ClearSingleItemQueue()
        {
            SingleItemLinkedListQueue.Clear();

            Assert.That(SingleItemLinkedListQueue.Count, Is.EqualTo(0));
        }


        // Test: Use Clear() to reset a populated queue
        // Outcome:
        // 1. Count should equal 0
        [Test]
        public void ClearPopulatedQueue()
        {
            PopulatedLinkedListQueue.Clear();

            Assert.That(PopulatedLinkedListQueue.Count, Is.EqualTo(0));
        }
    }
}
