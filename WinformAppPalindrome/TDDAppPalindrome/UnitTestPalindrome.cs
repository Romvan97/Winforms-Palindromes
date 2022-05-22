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

            // Arrangement (pr�parer les variables � utiliser

            string word = "a";
            BLLPalindrome myPalindrome = new BLLPalindrome();

            // Action

            bool result = myPalindrome.IsPalindrome(word);

            // Assert (affirmation)

            // Erreur donc pas d'affirmation 

        }
        public void TestMotDeuxLettreResultOK()
        {

            // Arrangement (pr�parer les variables � utiliser

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

            // Arrangement (pr�parer les variables � utiliser

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

            // Arrangement (pr�parer les variables � utiliser

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

            // Arrangement (pr�parer les variables � utiliser

            string word = "abc";
            BLLPalindrome myPalindrome = new BLLPalindrome();

            // Action

            bool result = myPalindrome.IsPalindrome(word);

            // Assert (affirmation)

            Assert.IsFalse(result);

        }
        public void TestMotQuattreLettreResultOK()
        {

            // Arrangement (pr�parer les variables � utiliser

            string word = "elle";
            BLLPalindrome myPalindrome = new BLLPalindrome();

            // Action

            bool result = myPalindrome.IsPalindrome(word);

            // Assert (affirmation)

            Assert.IsTrue(result);

        }
        public void TestMotQuattreLettreResultNOK()
        {

            // Arrangement (pr�parer les variables � utiliser

            string word = "abcd";
            BLLPalindrome myPalindrome = new BLLPalindrome();

            // Action

            bool result = myPalindrome.IsPalindrome(word);

            // Assert (affirmation)

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void BugWord_�re()
        {
            // Arrangement (pr�parer les variables � utiliser
            string word = "�re";
                BLLPalindrome myPalindrome = new BLLPalindrome();
            // Action

            bool result = myPalindrome.IsPalindrome(word);

            // Assert (affirmation)

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void BugWord_arfa()
        {
            // Arrangement (pr�parer les variables � utiliser
            string word = "arfa";
            BLLPalindrome myPalindrome = new BLLPalindrome();
            // Action

            bool result = myPalindrome.IsPalindrome(word);

            // Assert (affirmation)

            Assert.IsFalse(result);

        }

        [TestMethod]
        [DataRow("r�ifier")]
        [DataRow("r�er")]
        [DataRow("tax�t")]
        public void BugWord_Accents(string pAccentedWord)
        {
            // Arrangement (pr�parer les variables � utiliser
            string word = pAccentedWord;
            BLLPalindrome myPalindrome = new BLLPalindrome();
            // Action

            bool result = myPalindrome.IsPalindrome(word);

            // Assert (affirmation)

            Assert.IsTrue(result);

        }


    }
}