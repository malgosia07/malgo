using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab_6__Metody_rozszerzające
{
    public static class StringExtensions
    {
        public static string ToUpperAndLower(this string word)
        {
            string text = "";
            if (word.Length > 0)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        text += word.ToUpper().ElementAt(i);
                    }
                    else 
                        text += word.ToLower().ElementAt(i);
                }
            }return text;
        }

        public static string UpperEveryFirstLetterOfWord(this string word)
        {
            return Regex.Replace(word, @"(^\w)|(\s\w)", x => x.Value.ToUpper());
        }

        public static string VowelsRemove(this string word) 
        {
            return Regex.Replace(word, @"([A,E,I,O,U,Y])|([a,e,i,o,u,y])", " ");
        }

        public static int WordCount(this string word)
        {
            return word.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static bool Sentence (this string word)
        {
            if (word.Any(char.IsUpper) && word.EndsWith("."))

                return true;
            else
                return false;
        }

        public static char MostAparitionsLetter(this string word)
        {
            return word.GroupBy(x => x).OrderByDescending(x => x.Count()).Select(g => g.Key).First();
        }
    }
}
