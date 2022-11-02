using System;
using System.IO;
using System.Linq;

namespace SentimentAnalysis_LexicalStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            string messagetotest = @"Muchas gracias pero ya tengo un plan";

            string[] positives = File.ReadAllLines("positive_words_es.txt");
            string[] negatives = File.ReadAllLines("negative_words_es.txt");
             
            double positive = 0;
            double negative = 0;

            foreach(string s in messagetotest.Trim().Split(' '))
            {
                if(positives.Any(e=>e.Equals(s.ToLower())))
                {
                    positive = positive + 1;
                }else if (negatives.Any(e => e.Equals(s.ToLower())))
                {
                    negative = negative + 1;
                }
            }
            double score = (positive - negative) / (positive + negative);
            Console.WriteLine(score);
            Console.Read();
        }
    }
}
