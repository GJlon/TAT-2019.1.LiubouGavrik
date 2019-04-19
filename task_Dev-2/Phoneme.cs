using System;

namespace task_Dev_2
{
    /// <summary>
    /// The Phoneme class is used to create word phonemes.
    /// </summary>
    class Phoneme
    {
        /// <summary>
        /// "phoneme" to record the phoneme received the words
        /// </summary>
        string phoneme;
        /// <summary>
        /// last symbol of string
        /// </summary>
        char lastsymbol;
        /// <summary>
        /// first symbol of string
        /// </summary>
        char firstsymbol;
        string pairVoicedConsonants = "бвгджз";
        string voicedConsonants = "лмнрй";
        string pairDeafConsonants = "пфктшс";
        string emollientVowels = "юяёе";
        string notEmollientVowels = "уаоэьъ";
        string englishLetters = "abcdefghijklmnopqrstuvwxyz";
        string symbol = "ь";

        public Phoneme(string originalString)
        {
            this.phoneme = originalString;
        }
        
        /// <summary>
        /// check for english letters
        /// </summary>
        public void CheckingEnglishLetters()
        {
            for(int i=0; i<phoneme.Length-1; i++)
            {
                if (englishLetters.IndexOf(phoneme[i]) != -1)
                {
                    throw new FormatException("Error! You should write only russian letters");
                }
            }
        }
        
        /// <summary>
        /// check for "+" position
        /// </summary>
        public void CheckingPositionOfPlus()
        {
            int onePlus = phoneme.IndexOf('+');
            int otherPlus= phoneme.LastIndexOf('+');
            
            if (onePlus != otherPlus)
            {
                throw new FormatException("Error! You should write only one '+' ");
            }                                                     
        }
        
        /// <summary>
        /// the method that looks for a shock vowel position
        /// </summary>
        public void FindShockPosition()
        {
            //
            int onePlus = phoneme.IndexOf('+');
            int otherPlus= phoneme.LastIndexOf('+');
            
            if (onePlus!=-1 && otherPlus!=-1 && onePlus == otherPlus)
            {
                int indexOfShockPosition = phoneme.IndexOf('+') - 1;
                ChangeHarmonyVowels(indexOfShockPosition);
            }
            
            if(onePlus==-1 && otherPlus==-1)
            {
                int indexOfShockPosition = phoneme.IndexOf('ё');
                ChangeHarmonyVowels(indexOfShockPosition);
            }
        }
        
        /// <summary>
        /// method that performs the replacement of unstressed "о" to "а"
        /// </summary>
        /// <param name="i"></param>
        public void ChangeHarmonyVowels(int i)
        {
            char vowel = phoneme[i];
            phoneme = phoneme.Replace("о", "а");
            phoneme = phoneme.Remove(i, 1);
            phoneme = phoneme.Insert(i, vowel.ToString());
        }
        
        /// <summary>
        /// works with vowels at the beginning of a word, vowels after vowels and "ъ ь" 
        /// </summary>
        /// <param name="l"></param>
        public void WorkWithVowels(ref int l)
        {
            firstsymbol = phoneme[0];
            //find whether the first letter of the word is in the line with emollient vowels
            int indexOfSubstring = emollientVowels.IndexOf(firstsymbol);
            
            if (emollientVowels.IndexOf(firstsymbol) != -1)
            {
                phoneme = phoneme.Remove(0, 1);
                char insertSymbol = notEmollientVowels[indexOfSubstring];
                phoneme = phoneme.Insert(0,"й"+ insertSymbol.ToString());
            }
            
            for (int i = 0; i < l - 1; i++)
            {
                int index = emollientVowels.IndexOf(phoneme[i+1]);
                
                if (emollientVowels.IndexOf(phoneme[i]) != -1 && emollientVowels.IndexOf(phoneme[i + 1]) != -1)
                {
                    char insertSymbol = notEmollientVowels[index];
                    phoneme = phoneme.Remove(i + 1, 1);
                    phoneme = phoneme.Insert(i + 1, "й" + insertSymbol.ToString());               
                }
                
                if ((notEmollientVowels.IndexOf(phoneme[i]) != -1) && (emollientVowels.IndexOf(phoneme[i + 1]) != -1))
                {
                    char insertSymbol = notEmollientVowels[index];
                    phoneme = phoneme.Remove(i + 1, 1);
                    phoneme = phoneme.Insert(i + 1, "й" + insertSymbol.ToString());
                    l++;
                }
            }
        }
        
