using NUnit.Framework;

namespace Queue.Test.ArrayQueue
{
    [TestFixture]
    public class Enqueue : Base
    {
        // Test: Use Enqueue() to add a new item to an empty queue
        // Outcome: 
        // 1. Queue count should equal 1
        [Test]
        public void EnqueueEmptyQueue()
        {
            EmptyArrayQueue.Enqueue(Item);

            Assert.That(EmptyArrayQueue.Count, Is.EqualTo(1));
        }

        // Test: Use Enqueue() to add a new item to a populated queue
        // Outcome: 
        // 1. Queue count should equal items + 1
        [Test]
        public void EnqueuePopulatedQueue()
        {
            PopulatedArrayQueue.Enqueue(Item);

            Assert.That(PopulatedArrayQueue.Count, Is.EqualTo(Items.Length + 1));
        }
    }
}
