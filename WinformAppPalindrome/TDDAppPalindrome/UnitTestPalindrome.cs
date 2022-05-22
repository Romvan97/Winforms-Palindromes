using BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TDDAppPalindrome
{
    [TestClass]
    public class UnitTestPalindrome
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMotUneLettreResultThowException()
        {

            // Arrangement (préparer les variables à utiliser

            string word = "a";
            BLLPalindrome myPalindrome = new BLLPalindrome();

            // Action

            bool result = myPalindrome.IsPalindrome(word);

            // Assert (affirmation)

            // Erreur donc pas d'affirmation 

        }
        public void TestMotDeuxLettreResultOK()
        {

            // Arrangement (préparer les variables à utiliser

            string word = "aa";
            BLLPalindrome myPalindrome = new BLLPalindrome();

            // Action

            bool result = myPalindrome.IsPalindrome(word);

            // Assert (affirmation)

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void TestMotDeuxLettreResultNOK()
        {

            // Arrangement (préparer les variables à utiliser

            string word = "ab";
            BLLPalindrome myPalindrome = new BLLPalindrome();

            // Action

            bool result = myPalindrome.IsPalindrome(word);

            // Assert (affirmation)

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void TestMotTroisLettreResultOK()
        {

            // Arrangement (préparer les variables à utiliser

            string word = "aba";
            BLLPalindrome myPalindrome = new BLLPalindrome();

            // Action

            bool result = myPalindrome.IsPalindrome(word);

            // Assert (affirmation)

            Assert.IsTrue(result);

        }
        [TestMethod]
        public void TestMotTroisLettreResultNOK()
        {

            // Arrangement (préparer les variables à utiliser

            string word = "abc";
            BLLPalindrome myPalindrome = new BLLPalindrome();

            // Action

            bool result = myPalindrome.IsPalindrome(word);

            // Assert (affirmation)

            Assert.IsFalse(result);

        }
        public void TestMotQuattreLettreResultOK()
        {

            // Arrangement (préparer les variables à utiliser

            string word = "elle";
            BLLPalindrome myPalindrome = new BLLPalindrome();

            // Action

            bool result = myPalindrome.IsPalindrome(word);

            // Assert (affirmation)

            Assert.IsTrue(result);

        }
        public void TestMotQuattreLettreResultNOK()
        {

            // Arrangement (préparer les variables à utiliser

            string word = "abcd";
            BLLPalindrome myPalindrome = new BLLPalindrome();

            // Action

            bool result = myPalindrome.IsPalindrome(word);

            // Assert (affirmation)

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void BugWord_ère()
        {
            // Arrangement (préparer les variables à utiliser
            string word = "ère";
                BLLPalindrome myPalindrome = new BLLPalindrome();
            // Action

            bool result = myPalindrome.IsPalindrome(word);

            // Assert (affirmation)

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void BugWord_arfa()
        {
            // Arrangement (préparer les variables à utiliser
            string word = "arfa";
            BLLPalindrome myPalindrome = new BLLPalindrome();
            // Action

            bool result = myPalindrome.IsPalindrome(word);

            // Assert (affirmation)

            Assert.IsFalse(result);

        }

        [TestMethod]
        [DataRow("réifier")]
        [DataRow("réer")]
        [DataRow("taxât")]
        public void BugWord_Accents(string pAccentedWord)
        {
            // Arrangement (préparer les variables à utiliser
            string word = pAccentedWord;
            BLLPalindrome myPalindrome = new BLLPalindrome();
            // Action

            bool result = myPalindrome.IsPalindrome(word);

            // Assert (affirmation)

            Assert.IsTrue(result);

        }


    }
}