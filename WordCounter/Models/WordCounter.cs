using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string _userWord;
        private string _userString;


        public RepeatCounter (string userWord, string userString)
        {
            _userWord = userWord;
            _userString = userString;
        }

        public string GetUserWord()
        {
            return _userWord;
        }

        public string GetUserString()
        {
            return _userString;
        }

        public int CountWords()
        {
            int count = 0;
            string userString = _userString;
            string userWord = _userWord;

            string [] userInputString = userString.Split();

            for (int index = 0; index < userInputString.Length; index++)
            {
                if(userInputString[index] == userWord)
                {
                    count +=1;
                }
            }
            return count;
        }

    }
}
