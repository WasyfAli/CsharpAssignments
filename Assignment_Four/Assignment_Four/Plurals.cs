using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Four
{
    public class Plurals
    {
        public void Plurals_of_words(string w)
        {
            int l = w.Length;
            char[] alpha = w.ToCharArray();

            if (alpha[l - 1] == 'y')
            {

                alpha[l - 1] = 'i';
                alpha[l] = 'e';
                alpha[l + 1] = 's';
                alpha[l + 2] = '\0';
            }
            else if (alpha[l - 1] == 's' ||
                   (alpha[l - 2] == 'c' && alpha[l - 1] == 'h') ||
                   (alpha[l - 2] == 's' && alpha[l - 1] == 'h'))
            {

                w += "es";
            }

            else
            {
                w += "s";
            }

            Console.WriteLine(w);

            return;
        }
    }
}
