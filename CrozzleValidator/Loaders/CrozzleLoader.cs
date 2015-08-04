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

        private void validateNGenerateCrozzleData(string[] crozzleContent)
        {
            char[,] data = new char[width, height];
            for (int i = 0; i < crozzleContent.Length; i++)
            {
                data[i] = crozzleContent[i].ToCharArray();
            }
        }

    }
}
