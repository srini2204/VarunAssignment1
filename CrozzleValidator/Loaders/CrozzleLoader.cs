using CrozzleValidator.Validator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CrozzleValidator
{
    class CrozzleLoader
    {
        public StringBuilder loaderMessages;
        LinkedList<CrozzleWord> crozzleWords;
        public int width, height;        

        public CrozzleLoader()
        {
            loaderMessages = new StringBuilder(String.Empty);
            crozzleWords = new LinkedList<CrozzleWord>();
        }

        private void addMessage(string message)
        {
            if (message == String.Empty)
            {
                loaderMessages.Clear();
            }
            else
            {
                loaderMessages.AppendLine(message);
            }
        }

        public LinkedList<CrozzleWord> loadWordlist(string fileName)
        {
            addMessage(String.Empty);

            string[] crozzleContent = System.IO.File.ReadAllLines(fileName);
            //crozzleContent = crozzleContent.Split('\r')[0];

            addMessage("Data Loaded : ");

            validateNGenerateCrozzleData(crozzleContent);
            
            return crozzleWords;
        }

        private Boolean validateNGenerateCrozzleData(string[] crozzleContent)
        {
            Boolean result = true;

            //Find all Horizonatal Words
            char[] separators = { ' ' };
            String[] words;
            int row = -1;
            int column;

            foreach (String word in crozzleContent)
            {
                row++;
                column = 0;
                words = word.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                foreach (String cWord in words)
                {
                    if (cWord.Length > 1)
                    {
                        //Find the Column location
                        column = crozzleContent[row].IndexOf(cWord, column);
                        //Create a new Horizontal CrozzleWord
                        CrozzleWord temp = new CrozzleWord(cWord, row, column, Orientation.Horizontal);

                        // check for duplicate word
                        if (CrozzleWordList.HCrozzleWords == null && CrozzleWordList.HCrozzleWords.Find(temp) != null)
                        {
                            CrozzleWordList.AddHorizantalWord(temp);
                        }
                        else
                        {
                            addMessage("Error: Word " + temp.Word +" is a duplicate entry. Can not procedd further.");
                            result = false;
                            return result;
                        }
                    }
                }
               
            }

            //Find all Vertical Rows

            return result;
        }

    }
}
