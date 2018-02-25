using System;
using NUnit.Framework;

namespace Queue.Test.LinkedListQueue
{
    [TestFixture]
    public class Dequeue : Base
    {
        // Test: Use Dequeue() to remove an item from an empty queue
        // Outcome:
        // 1. IndexOutOfRangeException should be thrown
        [Test]
        public void DequeueEmptyQueue()
        {
            Assert.Throws<IndexOutOfRangeException>(() => EmptyLinkedListQueue.Dequeue());
        }

        // Test: Use Dequeue() to remove an item from a single item queue
        // Outcome:
        // 1. Value returned should equal items[0] "I am"
        // 2. Count should equal 0
        [Test]
        public void DequeueSingleItemQueue()
        {
            Assert.That(SingleItemLinkedListQueue.Dequeue(), Is.EqualTo(Items[0]));
            Assert.That(SingleItemLinkedListQueue.Count, Is.EqualTo(0));
        }

        // Test: Use Dequeue() to remove an item from a populated queue
        // Outcome:
        // 1. Value returned should equal items[0] "I am"
        // 2. Count should equal items - 1
        [Test]
        public void DequeuePopulatedQueue()
        {
            Assert.That(PopulatedLinkedListQueue.Dequeue(), Is.EqualTo(Items[0]));
            Assert.That(PopulatedLinkedListQueue.Count, Is.EqualTo(Items.Length - 1));
        }
    }
}
