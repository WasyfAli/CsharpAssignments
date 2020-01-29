using System;
using System.Collections.Generic;

namespace Assignment_FIve
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> My_dict2 = new Dictionary<int,string>(){
                                {1998,"Atal Bihari Vajpaee"},
                                {2014,"Narendra Modi"},
                                {2004,"Manmohan Singh"} };

            foreach (KeyValuePair<int,string> ele2 in My_dict2)
            {
                if(ele2.Key == 2004)
                    Console.WriteLine("Prime minister of {0} is : {1}",ele2.Key, ele2.Value);
                
            }
            Console.WriteLine("Adding current Prime Minister.");
            My_dict2.Add(2019, "Narendra Modi");
            foreach (KeyValuePair<int, string> ele2 in My_dict2)
            {
                Console.WriteLine("{0} and {1}", ele2.Key, ele2.Value);
            }
            Console.WriteLine("Current Prime Minister added");

            var sort = new SortedDictionary<int, string>(My_dict2);
            Console.WriteLine("Sorting Dictionary");
            foreach (var a in sort)
                Console.WriteLine(a.Key + "      " + a.Value);
            Console.WriteLine("Dictionary has been sorted.");



        }
    }
}
