namespace lab_5_OP
{
    public class MyString
    {
        //private:
        protected char[] _str;
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
    }
}