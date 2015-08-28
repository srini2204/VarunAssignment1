using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CrozzleValidator.Validator
{
    enum Orientation
    {
        Horizontal,
        Vertical
    }

    struct Position
    {
        public int Row;
        public int Column;
    }

    class CrozzleWord
    {
        Position location;
        public Position Location
        {
            get { return location; }
            set { location = value; }
        }

        string word;
        public string Word
        {
            get { return word; }
            set { word = value; }
        }

        Orientation orientation;
        public Orientation Orientation
        {
            get { return orientation; }
            set { orientation = value; }
        }

        public CrozzleWord(String w, int r, int c, Orientation o)
        {
            Word = w;
            location.Row = r;
            location.Column = c;
            Orientation = o;
        }

        public override bool Equals(object obj)
        {
            return ((obj is CrozzleWord) && (this.Word == ((CrozzleWord)obj).Word));
        }

        public override string ToString()
        {
            return Word;
        }
    }
}
