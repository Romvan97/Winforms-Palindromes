using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PalindromeException : Exception
    {
        public string Word { get; private set; }
        public char CharAscendant { get; private set; }
        public char CharDescendant { get; private set; }



        public PalindromeException(string pWord, char pCharAscendent, char pCharDescendant) : this(pWord, pCharAscendent, pCharDescendant, "Palindrome faux") // this appel un constructeur dans la classe
        {

        }
        public PalindromeException(string pWord, char pCharAscendent, char pCharDescendant, string pMessage) : base(pMessage) // appel le constructeur d'une autre class
        {
            // this word est une propriété // pWord est un paramètre qui a été reçu
            this.Word = pWord;
            this.CharAscendant = pCharAscendent;
            this.CharDescendant = pCharDescendant;
        }

    }
}
