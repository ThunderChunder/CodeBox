using CodeBox.Contracts;
using CodeBox.Drivers;
using System;

namespace CodeBox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            iCodeBoxDriver codeBoxDriver = new CodeBoxDriver();

            Console.WriteLine("Please enter the codebox table.");
            string codeBoxInput = Console.ReadLine();

            codeBoxDriver.SetCodeBoxDictionary(codeBoxInput);
            codeBoxDriver.PrintCodeValuePairs();

            Console.WriteLine("Please enter the codes to find.");
            string codeInputs = Console.ReadLine();

            codeBoxDriver.SetCodesList(codeInputs);
            codeBoxDriver.PrintMatchedCodesInCodeBox();
        }
    }
}
