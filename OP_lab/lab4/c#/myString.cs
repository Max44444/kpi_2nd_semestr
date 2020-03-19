using System;
using System.IO;

namespace lab_2_OP_
{
    public class MyString
    {
        //private:
        private char[] _str;
        //public:
        public MyString()
        {
            _str = new char[0];
        }

        public MyString(char[] ch)
        {
            this._str = ch;
        }

        public MyString(MyString other)
        {
            this._str = other._str;
        }

        public int GetSize()
        {
            return _str.Length;
        }

        public override string ToString()
        {
            return new string(_str);
        }

        public static MyString operator *(MyString str1, int n)
        {
            int len = str1.GetSize() * n;
            char[] tmp = new char[len];
            for (int i = 0; i < len; i++)
            {
                tmp[i] = str1._str[i % str1.GetSize()];
            }

            return new MyString(tmp);
        }

        public static MyString operator +(MyString str1, MyString str2)
        {
            char[] tmp = new char[str1.GetSize() + str2.GetSize()];
            for (int i = 0; i < str1.GetSize(); i++)
            {
                tmp[i] = str1._str[i];
            }
            for (int i = str1.GetSize(); i < tmp.Length; i++)
            {
                tmp[i] = str2._str[i - str1.GetSize()];
            }
            return new MyString(tmp);
        }
    }
}