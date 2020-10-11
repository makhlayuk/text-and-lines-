using System;
using System.Collections;
using System.Collections.Generic;

namespace text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string[] textM;
            string text = Console.ReadLine();
            textM = text.Split('.', ',', '?', '!', ':', ';', '-', '"', '(', ')');
            Console.WriteLine("Количество знаков препинания:" + (textM.Length - 1));

            string[] sentence = text.Split(new char[] { '!', '.', '?' });              //Разбиваем текст на предложения
            foreach (string newSentence in sentence)
            {
                Console.WriteLine(newSentence);
            }

            string MaxLength = string.Empty;                                           //Выводим самое длинное слово
            string[] words = text.Split(' ', '.', ',', '?', '!', ':', ';', '-', '"', '(', ')');
            for (int i = 0; i < words.Length; i++)
                if (words[i].Length > MaxLength.Length)
                    MaxLength = words[i];
            Console.WriteLine("Самое длинное слово: " + MaxLength);

            int wordL = MaxLength.Length;                                              //Четная длина слова
            if (wordL % 2 == 0)
            {
                MaxLength = MaxLength.Substring(wordL/2);
                Console.WriteLine("Слово четно: " + MaxLength);
            }
            else
            {
                MaxLength = MaxLength.Replace(MaxLength[wordL / 2], '*');             //Нечетная длина слова
                Console.WriteLine("Слово нечетно: " + MaxLength);
            }

            List<string> uniqueWords = new List<string>();
            foreach (string unique in words)
            {
                if (!uniqueWords.Contains(unique))
                    uniqueWords.Add(unique);
                Console.WriteLine(unique);
            }





        }
    }
}
