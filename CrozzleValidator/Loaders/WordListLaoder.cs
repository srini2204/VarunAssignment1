using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrozzleValidator
{
    class WordListLaoder
    {
        int noOfWords;
        public int width { get; set; }
        public int height { get; set; }
        LEVEL level { get; set; }
        string[] wordList;

        public StringBuilder loaderMessages;

        public WordListLaoder()
        {
            loaderMessages = new StringBuilder(String.Empty);
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

        public string[] loadWordlist(string fileName)
        {
            addMessage(String.Empty);
            bool result = false;
            string csvContent = System.IO.File.ReadAllText(fileName);
            csvContent = csvContent.Split('\r')[0];

            addMessage("Data Loaded : ");
            addMessage(csvContent);

            string[] csvData = csvContent.Split(',');

            result = validateCSVData(csvData);
            return wordList;
        }

        private bool validateCSVData(string[] csvData)
        {
            bool isValid = true;

            //checking position index 0 for word count
            try
            {
                noOfWords = Int32.Parse(csvData[0]);
            }
            catch (Exception)
            {
                addMessage("Error in CSV File: First position is not a valid word count");
                isValid = false;
                return isValid;
            }

            try
            {
                width = Int32.Parse(csvData[1]);
            }
            catch (Exception)
            {
                addMessage("Error in CSV File: Second position is not a valid Crozzle width");
                isValid = false;
                return isValid;
            }

            try
            {
                height = Int32.Parse(csvData[2]);
            }
            catch (Exception)
            {
                addMessage("Error in CSV File: Third position is not a valid Crozzle height");
                isValid = false;
                return isValid;
            }

            try
            {
                string l = csvData[3];

                if (l == "EASY")
                {
                    level = LEVEL.EASY;
                }
                else if (l == "MEDIUM")
                {
                    level = LEVEL.MEDIUM;
                }
                else if (l == "HARD")
                {
                    level = LEVEL.HARD;
                }
                else if (l == "EXTREME")
                {
                    level = LEVEL.EXTREME;
                }
            }
            catch (Exception)
            {
                addMessage("Error in CSV File: Fourth position is not a valid Crozzle difficulty level");
                isValid = false;
                return isValid;
            }

            if (noOfWords == (csvData.Length - 4))
            {
                wordList = new string[noOfWords];
                for (int i = 0; i < csvData.Length - 4; i++)
                {
                    wordList[i] = csvData[i + 4];
                }
            }
            else
            {
                addMessage("Word count does not match the actual words present on file");
                isValid = false;
                return isValid;
            }
            return isValid;
        }
    }
}
