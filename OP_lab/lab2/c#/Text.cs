using System;
namespace lab_2_OP_
{
    public class Text
    {
        private MyString[] _text;
        private int _capacity;
        private int _quantity;
        private void Resize(int value)
        {
            _capacity = value + 2;
            MyString[] tmp = new MyString[_capacity];
            for (int i = 0; i < (_text.Length > _capacity ? _text.Length : _capacity); i++)
            {
                if (i < _text.Length)
                {
                    tmp[i] = _text[i];
                }
                else
                {
                    tmp[i] = new MyString();
                }
            }

            _text = tmp;
        }
        
        public Text()
        {
            _capacity = 2;
            _quantity = 0;
            _text = new MyString[_capacity];
            for (int i = 0; i < _capacity; i++)
            {
                _text[i] = new MyString();
            }
        }

        public void Append(string str)
        {
            if (_quantity == _capacity)
            {
                Resize(_text.Length + 1);
            }
            _text[_quantity].push_back(str);
            ++_quantity;
        }
        public void Append(MyString str)
        {
            if (_quantity == _capacity)
            {
                Resize(_text.Length + 1);
            }
            _text[_quantity].push_back(str);
            ++_quantity;
        }
        public void Append(char ch)
        {
            if (_quantity == _capacity)
            {
                Resize(_text.Length + 1);
            }
            _text[_quantity].push_back(ch);
            ++_quantity;
        }

        public void Erase(int index)
        {
            for (int i = index; i < _quantity; i++)
            {
                _text[i] = _text[i + 1];
            }

            --_quantity;
        }

        public void Print()
        {
            for (int i = 0; i < _quantity; i++)
            {
                Console.WriteLine(_text[i]);
            }
        }

        public void Replace(int index, MyString str)
        {
            _text[index].Replace(str);
        }
        public void Replace(int index, string str)
        {
            _text[index].Replace(str);
        }

        public void Clear()
        {
            _quantity = 0;
            for (int i = 0; i < _capacity; i++)
            {
                _text[i] = new MyString();
            }
        }

        public MyString ReturnNumbers()
        {
            MyString tmp = new MyString();
            for (int i = 0; i < _quantity; i++)
            {
                tmp.push_back(_text[i].ReturnNumbers());
            }

            return tmp;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public ref MyString at(int index)
        {
            if (index < 0 || index >= _quantity)
            {
                throw new Exception("invalid index");
            }

            return ref _text[index];
        }
    }
}