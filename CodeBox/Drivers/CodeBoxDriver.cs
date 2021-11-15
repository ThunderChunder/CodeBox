using CodeBox.Collections;
using CodeBox.Contracts;
using System;
using System.Collections.Generic;

namespace CodeBox.Drivers
{
    public class CodeBoxDriver: iCodeBoxDriver
    {
        private iCodeBoxDictionary _codeBoxDict;
        private List<string> _codeList;
        const string CODE_BOX_SPLIT_CHAR = ")";

        public CodeBoxDriver()
        {
            _codeBoxDict = new CodeBoxDictionary();
            _codeList = new List<string>();
        }
        public void SetCodeBoxDictionary(string codeBoxInput)
        {
            var codeBoxInputArray = codeBoxInput.Split(CODE_BOX_SPLIT_CHAR);

            string numberBuffer = string.Empty;
            string letterBuffer = string.Empty;

            foreach (var element in codeBoxInputArray)
            {
                foreach (char character in element)
                {
                    if (char.IsDigit(character))
                    {
                        numberBuffer += character;
                    }
                    else if (char.IsLetter(character))
                    {
                        letterBuffer += character;
                    }
                }
                _codeBoxDict.AddCodeValuePair(numberBuffer, letterBuffer);
                numberBuffer = string.Empty;
                letterBuffer = string.Empty;
            }
        }

        public void SetCodesList(string codeInputs)
        {
            var codeBuffer = string.Empty;

            foreach (char character in codeInputs)
            {
                if (char.IsDigit(character))
                {
                    codeBuffer += character;
                }
                else if (!string.IsNullOrEmpty(codeBuffer))
                {
                    _codeList.Add(codeBuffer);
                    codeBuffer = string.Empty;
                }
            }
        }


        public void PrintMatchedCodesInCodeBox()
        {
            var result = string.Empty;
            foreach (var code in _codeList)
            {
                result = _codeBoxDict.GetValueWithCode(code);

                if (!string.IsNullOrEmpty(result))
                {
                    Console.WriteLine(result);
                    result = string.Empty;
                }
            }
        }

        public void PrintCodeValuePairs()
        {
            _codeBoxDict.PrintCodeValuePairs();
        }
    }
}
