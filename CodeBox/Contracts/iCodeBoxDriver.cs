
namespace CodeBox.Contracts
{
    public interface iCodeBoxDriver
    {
        public void SetCodeBoxDictionary(string codeBoxInput);

        public void SetCodesList(string codeInputs);

        public void PrintMatchedCodesInCodeBox();

        public void PrintCodeValuePairs();
    }
}
