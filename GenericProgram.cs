using System;

namespace Assignment5
{
    class MyStack<T>
    {
        private dynamic[] ele;
        private int top;
        private int max;
        public MyStack(int size)
        {
            ele = new dynamic[size];
            top = -1;
            max = size;
        }

        public void push(T item)
        {
            ele[++top] = item;
        }

        public T pop()
        {
            Console.WriteLine("Poped element is: " + ele[top]);
            return ele[top--];
        }

    }
    class GenericProgram
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>(5);
            myStack.push(1);
            MyStack<string> myStack1 = new MyStack<string>(5);
            myStack1.push("sri");
            myStack.pop();
            myStack1.pop();

        }
    }
}