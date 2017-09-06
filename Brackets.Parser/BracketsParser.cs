namespace Brackets.Parser
{
    public class BracketsParser
    {
        public string VerifyBracketsAreBalanced(string input)
        {
            if (StartsWithCloseBracket(input) || EndsWithOpenBracket(input) || !IsEvenNumberOfBrackets(input))
            {
                return "Fail";
            }

            if (IsEvenNumberOfBrackets(input))
            {
                return "Ok";
            }

            return string.Empty;
        }

        private bool EndsWithOpenBracket(string input)
        {
            return input.EndsWith("[");
        }

        private bool StartsWithCloseBracket(string input)
        {
            return input.StartsWith("]");
        }

        private bool IsEvenNumberOfBrackets(string input)
        {
            return input.Length % 2 == 0;
        }
    }
}