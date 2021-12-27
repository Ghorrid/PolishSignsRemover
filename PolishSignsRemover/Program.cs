using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolishSignsRemover
{
    internal class Program
    {
        #region descitpion

        //        Zadanie 4:
        //-Stwórz metodę, która przyjmuje 1 wartość tekstową i zwraca wynik, zdanie bez polskich znaków.
        //Przykład:
        //-Dla parametru "Język programowania" zostanie zwrócne "Jezyk programowania".
        //-Dla parametru "Słowa żźśćółęą" zostanie zwrócne "Slowa zzscolea"
        #endregion

        public static string ReplacePolishSigns(string input)
        {
            return input.Replace('ą', 'a').Replace('Ą', 'A').Replace('ć', 'c').Replace('Ć', 'C')
                .Replace('ę', 'e').Replace('Ę', 'E').Replace('ł', 'l').Replace('Ł', 'L').Replace('ń', 'n').Replace('Ń', 'N')
                .Replace('ó', 'o').Replace('Ó', 'O').Replace('ś', 's').Replace('Ś', 'S').Replace('ź', 'z')
                .Replace('Ź', 'Z').Replace('ż', 'z').Replace('Ż', 'Z');
        }

        static void Main(string[] args)
        {
            //-Dla parametru "Język programowania" zostanie zwrócne "Jezyk programowania".
            //-Dla parametru "Słowa żźśćółęą" zostanie zwrócne "Slowa zzscolea"

            Console.WriteLine("Język programowania zamienia na: " + ReplacePolishSigns("Język programowania"));
            Console.WriteLine("Słowa żźśćółęą zamienia na: " + ReplacePolishSigns("Słowa żźśćółęą"));

            Console.ReadKey();

        }
    }
}
