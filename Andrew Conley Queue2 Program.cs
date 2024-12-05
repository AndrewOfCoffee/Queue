using System;

namespace Queue2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myQueue = new Queue<int>();
            myQueue.Add(5);
            myQueue.Add(11);
            myQueue.Add(35);
            Console.WriteLine("Removed: " + myQueue.Remove());
            Console.WriteLine("Removed: " + myQueue.Remove());
            Console.WriteLine("Removed: " + myQueue.Remove());
        }
    }

    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }

    public class Queue<T>
    {
        private Node<T> frontline;
        private Node<T> backline;

        public void Add(T val)
        {
            Node<T> newNode = new Node<T> { Data = val };
            if (backline == null)
            {
                frontline = backline = newNode;
            }
            else
            {
                backline.Next = newNode;
                backline = newNode;
            }
        }

        public T Remove()
        {
            if (frontline == null)
                throw (new Exception());

            T tempVal = frontline.Data;
            frontline = frontline.Next;

            if (frontline == null)
            {
                backline = null;
            }

            return tempVal;
        }
    }
}
