
namespace CodeBox.Contracts
{
    public interface iCodeBoxDictionary
    {
        public void AddCodeValuePair(string code, string value);

        public string GetValueWithCode(string key);

        public void PrintCodeValuePairs();
    }
}
