using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
//а) Вывести только те слова сообщения,  которые содержат не более n букв.
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//в) Найти самое длинное слово сообщения.
//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
//д) *** Создать метод, который производит частотный анализ текста.В качестве параметра в него передается массив слов и текст, 
//    в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.Здесь требуется использовать класс Dictionary.
//4) * Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
// Например:
//badc являются перестановкой abcd.
//      Черников Олег
namespace hm5ex2
{
    static class Message
    {
        private static char[] charsToTrim = { ';', '.', ',', ':', '-', '!' };
        private static string[] userMesArr;
        private static string userMessage;

        public static string CountWords(string message, int max)
        {
            userMessage = String.Empty;
            userMesArr = message.Split(' ');
            for (int i = 0; i < userMesArr.Length; i++)
            {
                userMesArr[i] = userMesArr[i].Trim(charsToTrim);
                if (userMesArr[i].Length <= max)
                    userMessage += $"{userMesArr[i].ToLower()} ";
            }
            return userMessage;
        }

        public static string DeleteWords(string message, char el)
        {
            userMessage = String.Empty;
            userMesArr = message.Split(' ');
            for (int i = 0; i < userMesArr.Length; i++)
            {
                if (Char.ToLower(userMesArr[i][0]) == el)
                    userMesArr[i] = String.Empty;
                userMessage += $"{userMesArr[i]} ";
            }
            return userMessage;
        }

        public static string LongestWord(string message)
        {
            int strLen = 0;
            userMessage = String.Empty;
            userMesArr = message.Split(' ');
            for (int i = 0; i < userMesArr.Length; i++)
            {
                userMesArr[i] = userMesArr[i].Trim(charsToTrim).ToLower();
                if (userMesArr[i].Length > strLen)
                {
                    userMessage = String.Empty;
                    strLen = userMesArr[i].Length;
                    userMessage += $"{userMesArr[i]} ";
                }
                else if(userMesArr[i].Length == strLen)
                    userMessage += $"{userMesArr[i]} ";
            }
            return userMessage;
        }

        public static string FreqTextAnalisis(string message, string[] userWordsArr)
        {
            string result = "";
            userMesArr = message.Split(' ');
            Dictionary<string, int> wordFreq = new Dictionary<string, int>();
            for (int i = 0; i < userMesArr.Length; i++)
            {
                userMesArr[i] = userMesArr[i].ToLower().Trim(charsToTrim);
                for (int j = 0; j < userWordsArr.Length; j++)
                {
                    if (userMesArr[i] == userWordsArr[j])
                    {
                        if (wordFreq.ContainsKey(userWordsArr[j]))
                            wordFreq[userWordsArr[j]]++;
                        else
                            wordFreq.Add(userWordsArr[j], 1);
                    }
                }
            }

            foreach (var pair in wordFreq)
                result += $"Word {pair.Key} occured {pair.Value} times\n";
            return result;
        }

        public static bool IsStringsSame(string messageFirst, string messageSecond) //example 4
        {
            char[] mesFirChar = messageFirst.ToCharArray();
            char[] mesSecChar = messageSecond.ToCharArray();
            Array.Sort<char>(mesFirChar);
            Array.Sort<char>(mesSecChar);
            if (mesFirChar.Length == mesSecChar.Length)
            {
                for (int i = 0; i < mesFirChar.Length; i++)
                    if (mesFirChar[i] != mesSecChar[i])
                        return false;
            }
            else
                return false;
            return true;

        }
    }
}
