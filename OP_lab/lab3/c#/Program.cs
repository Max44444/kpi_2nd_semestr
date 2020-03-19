using System;

namespace lab_3_OP
{
    class Program
    {
        static void Main(string[] args)
        {
            CharArray arr = new CharArray(4);
            arr.Print();
            Console.WriteLine(arr[0]);
            Console.Write(arr.VowelsQuantity);
        }
    }
}