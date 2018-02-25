using LinkedListQueue;
using NUnit.Framework;

namespace Queue.Test.LinkedListQueue
{
    [TestFixture]
    public abstract class Base
    {
        #region Setup

        public LinkedListQueue<string> PopulatedLinkedListQueue { get; set; }

        public LinkedListQueue<string> SingleItemLinkedListQueue { get; set; }

        public LinkedListQueue<string> EmptyLinkedListQueue { get; set; }

        public string[] Items = { "I am", "Sorry", "Dave", ",", "I'm", "Afraid", "I", "Can't", "Do", "That" };

        public string Item = "Robot";

        [SetUp]
        public void BeforeEachTest()
        {
            GeneratePopulatedExample();
            GenerateSingleItemExample();
            GenerateEmptyExample();
        }

        #endregion

        #region Private Methods

        private void GeneratePopulatedExample()
        {
            PopulatedLinkedListQueue = new LinkedListQueue<string>();
            foreach (var item in Items)
            {
                PopulatedLinkedListQueue.Enqueue(item);
            }
        }

        private void GenerateSingleItemExample()
        {
            SingleItemLinkedListQueue = new LinkedListQueue<string>();
            SingleItemLinkedListQueue.Enqueue(Items[0]);
        }

        private void GenerateEmptyExample()
        {
            EmptyLinkedListQueue = new LinkedListQueue<string>();
        }

        #endregion
    }
}
