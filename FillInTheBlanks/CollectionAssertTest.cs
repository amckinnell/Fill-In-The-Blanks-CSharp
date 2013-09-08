using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FillInTheBlanks
{

    // -----------------------------------------------------------------------------
    // Hint: replace all blanks, "__", with a value that will make the tests pass.
    // -----------------------------------------------------------------------------

    [TestClass]
    public class CollectionAssertTest : Blank
    {
        // -----------------------------------------------------------------------------
        // Do not change this list of refactorings.
        // -----------------------------------------------------------------------------
        private readonly List<string> refactorings =
            new List<string>() { "Rename Method", "Extract Method", 
                "Inline Method", "Rename Class"};

        [TestMethod]
        public void contains_one_value()
        {
            CollectionAssert.Contains(refactorings, __);
            CollectionAssert.DoesNotContain(refactorings, "Inline Method");
        }

        [TestMethod]
        public void collection_comparision()
        {
            // Hint: remove the extra refactoring to make this test pass.
            List<string> augmentedRefactorings =
                new List<string>() { "Extract Class", "Rename Class", 
                    "Rename Method", "Extract Method", "Inline Method" };

            CollectionAssert.AreEquivalent(refactorings, augmentedRefactorings);

            // Experiment: what happens when you use CollectionAssert.AreEqual() instead?
        }

        [TestMethod]
        public void collection_relationship()
        {
            // Hint: remove the extra refactoring to make this test pass.
            List<string> renameRefactorings =
                new List<string>() { "Rename Class", "Rename Method", "Rename Variable" };

            CollectionAssert.IsSubsetOf(renameRefactorings, refactorings);
        }
    }
}
