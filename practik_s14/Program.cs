using System.Collections;
using System.Collections.Generic;

namespace practik_s14
{
    class MyStack<T>
    {
        private T[] stack;
        private int size;
        public MyStack()
        {
            stack = new T[10];
            size = 0;
        }
        public MyStack(int capacity) :this()
        {
            stack = new T[capacity];
        }
        public void pop()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }
            T[] temp = new T[size--];
            for (int i = 0; i < size; i++)
            {
                temp[i] = stack[i];
            }
            stack = temp;
        }
        public void push(T element)
        {
            if (size == stack.Length)
            {
                T[] newArray = new T[2 * stack.Length];
                Array.Copy(stack, newArray, size);
                stack = newArray;
            }
            stack[size++] = element;
        }
        public T peek()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }
            return stack[size - 1];
        }
        public int count()
        {
            return size;
        }
    }
    class MyQueue<T>
    {
        private T[] queue;
        private int head;
        private int tail;
        private int size;
        public MyQueue()
        {
            queue = new T[10];
            head = tail = size = 0;
        }
        public MyQueue(int capacity) :this()
        {
            queue = new T[capacity];
        }
        public void enqueue(T element)
        {
            if (size == queue.Length)
            {
                T[] newArray = new T[2 * queue.Length];
                if (size > 0)
                {
                    if (head < tail)
                    {
                        Array.Copy(queue, head, newArray, 0, size);
                    }
                    else
                    {
                        Array.Copy(queue, head, newArray, 0, queue.Length - head);
                        Array.Copy(queue, 0, newArray, queue.Length - head, tail);
                    }
                }
                queue = newArray;
                head = 0;
                tail = (size == newArray.Length) ? 0 : size;
            }
            queue[tail] = element;
            tail = (tail + 1) % queue.Length;
            size++;
        }
        public void dequeue()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }
            T[] temp = new T[head];
            for (int i = 1; i < size; i++)
            {
                temp![i] = queue[i];
            }
            head = (head + 1) % queue.Length;
            size--;
            queue = temp!;
        }
        public T peek()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }
            return queue[head];
        }
        public int count()
        {
            return size;
        }
    }
    internal class Program
    {
        static T max<T>(T a, T b, T c)
        {
            if (a?.GetHashCode() > b?.GetHashCode() && a?.GetHashCode() > c?.GetHashCode())
            {
                return a;
            }
            else if (b?.GetHashCode() > a?.GetHashCode() && b?.GetHashCode() > c?.GetHashCode())
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        static T min<T>(T a, T b, T c)
        {
            if (a?.GetHashCode() < b?.GetHashCode() && a?.GetHashCode() < c?.GetHashCode())
            {
                return a;
            }
            else if (b?.GetHashCode() < a?.GetHashCode() && b?.GetHashCode() < c?.GetHashCode())
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        static T sumOfElements<T>(T[] arr)
        {
            T? count = default(T);
            for (int i = 0; i < arr.Length; i++)
            {
                count += (dynamic)arr[i]!;
            }
            return count!;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(max(2, 5, 6));
            Console.WriteLine(min(2, 5, 6));
            int[] arr = [2, 5, 6, 3, 5];
            Console.WriteLine(sumOfElements(arr));
            MyStack<int> stack = new MyStack<int>();
            stack.push(4);
            stack.push(3);
            stack.push(5);
            stack.push(4);
            Console.WriteLine(stack.peek());
            stack.pop();
            Console.WriteLine(stack.peek());
            Console.WriteLine(stack.count());
            Console.WriteLine("\n-------------");
            MyQueue<int> queue = new MyQueue<int>();
            stack.push(4);
            stack.push(3);
            stack.push(5);
            stack.push(4);
            Console.WriteLine(stack.peek());
            stack.pop();
            Console.WriteLine(stack.peek());
            Console.WriteLine(stack.count());
        }
    }
}
