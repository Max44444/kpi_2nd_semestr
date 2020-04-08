namespace lab_5_OP
{
    public class LetterString : MyString
    {
        public LetterString() : base(){}
        public LetterString(char[] ch) : base(ch){}
        public LetterString(LetterString other) : base(other){}

        public void RowOffset()
        {
            if (this._str.Length == 0) return;
            var tmp = this._str[this.GetSize() - 1];
            for (int i = this.GetSize()-1; i > 0; --i)
            {
                _str[i] = _str[i - 1];
            }

            _str[0] = tmp;
        }

        public char[] get_string()
        {
            char[] tmp = new char[this.GetSize()];
            for (int i = 0; i < this.GetSize(); i++)
            {
                tmp[i] = this._str[i];
            }

            return tmp;
        }
    }
}