using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrozzleValidator.Validator
{
    class CrozzleWordList
    {
        public static LinkedList<CrozzleWord> hCrozzleWords;
        internal static LinkedList<CrozzleWord> HCrozzleWords
        {
            get { return CrozzleWordList.hCrozzleWords; }
            set { CrozzleWordList.hCrozzleWords = value; }
        }

        public static LinkedList<CrozzleWord> vCrozzleWords;
        internal static LinkedList<CrozzleWord> VCrozzleWords
        {
            get { return CrozzleWordList.vCrozzleWords; }
            set { CrozzleWordList.vCrozzleWords = value; }
        }

        static CrozzleWordList()
        {
            LinkedList<CrozzleWord> hCrozzleWords = new LinkedList<CrozzleWord>();
            LinkedList<CrozzleWord> vCrozzleWords = new LinkedList<CrozzleWord>();
        }

        public static Boolean isDuplicate(CrozzleWord temp)
        {
            Boolean result = false;

            foreach (CrozzleWord c in CrozzleWordList.hCrozzleWords)
            {
                if (temp == c)
                {
                    result = true;
                    break;
                }
            }

            if (!result)
            {
                foreach (CrozzleWord c in CrozzleWordList.vCrozzleWords)
                {
                    if (temp == c)
                    {
                        result = true;
                        break;
                    }
                } 
            }

            return result;
        }

        public static void AddHorizantalWord(CrozzleWord word)
        {
            hCrozzleWords.AddLast(word);
        }

        public static void AddVerticalWord(CrozzleWord word)
        {
            vCrozzleWords.AddLast(word);
        }
    }
}
