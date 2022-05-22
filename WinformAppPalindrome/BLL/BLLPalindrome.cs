using DAL;

namespace BLL
{
    public class BLLPalindrome
    {

        public static IList<string> SeekPalindrome(string pFileName)
        {

            DALPalindrome myDal = new DALPalindrome();
            string readText = myDal.ReadFile(pFileName);

            IList<string> palindromes = ExtractPalindromesByCleaning(readText);
            return palindromes;
        }

        private static IList<string> ExtractPalindromesByCleaning(string readText)
        {

            string[] lines = readText.Split("\n", StringSplitOptions.TrimEntries);
            IList<string> palindromes = new List<string>();
            foreach (string item in lines)

            {
                string[] Words = item.Split(',', '(', ' ');
                palindromes.Add(Words[0]);
            }

            return palindromes;

        }

        public bool IsPalindrome(string? word)
        {  
            // test de garde
            if (word.Length == 1 || word  is null) throw new ArgumentException();
            
            string cleanWord = CleanAccents(word);

          

            for (int indexAscending = 0; indexAscending < cleanWord.Length / 2; indexAscending++)
            {
                int indexDescending = cleanWord.Length - (indexAscending + 1);
                if (cleanWord[indexAscending] != cleanWord[indexDescending])
                {
                   // return false;
                   throw new PalindromeException(cleanWord, cleanWord[indexAscending], cleanWord[indexDescending]); 
                }
            }

            return true;
        }

        private static string CleanAccents(string? word)
        {
            string cleanWord = word.Replace('è', 'e');
            cleanWord = cleanWord.Replace('ê', 'e');
            cleanWord = cleanWord.Replace('é', 'e');
            cleanWord = cleanWord.Replace('â', 'a');
            return cleanWord;
        }
    }
}