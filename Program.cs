namespace GenericClassesTask
{
    internal class Program
    {
        public class Stack
        {
            private List<int> items;

            public Stack()
            {
                items = new List<int>();
            }

            public void Push(int item)
            {
                items.Add(item);
            }

            public int Pop()
            {
                if (items.Count == 0)
                    throw new InvalidOperationException("Stack is empty");

                int poppedItem = items[items.Count - 1];
                items.RemoveAt(items.Count - 1);
                return poppedItem;
            }

            // Gets the last element, without removing it
            public int Peek()
            {
                if (items.Count == 0)
                {
                    throw new InvalidOperationException("Stack is empty");
                }

                return items[items.Count - 1];
            }

            public int Count
            {
                get { return items.Count; }
            }

            public bool IsEmpty
            {
                get { return items.Count == 0; }
            }
        }

        static void Main(string[] args)
        {
            Stack<string> s1 = new Stack<string>();
            s1.Push("a");
            s1.Push("b");
            s1.Push("c");

            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());
        }
    }
}