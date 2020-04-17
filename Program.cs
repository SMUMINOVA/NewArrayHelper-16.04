using System;
using NewArrayHelper;
namespace NewArrayHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true){
            int n;
            System.Console.Write($"Enter numb: ");
            n = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter numbers:");
            int [] arr = new int[n];
            for (int i = 0; i < n; i++){
                arr[i] = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Enter begin: ");
            int beg = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter end: ");
            int endi = int.Parse(Console.ReadLine());
            int [] array = ArrayHelper<int>.Slice(arr, beg, endi);
            System.Console.WriteLine("new array: ");
            for (int i = 0; i < array.Length; i++){
                System.Console.WriteLine(array[i]);
            }}
        }
    }
}
