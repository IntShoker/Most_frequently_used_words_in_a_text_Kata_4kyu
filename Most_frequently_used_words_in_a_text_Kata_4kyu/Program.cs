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
            //list<string> a = new list<string>();
            Regex regex = new Regex(@"\b(\w)+");
            MatchCollection matches = regex.Matches(s);
            //if (matches.count > 1)
            //{
            //    foreach (match match in matches)
            //    {
            //        a.add(match.tostring());
            //    }
            //}
            List<string> a = new List<string>();
             a = (List<string>)matches.GroupBy(c => c.ToString()).Where(f=>f.Count()>1).Select(d => d.Key).ToList();
            foreach (string item in a)
            {
                Console.WriteLine(item);
            }
            return a;
            
        }
        static void Main(string[] args)
        {

            string text = "ab ba ab db db db ab ba c s d f g";
            Top3(text);
            //foreach (string item in top3(text))
            //{
            //    console.writeline(item);
            //}
            
            
        }
    }
}
