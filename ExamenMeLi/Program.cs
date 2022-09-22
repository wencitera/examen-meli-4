using System;
using System.Collections.Generic;

namespace ExamenMeLi
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] dna = new string[] { "AAAAGA", "CAGTGC", "TTATGT", "AGAAGG", "CCCCTA", "TCACTG" };
            List<string[]> strings = new List<string[]>();
            strings.Add(new string[] { "ATGCGA", "CAGTGC", "TTATGT", "AGAAGG", "CCCCTA", "TCACTG" }); //true
            strings.Add(new string[] { "AAAACG", "TTTTGC", "CGGCCC", "CAGACA", "TACCCC", "GGGGAG" }); 
            strings.Add(new string[] { "GTGCGA", "CAGAGC", "TTATGT", "AGAAGG", "CACCTA", "TCACTG" });
            foreach (string[] dna in strings) {
                Console.WriteLine(Functions.IsMutant(dna));
            }
            
            Console.ReadKey();
        }

       
    }
}
