using NUnit.Framework;

namespace Brackets.Parser.Tests
{
    [TestFixture]
    public class BracketsParserTests
    {
        [Test]
        public void VerifyBracketsAreBalanced_WhenEmptyString_ShouldReturnOk()
        {
            //---------------Arrange-------------------
            var input = string.Empty;
            var expected = "Ok";
            var parser = new BracketsParser();
            //---------------Act ----------------------
            var result = parser.VerifyBracketsAreBalanced(input);
            //---------------Assert -----------------------
            Assert.AreEqual(expected, result);
        }

        [TestCase("[")]
        [TestCase("]")]
        public void VerifyBracketsAreBalanced_WhenSingleBracket_ShouldReturnFail(string input)
        {
            //---------------Arrange-------------------
            var expected = "Fail";
            var parser = new BracketsParser();
            //---------------Act ----------------------
            var result = parser.VerifyBracketsAreBalanced(input);
            //---------------Assert -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void VerifyBracketsAreBalanced_WhenPairOfUnbalancedBrackets_ShouldReturnFail()
        {
            //---------------Arrange-------------------
            var input = "][";
            var expected = "Fail";
            var parser = new BracketsParser();
            //---------------Act ----------------------
            var result = parser.VerifyBracketsAreBalanced(input);
            //---------------Assert -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void VerifyBracketsAreBalanced_WhenUnclosedNestedBrackets_ShouldReturnFail()
        {
            //---------------Arrange-------------------
            var input = "[[]";
            var expected = "Fail";
            var parser = new BracketsParser();
            //---------------Act ----------------------
            var result = parser.VerifyBracketsAreBalanced(input);
            //---------------Assert -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void VerifyBracketsAreBalanced_WhenPairOfBalancedBrackets_ShouldReturnOk()
        {
            //---------------Arrange-------------------
            var input = "[]";
            var expected = "Ok";
            var parser = new BracketsParser();
            //---------------Act ----------------------
            var result = parser.VerifyBracketsAreBalanced(input);
            //---------------Assert -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void VerifyBracketsAreBalanced_WhenNestedBalancedBrackets_ShouldReturnOk()
        {
            //---------------Arrange-------------------
            var input = "[[]]";
            var expected = "Ok";
            var parser = new BracketsParser();
            //---------------Act ----------------------
            var result = parser.VerifyBracketsAreBalanced(input);
            //---------------Assert -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void VerifyBracketsAreBalanced_WhenDoublyNestedSetOfBalancedBrackets_ShouldReturnOk()
        {
            //---------------Arrange-------------------
            var input = "[[[][]]]";
            var expected = "Ok";
            var parser = new BracketsParser();
            //---------------Act ----------------------
            var result = parser.VerifyBracketsAreBalanced(input);
            //---------------Assert -----------------------
            Assert.AreEqual(expected, result);
        }
    }
}
