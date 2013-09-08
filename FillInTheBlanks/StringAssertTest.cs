using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FillInTheBlanks
{
    // -----------------------------------------------------------------------------
    // Hint: replace all blanks, "__", with a value that will make the tests pass.
    // -----------------------------------------------------------------------------

    [TestClass]
    public class StringAssertTest : Blank
    {
        // -----------------------------------------------------------------------------
        // Do not change this question.
        // -----------------------------------------------------------------------------
        private const string Question = "Does TDD mean Test-Driven Development " +
                                        "or Test-Driven Design?";

        [TestMethod]
        public void string_contents()
        {
            StringAssert.Contains(Question, __);
        }

        [TestMethod]
        public void string_starts_with()
        {
            StringAssert.StartsWith(Question, __);
        }

        [TestMethod]
        public void string_matches()
        {
            // Hint: add the IgnoreCase option to make the test pass.
            Regex pattern = new Regex("tdd");

            StringAssert.Matches(Question, pattern);
        }
    }
}