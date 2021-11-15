using CodeBox.Contracts;
using System;
using System.Collections.Generic;


namespace CodeBox.Collections
{
    public class CodeBoxDictionary: iCodeBoxDictionary
    {
        private readonly Dictionary<string, string> _codeBoxDict;

        public CodeBoxDictionary()
        {
            _codeBoxDict = new Dictionary<string, string>();
        }

        public void AddCodeValuePair(string code, string value)
        {
            if( !(string.IsNullOrEmpty(code) && string.IsNullOrEmpty(value)) )
            {
                _codeBoxDict.Add(code, value);
            }
        }

        public string GetValueWithCode(string code)
        {
            string result = string.Empty;

            if (!string.IsNullOrEmpty(code))
            {
                try
                {
                    result = _codeBoxDict[code];
                }
                catch (KeyNotFoundException e)
                {
                    return result;
                }
            }
            return result;
        }

        public void PrintCodeValuePairs()
        {
            foreach(var pair in _codeBoxDict)
            {
                Console.WriteLine("({0},{1})", pair.Key, pair.Value);
            }
        }
    }
}
