using System;
namespace Arrays
{

    class Program
    {
        //we add a square bracket []
        //after parameter's data type in the method declaration

        public static void PrintFirstElement(int[] a)
        {
            Console.WriteLine("The First Element is {0}.\n", a[0]);
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5 };
            PrintFirstElement(myArray);
        }
    }
}
