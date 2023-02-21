using System;

namespace Assignment5
{
    class arrays
    {
        public void DisplayIntegerArray(int[] arr)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(arr[j]);
            }
        }
        public void DisplayStringArray(string[] ar)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(ar[j]);
            }
        }
    }
    class ArrayMethods
    {
        static void Main(string[] args)
        {
            arrays a = new arrays();
            int[] IntArray = new int[5];
            string[] StringArray = new string[5];
            Console.WriteLine("Enter elemts of integer array");
            for (int i = 0; i < 5; i++)
            {
                IntArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter elemts of string array");
            for (int i = 0; i < 5; i++)
            {
                StringArray[i] = Console.ReadLine();
            }
            //copying
            int[] CopiedIntArray = new int[5];
            string[] CopiedStringArray = new string[5];
            Array.Copy(IntArray, CopiedIntArray, 5);
            Array.Copy(StringArray, CopiedStringArray, 5);
            Console.WriteLine("Copied Integer array");
            a.DisplayIntegerArray(CopiedIntArray);
            Console.WriteLine("Copied String array");
            a.DisplayStringArray(CopiedStringArray);
            //Sorting
            Array.Sort(IntArray);
            Console.WriteLine("Sorted Integer array");
            a.DisplayIntegerArray(IntArray);
            Array.Sort(StringArray);
            Console.WriteLine("Sorted String array");
            a.DisplayStringArray(StringArray);
            //Reversing
            Array.Reverse(IntArray);
            Console.WriteLine("Reversed Integer array");
            a.DisplayIntegerArray(IntArray);
            Array.Reverse(StringArray);
            Console.WriteLine("Reversed String array");
            a.DisplayStringArray(StringArray);
            //clearing
            Array.Clear(IntArray, 0, 5);
            Console.WriteLine("Cleared Integer array");
            a.DisplayIntegerArray(IntArray);
            Array.Clear(StringArray, 0, 5);
            Console.WriteLine("Cleared String array");
            a.DisplayStringArray(StringArray);
        }
    }
}