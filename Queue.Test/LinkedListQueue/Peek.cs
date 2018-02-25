using System;
using NUnit.Framework;

namespace Queue.Test.LinkedListQueue
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
            Assert.Throws<IndexOutOfRangeException>(() => EmptyLinkedListQueue.Peek());
        }

        // Test: Use Peek() to view the first item of a single item queue
        // Outcome:
        // 1. Value returned should equal items[0] "I am"
        // 2. Count should remain unchanged
        [Test]
        public void PeekSingleItemQueue()
        {
            Assert.That(SingleItemLinkedListQueue.Peek(), Is.EqualTo(Items[0]));
            Assert.That(SingleItemLinkedListQueue.Count, Is.EqualTo(1));
        }

        // Test: Use Peek() to view the first item of a populated queue
        // Outcome:
        // 1. Value returned should equal items[0] "I am"
        // 2. Count should remain unchanged
        [Test]
        public void PeekPopulatedQueue()
        {
            Assert.That(PopulatedLinkedListQueue.Peek(), Is.EqualTo(Items[0]));
            Assert.That(PopulatedLinkedListQueue.Count, Is.EqualTo(Items.Length));
        }
    }
}
