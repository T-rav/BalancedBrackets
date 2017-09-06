namespace Brackets.Parser
{
    public class BracketsParser
    {
        public string VerifyBracketsAreBalanced(string input)
        {
            if (input.StartsWith("]") || input.EndsWith("[") || input.Length % 2 != 0)
            {
                return "Fail";
            }

            if (input.Length % 2 == 0)
            {
                return "Ok";
            }

            return string.Empty;
        }
    }
}