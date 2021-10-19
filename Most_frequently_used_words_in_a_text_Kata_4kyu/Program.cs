using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Most_frequently_used_words_in_a_text_Kata_4kyu
{
    //Напишите функцию, которая по заданной строке текста (возможно, с пунктуацией и переносами строк) возвращает массив из трех наиболее часто встречающихся слов в порядке убывания количества вхождений.
    class Program
    {
        public static List<string> Top3(string s)
        {
            
            Regex regex = new Regex(@"\b(\w+)(\')?(\S+)?(\w+)?");
            MatchCollection matches = regex.Matches(s);
            List<string> a = new List<string>();
            List<string> b = new List<string>();
            a = (List<string>)matches.GroupBy(c => c.ToString().
            ToLower()).Where(f=>f.Count()>0).OrderByDescending(f=>f.Count()).
            Select(d => d.Key).ToList();
            
            for(int i = 0; i < a.Count && i < 3; i++)
            {
                b.Add(a[i]);
            }
            return b;
            
        }
        static void Main(string[] args)
        {

            string text = "  wont won't won't ";
            Top3(text);
            foreach (string item in Top3(text))
            {
                Console.WriteLine(item);
            }


        }
    }
}
