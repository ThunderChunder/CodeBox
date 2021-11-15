using CodeBox.Contracts;
using CodeBox.Drivers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeBoxTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string testCodeBox = "(1,C),(2,F)";
            CodeBoxDriver codeBoxDriver = new CodeBoxDriver();
            codeBoxDriver.SetCodeBoxDictionary(testCodeBox);

            var testDictionary = new Dictionary<string, string> { { "1", "C" }, { "2", "f" } };


            CollectionAssert.AreEquivalent((ICollection)expected, (ICollection)ret)
        }
    }
}
