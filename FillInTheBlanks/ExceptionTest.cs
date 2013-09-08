using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FillInTheBlanks
{
    // -----------------------------------------------------------------------------
    // Hint: replace all blanks, "__", with a value that will make the tests pass.
    // -----------------------------------------------------------------------------

    [TestClass]
    public class ExceptionTest : Blank
    {
        [TestMethod]
        [ExpectedException(typeof (ArgumentNullException))]
        public void expect_an_exception_with_property()
        {
            // Hint: adjust the type of exception to make the test pass.
            new ExceptionThrower().Throw();
        }

        [TestMethod]
        public void expect_an_exception_with_try_catch()
        {
            try
            {
                new ExceptionThrower().Throw();
                Assert.Fail("Expected an ArgumentException");
            }
            catch (ArgumentException expected)
            {
                Assert.AreEqual(__, expected.Message);
            }
        }

        private class ExceptionThrower
        {
            public void Throw()
            {
                throw new ArgumentException("testing");
            }
        }
    }
}