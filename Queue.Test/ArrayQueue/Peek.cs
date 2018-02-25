using System;
using NUnit.Framework;

namespace Queue.Test.ArrayQueue
{
    [TestFixture]
    public class Peek : Base
    {
        // Test: Use Peek() to view the first item of an empty queue
        // Outcome:
        // 1. IndexOutOfRangeException should be thrown
        [Test]
        public void PeekEmptyQueue()
        {
            Assert.Throws<IndexOutOfRangeException>(() => EmptyArrayQueue.Peek());
        }

        // Test: Use Peek() to view the first item of a single item queue
        // Outcome:
        // 1. Value returned should equal items[0] "I am"
        // 2. Count should remain unchanged
        [Test]
        public void PeekSingleItemQueue()
        {
            Assert.That(SingleItemArrayQueue.Peek(), Is.EqualTo(Items[0]));
            Assert.That(SingleItemArrayQueue.Count, Is.EqualTo(1));
        }

        // Test: Use Peek() to view the first item of a populated queue
        // Outcome:
        // 1. Value returned should equal items[0] "I am"
        // 2. Count should remain unchanged
        [Test]
        public void PeekPopulatedQueue()
        {
            Assert.That(PopulatedArrayQueue.Peek(), Is.EqualTo(Items[0]));
            Assert.That(PopulatedArrayQueue.Count, Is.EqualTo(Items.Length));
        }
    }
}
