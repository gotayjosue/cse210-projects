using System;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("3");
        Scripture scripture = new Scripture();
        Word word = new Word();
        
        List<string> options = new List<string> {"Press enter to keep memorizing", "2. Quit"};

        var wordList = word.wordList;

        List<int> randomized_indices = Enumerable.Range(0, wordList.Count).OrderBy(x => Random.Shared.Next()).ToList();

        string answer = "1";

        int do_this_many = 0;
    
        while (true & answer != "2")
        {
            IEnumerable<string> output =
                wordList
                    .Select((word, index) =>
                        randomized_indices
                            .Take(do_this_many)
                            .Contains(index)
                                ? Regex.Replace(word, "[a-zA-Z]", "_")
                                : word);
            
            scripture.GetScripture();
            Console.WriteLine($"{reference.GetVerse()} {String.Join(" ", output)}");
            Console.WriteLine(" ");
            foreach (string a in options) {

                Console.WriteLine(a);
            }
            answer = Console.ReadLine();
            
            
            if (wordList.Count == do_this_many)
                break;
                
            do_this_many += Random.Shared.Next(1, wordList.Count - do_this_many);

            
            
        }


            
        

        
    }
}