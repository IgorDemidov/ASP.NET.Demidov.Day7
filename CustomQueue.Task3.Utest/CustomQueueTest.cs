using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomQueue.Task3.Library;

namespace CustomQueue.Task3.Utest
{
    [TestClass]
    public class CustomQueueTest
    {
        [TestMethod]
        public void ConstructorWithIEnumerable_Test()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            CustomQueue<int> queue = new CustomQueue<int>(array);

            bool isCorrect = true;
            for (int i = 0; i < array.Length; i++)
            {
               isCorrect = (queue.Dequeue() == array[i]);
               if (!isCorrect)
                   break;
            }
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void Enqueue_Test()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            CustomQueue<int> queue = new CustomQueue<int>(10);

            for (int i = 0; i < array.Length; i++)
            {
                queue.Enqueue(i);
            }

            bool isCorrect = true;
            for (int i = 0; i < array.Length; i++)
            {
                isCorrect = isCorrect && (queue.Dequeue() == array[i]);
                
            }
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void Dequeue_Test()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            CustomQueue<int> queue = new CustomQueue<int>(array);
            
            bool isCorrect = true;
            for (int i = 0; i < array.Length; i++)
            {
                isCorrect = isCorrect && (queue.Dequeue() == array[i]);
            }
            isCorrect = isCorrect && (queue.Count == 0);

            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void Peek_Test()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4 };
            CustomQueue<int> queue = new CustomQueue<int>(array);

            int actual = queue.Peek();
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }

    }
}
