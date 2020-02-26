using System;

namespace lab_2_OP_
{
    class Program
    {
        static void Main(string[] args)
        {
            Text txt = new Text();
            for (int i = 0; i < 3; i++)
            {
                txt.Append(Console.ReadLine());
            }
            Console.WriteLine("\n================\n");
            txt.Print();
            txt.Erase(1);
            Console.WriteLine("\n================\n");
            txt.Print();
            txt.Replace(0, txt.at(1));
            Console.WriteLine("\n================\n");
            txt.Print();
            Console.WriteLine("\n================\n");
            Console.WriteLine(txt.GetQuantity());
            Console.WriteLine("\n================\n");
            Console.WriteLine(txt.ReturnNumbers());
            txt.Clear();
            Console.WriteLine("\n================\n");
            txt.Print();
        }
    }
}