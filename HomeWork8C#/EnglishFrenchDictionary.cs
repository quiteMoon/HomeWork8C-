using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8C_
{
    internal class EnglishFrenchDictionary
    {
        private Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

        public void AddWord(string englishWord, List<string> frenchTranslations)
        {
            if (dictionary.ContainsKey(englishWord))
            {
                Console.WriteLine("Це слово вже існує.");
            }
            else
            {
                dictionary[englishWord] = frenchTranslations;
                Console.WriteLine("Слово успішно додано.");
            }
        }

        public void RemoveWord(string englishWord)
        {
            if (dictionary.Remove(englishWord))
            {
                Console.WriteLine("Слово успішно видалено.");
            }
            else
            {
                Console.WriteLine("Слово не знайдено.");
            }
        }

        public void RemoveTranslation(string englishWord, string frenchTranslation)
        {
            if (dictionary.ContainsKey(englishWord))
            {
                if (dictionary[englishWord].Remove(frenchTranslation))
                {
                    Console.WriteLine("Переклад успішно видалено.");
                }
                else
                {
                    Console.WriteLine("Переклад не знайдено.");
                }
            }
            else
            {
                Console.WriteLine("Слово не знайдено.");
            }
        }

        public void UpdateWord(string oldWord, string newWord)
        {
            if (dictionary.ContainsKey(oldWord))
            {
                dictionary[newWord] = dictionary[oldWord];
                dictionary.Remove(oldWord);
                Console.WriteLine("Слово успішно оновлено.");
            }
            else
            {
                Console.WriteLine("Слово не знайдено.");
            }
        }

        public void UpdateTranslation(string englishWord, string oldTranslation, string newTranslation)
        {
            if (dictionary.ContainsKey(englishWord))
            {
                List<string> translations = dictionary[englishWord];
                int index = translations.IndexOf(oldTranslation);
                if (index != -1)
                {
                    translations[index] = newTranslation;
                    Console.WriteLine("Переклад успішно оновлено.");
                }
                else
                {
                    Console.WriteLine("Переклад не знайдено.");
                }
            }
            else
            {
                Console.WriteLine("Слово не знайдено.");
            }
        }

        public void GetTranslations(string englishWord)
        {
            if (dictionary.TryGetValue(englishWord, out List<string> translations))
            {
                Console.WriteLine($"Переклади для слова '{englishWord}': {string.Join(", ", translations)}");
            }
            else
            {
                Console.WriteLine("Слово не знайдено.");
            }
        }
    }
}
