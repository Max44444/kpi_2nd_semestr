using System;
using lab_2_OP_;

namespace lab_4_OP
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] ch1 = {'q', 'r', 'g', 'j', 'x', 'y' };
            MyString str1 = new MyString(ch1);
            char[] ch2 = {'i', 't', 'g', 'j', ' ', 'y', 'h', 'F', 'l' };
            MyString str2 = new MyString(ch2);
            char[] ch3 = {'u', 's', ' ', 'l', ' ', 'j', 'r' };
            MyString str3 = new MyString(ch1);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            str3 = str3 * 2;
            Console.WriteLine(str3);
            str1 = str2 + str3;
            Console.WriteLine(str1);
        }
    }
}