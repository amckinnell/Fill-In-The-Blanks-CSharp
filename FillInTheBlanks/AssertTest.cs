using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FillInTheBlanks
{
    // -----------------------------------------------------------------------------
    // Hint: replace all blanks, "__", with a value that will make the tests pass.
    // -----------------------------------------------------------------------------

    [TestClass]
    public class AssertTest : Blank
    {
        [TestMethod]
        public void expected_null_value()
        {
            Assert.IsNull(__);
        }

        [TestMethod]
        public void string_equality()
        {
            Assert.AreEqual("Expected Value", __);
            Assert.AreNotEqual(__, "Actual Value");
        }

        [TestMethod]
        public void numeric_equality()
        {
            Assert.AreEqual(4.5f, __);
        }

        [TestMethod]
        public void numeric_equality_with_delta()
        {
            // Hint: change the size of the delta to make this test pass.
            const double delta = .00001;

            Assert.AreEqual(10/3, 3.333, delta);
        }

        [TestMethod]
        public void reference_equality()
        {
            const Double someValue = 43.8;
            const Double anotherValue = 43.8;

            // Hint: change the assertion method to make this test pass (see failure message).
            Assert.AreSame(someValue, anotherValue);
        }
    }
}