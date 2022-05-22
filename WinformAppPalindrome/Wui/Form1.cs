using BLL;
using DAL;

namespace Wui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFileChoice_Click(object sender, EventArgs e)
        {
            OpenFileDialog MyOfd = new OpenFileDialog();
            DialogResult result = MyOfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                TxtFileName.Text = MyOfd.FileName;
                IList<string> PalindromesList = BLLPalindrome.SeekPalindrome(MyOfd.FileName);

                LstPalindromes.Items.Clear(); // permet de ne pas ajouter à la suite plusieurs fichier mais quand on ouvre un nouveau il enleve le premier 
                foreach (string Palindrome in PalindromesList)
                {
                    LstPalindromes.Items.Add(Palindrome);
                }
            }
        }

        private void BtnTestAllWords_Click(object sender, EventArgs e)
        {
            LstPalindromeOK.Items.Clear();
            LstPalindromeNOK.Items.Clear();
            BLLPalindrome myPalindrome = new BLLPalindrome();
            foreach (string item in LstPalindromes.Items)
            {
                try
                {
                    bool result = myPalindrome.IsPalindrome(item);
                    if (result == true)
                    {
                        LstPalindromeOK.Items.Add(item);
                    }
                }
                catch (PalindromeException exception)
                {


                    LstPalindromeNOK.Items.Add(item);
                    MessageBox.Show($"erreur : {exception.Message} \n dans {exception.Word} lettre : {exception.CharAscendant} lettre : {exception.CharDescendant}");

                }


            }
        }
    }
}