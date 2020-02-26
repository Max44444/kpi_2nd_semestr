using System.IO;

namespace lab_2_OP_
{
    public class MyString
    {
        //private:
        private char[] _str;
        private void Resize(int value)
        {
            char[] tmp = new char[value];
            for (int i = 0; i < (this._str.Length < value ? this._str.Length : value); i++)
            {
                tmp[i] = this._str[i];
            }

            this._str = tmp;
        }
        //public:
        public MyString()
        {
            _str = new char[0];
        }

        public void Replace(MyString str)
        {
            this._str = str._str;
        }

        public void Replace(string str)
        {
            _str = new char[str.Length];
            using (StringReader sr = new StringReader(str)) 
            { 
                sr.Read(_str); 
            }
        }

        public override string ToString()
        {
            return new string(_str);
        }

        public void push_back(string str)
        {
            Resize(_str.Length + str.Length);
            using (StringReader sr = new StringReader(str)) 
            { 
                sr.Read(_str, _str.Length - str.Length, str.Length); 
            }
        }

        public void push_back(MyString str)
        {
            var tmp = _str.Length;
            Resize(_str.Length + str._str.Length);
            for (int i = 0; i < str._str.Length; i++)
            {
                _str[i + tmp] = str._str[i];
            }
        }
        
        public void push_back(char ch)
        {
            this.Resize(_str.Length + 1);
            _str[^1] = ch;
        }

        public MyString ReturnNumbers()
        {
            MyString tmp = new MyString();
            foreach (var i in _str)
            {
                if (char.IsDigit(i))
                {
                    tmp.push_back(i);
                }
            }

            return tmp;
        }
    }
}