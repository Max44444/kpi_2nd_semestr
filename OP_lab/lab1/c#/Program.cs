using System;
using System.Data;

namespace lab_1_OP
{
    class Program
    {
        static void Sum(int a, int b, out int res)
        {
            int n1 = a, n2 = b;
            while (n2 != 0)
            {
                n1 = -~n1;
                n2 = ~-n2;
            }

            res = n1;
        }

        static bool RelationshipOperator(int a, int b)
        {
            return (a ^ b) == 0;
        }
        
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(RelationshipOperator(a, b));
            int res;
            Sum(a, b, out res);
            Console.WriteLine(res);
        }
    }
}