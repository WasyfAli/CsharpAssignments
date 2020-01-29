using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment_Four
{  
    class Program
    {
        static void Main(string[] args)
        {
            var words = new List<string>();
            words.Add("Boat");
            words.Add("house");
            words.Add("cat");
            words.Add("river");
            words.Add("cupboard");

            Plurals p_obj = new Plurals();
            foreach (var a in words)
                p_obj.Plurals_of_words(a);

            words[words.FindIndex(ind => ind.Equals("house"))] = "Home";

            Console.WriteLine();
            p_obj.Plurals_of_words(words[1]);

            words.Add("cabaret");
            words.Add("habitat");
            words.Add("laptop");
            words.Add("season");

            Console.WriteLine();
            Console.WriteLine(words.Count);
            Console.WriteLine();
            foreach (var b in words)
            {
                if (b.Length == 7)
                    Console.WriteLine(b);
            }

            Console.WriteLine();
            Console.WriteLine(words[2]);
            Console.WriteLine();

            words.Sort();
            foreach (var c in words)
                Console.WriteLine(c);

            Console.WriteLine();
            words.Reverse();
            foreach (var d in words)
                Console.WriteLine(d);
        }
    }
}
// Boat, house, cat, river, cupboard