        /// <summary>
        /// method in which vowels soften a previous consonant sound
        /// </summary>
        /// <param name="l"></param>
        public void SofteningOfTheConsonant(ref int l)
        {
            for (int i = 0; i < l - 1; i++)
            {
                /*introduced new variables to reduce the condition record*/
                int index = emollientVowels.IndexOf(phoneme[i + 1]);
                int newIndex = symbol.IndexOf(phoneme[i + 1]);
                int indexA = pairVoicedConsonants.IndexOf(phoneme[i]);
                int indexB = pairDeafConsonants.IndexOf(phoneme[i]);
                int indexC = voicedConsonants.IndexOf(phoneme[i]);
                
                if ((indexA != -1 || indexB != -1 || indexC != -1) && (index != -1 ))
                {
                    char insertSymbol = notEmollientVowels[index];
                    phoneme = phoneme.Remove(i+1, 1);
                    phoneme = phoneme.Insert(i+1, "'" + insertSymbol.ToString());
                    l++;
                }
                
                if ((indexA != -1 || indexB != -1 || indexC != -1) && newIndex != -1)
                {
                    char insertSymbol = notEmollientVowels[newIndex];
                    phoneme = phoneme.Remove(i + 1, 1);
                    phoneme = phoneme.Insert(i + 1, "'");
                }
            }
        }
        
        /// <summary>
        /// consonant abbreviation
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        public void VoicingConsonants(ref int l)
        {
            for (int i = 0; i < l - 1; i++)
            {
                int index = pairDeafConsonants.IndexOf(phoneme[i]);
                
                if (pairDeafConsonants.IndexOf(phoneme[i]) != -1 && pairVoicedConsonants.IndexOf(phoneme[i+1]) != -1)
                {
                    char insertSymbol = pairVoicedConsonants[index];
                    phoneme = phoneme.Remove(i, 1);
                    phoneme = phoneme.Insert(i, insertSymbol.ToString());
                }
            }
        }
        
        /// <summary>
        /// method of stunning consonants, at the end and in the middle
        /// </summary>
        /// <param name="l"></param>
        public void StunningConsonants(ref int l)
        {
            //find whether the last letter of the word is in the line with paired voiced consonants
            lastsymbol = phoneme[l - 1];
            int indexOfLastSymbol = pairVoicedConsonants.IndexOf(lastsymbol);
            
            if (indexOfLastSymbol != -1)
            {
                //access line item
                char insertSymbol = pairDeafConsonants[indexOfLastSymbol];
                phoneme = phoneme.Remove(l - 1, 1);
                phoneme = phoneme.Insert(l - 1, insertSymbol.ToString());
            }
            
            for (int i = 0; i < l - 1; i++)
            {
                int index = pairVoicedConsonants.IndexOf(phoneme[i]);
                
                if (pairVoicedConsonants.IndexOf(phoneme[i]) != -1 && pairDeafConsonants.IndexOf(phoneme[i+1]) != -1 )
                {
                    char insertSymbol = pairDeafConsonants[index];
                    phoneme = phoneme.Remove(i, 1);
                    phoneme = phoneme.Insert(i, insertSymbol.ToString());
                }
            }
        }
        
        /// <summary>
        /// find plus position
        /// </summary>
        public void FindPlusPosition()
        {
            int indexOfPlusPosition = phoneme.IndexOf('+');
            phoneme = phoneme.Remove(indexOfPlusPosition, 1);

        }
        
        /// <summary>
        /// method used to transfer phonemes to Main(...)
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        public string ReturnString(int l)
        {
            FindShockPosition();
            WorkWithVowels(ref l);
            SofteningOfTheConsonant(ref l);
            VoicingConsonants(ref l);
            StunningConsonants(ref l);
            FindPlusPosition();

            return phoneme;
        }
    }
}
