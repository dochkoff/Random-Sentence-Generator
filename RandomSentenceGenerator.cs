using System;

namespace RandomSentenceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Peter", "Michell", "Jane", "Steve", "Dave", "Gilbert", "Jorge", "Dan", "Brian", "Liam", "Ethan", "Lewis", "Milton", "Glen", "Antonio", "Connor", "Hunter", "Alberto", "Carlos", "Paul", "Gerald", "Joey", "Johnny", "Scott", "Martin", "Tommy", "Ted", "Nick" };
            string[] plaeces = { "Sofia", "Plovdiv", "Varna", "Burgas", "Stara Zagora", "Veliko Tarnovo", "Yambol", "Haskovo", "Balchik", "Blagoevgrad", "Ruse", "Vidin", "Karlovo", "Kazanluk", "Botevgrad", "Pazardzhik", "Asenovgrad", "Svishtov", "Gorna Oryahovitsa", "Pleven", "Sevlievo", "Gabrovo", "Tryavna", "Troyan", "Elena", "Aitos" };
            string[] verbs = { "eats", "holds", "sees", "plays with", "brings", "builds", "burns", "catches", "draws", "dreams", "finds", "forgets", "freezes", "hides", "keeps", "loses", "puts", "sends", "shows", "takes" };
            string[] nouns = { "stones", "cake", "apple", "laptop", "bikes", "pizza", "car", "fruits", "musical instruments", "animal", "baby", "bridge", "camera", "credit card", "computer", "dad", "facts", "fish", "girl", "glass", "grass", "hand", "head" };
            string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly", "abnormally", "accidentally", "actually", "almost", "always", "beautifully", "carefully", "closely", "correctly", "easily", "elegantly", "eventually", "exactly", "fast", "often", "only for", "safely" };
            string[] detaills = { "near the river", "at home", "in the park", "at work", "near the city", "near the village", "in front of the house", "in the basement", "on the roof", "in the building", "after everything that happened" };

            string[] questionWords = { "Who", "What", "Where", "When", "How" };
            string[] helpingVerbs = { "does", "has" };
            string[] questionVerbs = { "eat", "hold", "see", "play with", "bring", "build", "burns", "catche", "draw", "dream", "find", "forget", "freez", "hide", "keep", "lose", "put", "send", "show", "take" };


            Console.WriteLine("Hello, this is your firs random-generated sentance:");
            while (true)
            {
                Random random = new Random();
                int randomNum = random.Next(1, 10);

                string randomName = GetRandomWord(names);
                string randomAdvedb = GetRandomWord(adverbs);
                string randomDetail = GetRandomWord(detaills);

                if (randomNum % 2 == 0)
                {
                    string randomPlaece = GetRandomWord(plaeces);
                    string randomVerb = GetRandomWord(verbs);
                    string randomNoun = GetRandomWord(nouns);

                    string who = $"{randomName} from {randomPlaece}";
                    string action = $"{randomAdvedb} {randomVerb} {randomNoun}";

                    string declarativeSentence = $"{who} {action} {randomDetail}.";

                    Console.WriteLine(declarativeSentence);
                }
                else
                {
                    string randomQuestionWord = GetRandomWord(questionWords);
                    string randomHelpingVerb = GetRandomWord(helpingVerbs);
                    string randomQuestionVerb = GetRandomWord(questionVerbs);

                    string interrogativeSentence = $"{randomQuestionWord} {randomHelpingVerb} {randomName} {randomQuestionVerb} {randomAdvedb} {randomDetail}?";

                    Console.WriteLine(interrogativeSentence);
                }

                Console.WriteLine("Click [Enter] to genrate new one.");
                Console.WriteLine();
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