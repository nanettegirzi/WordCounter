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

    public int CountWords()
    {
        return 1;
    }

    }
}
