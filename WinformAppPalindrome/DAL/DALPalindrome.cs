namespace DAL
{
    public class DALPalindrome
    {
        public string ReadFile(string pFileName)
        {
           return File.ReadAllText(pFileName);
        }
    }
}