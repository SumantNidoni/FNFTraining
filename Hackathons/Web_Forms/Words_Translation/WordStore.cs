using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebFormsApp
{
    public class WordStore
    {
        private static Dictionary<string, string> wordDictionary = new Dictionary<string, string>();

        public static void Initialize()
        {
            if (wordDictionary.Count == 0)
            {
                wordDictionary.Add("hello", null);
                wordDictionary.Add("world", null);
                wordDictionary.Add("apple", null);
            }
        }

        public static bool Contains(string word) => wordDictionary.ContainsKey(word);

        public static void UpdateTranslation(string word, string translation)
        {
            if (wordDictionary.ContainsKey(word))
                wordDictionary[word] = translation;
        }

        public static List<KeyValuePair<string, string>> GetTranslatedWords()
        {
            return wordDictionary
                .Where(kvp => !string.IsNullOrEmpty(kvp.Value))
                .ToList();
        }

        public static bool Istranslated(string word)
        {
            return wordDictionary.ContainsKey(word) && !string.IsNullOrEmpty(wordDictionary[word]);
        }
    }
}
