using System;

namespace lab_6_OP
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression[] arr = new Expression[100];
            Random rnd = new Random();
            for(int i = 0; i < 100; ++i)
            {
                arr[i] = new Expression {a = rnd.Next(-100, 100), b = rnd.Next(-100, 100), c = rnd.Next(-100, 100)};
            }

            arr[^1].b = 42;
            arr[^1].c = 1;
            foreach (var el in arr)
            {
                Console.WriteLine(el.get_result_of_expression());
            }
        }
    }
}