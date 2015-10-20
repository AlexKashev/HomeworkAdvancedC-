using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("text.txt"))
            {
                using (var readerOther = new StreamReader("words.txt"))
                {
                    using (var result = new StreamWriter("result.txt"))
                    {
                        List<string> word = new List<string>();
                        string text = reader.ReadLine();
                        string[] wordsInText = text.ToLower().Split(new string[] { " ", ",", ".", "-", "!" }, StringSplitOptions.RemoveEmptyEntries);
                        string words = readerOther.ReadLine();
                        string[] givenWords = words.Split();
                        int a = 0;

                        for (int i = 0; i < wordsInText.Length; i++)
                        {
                            for (int j = 0; j < givenWords.Length; j++)
                            {
                                if (givenWords[j] == wordsInText[i])
                                {
                                    word.Add(givenWords[j]);
                                }
                            }
                        }
                        Dictionary<string, int> listCount = new Dictionary<string, int>();
                        for (int i = 0; i < word.Count; i++)
                        {
                            if (listCount.ContainsKey(word[i]))
                                listCount[word[i].Trim()] = listCount[word[i].Trim()] + 1;
                            else
                                listCount[word[i].Trim()] = 1;
                        }

                        foreach (var item in listCount.OrderByDescending(i => i.Value))
                        {
                            Console.WriteLine("{0}-{1}",item.Key, item.Value);
                        }
                    }

                }
            }
        }
    }
}
