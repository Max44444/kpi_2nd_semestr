using System;

namespace lab_3_OP
{
    public class CharArray
    {
        private char[,] _arr;
        private int _rows;

        public CharArray(int quantity)
        {
            _arr = new char[quantity,quantity];
            Random x = new Random();
            for (int i = 0; i < quantity; i++)
            {
                for (int j = 0; j < quantity; j++)
                {
                    _arr[i,j] = "ABCDEFGHIGKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"[x.Next(0, 52)];
                }
            }
            _rows  = quantity;
        }

        public void Print()
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _rows; j++)
                {
                    Console.Write($"{_arr[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        public string this[int diagonal]
        {
            get
            {
                try
                {
                    if (diagonal != 0 && diagonal != 1)
                    {
                        throw new Exception("invalid index");
                    }
                }
                catch
                {
                    Console.WriteLine("Error");
                }

                string tmp = String.Empty;
                switch (diagonal)
                {
                    case 0:
                        for (int i = 0; i < _rows; i++)
                        {
                            tmp += _arr[i, i];
                        }

                        return tmp;
                    case 1:
                        for (int i = 0; i < _rows; i++)
                        {
                            tmp += _arr[i, _rows - 1 - i];
                        }

                        return tmp;
                }

                return null;
            }
        }

        public int VowelsQuantity
        {
            get
            {
                int n = 0;
                for (int i = 0; i < _rows; i++)
                {
                    for (int j = 0; j < _rows; j++)
                    {
                        if("AEIOUYaeiouy".Contains(_arr[i,j]))
                        {
                            ++n;
                        }
                    }
                }

                return n;
            }
        }
    }
}