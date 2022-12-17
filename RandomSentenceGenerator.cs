using System;

namespace RandomSentenceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Peter", "Michell", "Jane", "Steve" };
            string[] plaeces = { "Sofia", "Plovdiv", "Varna", "Burgas" };
            string[] verbs = { "eats", "holds", "sees", "plays with", "brings" };
            string[] nouns = { "stones", "cake", "apple", "laptop", "bikes" };
            string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };
            string[] detaills = { "near the river", "at home", "in the park" };


            Console.WriteLine("Hello, this is your firs random-generated sentance:");
            while (true)
            {
                string randomName = GetRandomWord(names);
                string randomPlaece = GetRandomWord(plaeces);
                string randomVerb = GetRandomWord(verbs);
                string randomNoun = GetRandomWord(nouns);
                string randomAdvedb = GetRandomWord(adverbs);
                string randomDetail = GetRandomWord(detaills);

                string who = $"{randomName} from {randomPlaece}";
                string action = $"{randomAdvedb} {randomVerb} {randomNoun}";

                string sentance = $"{who} {action} {randomDetail}.";

                Console.WriteLine(sentance);
                Console.WriteLine("Click [Enter] to genrate new one.");
                Console.ReadKey();
            }
        }

        public static string GetRandomWord(string[] words)
        {
            Random random = new Random();
            int randomIndex = random.Next(words.Length);
            string word = words[randomIndex];
            return word;
        }
    }
}