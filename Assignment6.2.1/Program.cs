namespace Assignment6._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackArray stack = new StackArray(5);
            stack.Pop(); // This will throw an exception since the stack is empty
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Display();
            stack.Pop();
            stack.Pop();
            stack.Display();
        }
    }
    class StackArray
    {
        private int[] data;
        private int top;
        public StackArray(int size)
        {
            data = new int[size];
            top = -1; // Stack is initially empty
        }
        public bool IsEmpty()
        {
            return this.top == -1;
        }
        public bool IsFull()
        {
            return this.top == data.Length - 1;
        }
        public void Push(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full, cannot push " + value);
                return;
            }
            data[++top] = value;
        }
        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty, cannot pop");
                return -1;
            }
            return data[top--];
        }
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return data[top];
        }
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.Write("Stack elements: ");
            for (int i = top; i >= 0; i--)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
