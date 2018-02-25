using ArrayQueue;
using NUnit.Framework;

namespace Queue.Test.ArrayQueue
{
    public abstract class Base
    {
        #region Setup

        public ArrayQueue<string> PopulatedArrayQueue { get; set; }

        public ArrayQueue<string> SingleItemArrayQueue { get; set; }

        public ArrayQueue<string> EmptyArrayQueue { get; set; }

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
            PopulatedArrayQueue = new ArrayQueue<string>();
            foreach (var item in Items)
            {
                PopulatedArrayQueue.Enqueue(item);
            }
        }

        private void GenerateSingleItemExample()
        {
            SingleItemArrayQueue = new ArrayQueue<string>();
            SingleItemArrayQueue.Enqueue(Items[0]);
        }

        private void GenerateEmptyExample()
        {
            EmptyArrayQueue = new ArrayQueue<string>();
        }

        #endregion
    }
}
