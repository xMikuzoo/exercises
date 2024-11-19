using System;
using System.Collections.Generic;
using System.Linq;

namespace Is_my_freidn_cheating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var x = Mix2(" In many languages", "there's a pair of functions");
            var x = Mix2("Are the kids at home? aaaaa fffff", "Yes they are here! aaaaa fffff");
            Console.WriteLine(Mix2(" In many languages", "there's a pair of functions") == "1:aaa/1:nnn/1:gg/2:ee/2:ff/2:ii/2:oo/2:rr/2:ss/2:tt" ? "Działa" : "Nie działa");
        }

        public static string Mix2(string s1, string s2)
        {
            var dic = new Dictionary<char, Tuple<int, int>>();
            foreach (char letter in s1.Replace(" ", ""))
            {
                if (!char.IsLetter(letter) || !char.IsLower(letter)) {
                    continue;
                }
                if (!dic.ContainsKey(letter))
                {
                    dic[letter] = new Tuple<int, int>(1, 0);
                }
                else
                {
                    var x = dic[letter];
                    dic[letter] = new Tuple<int, int>(x.Item1 + 1, x.Item2);
                }
            }

            foreach (char letter in s2.Replace(" ", ""))
            {
                if (!char.IsLetter(letter) || !char.IsLower(letter))
                
                    {
                    continue;
                }
                if (!dic.ContainsKey(letter))
                {
                    dic[letter] = new Tuple<int, int>(0, 1);
                }
                else
                {
                    var x = dic[letter];
                    dic[letter] = new Tuple<int, int>(x.Item1, x.Item2 + 1);
                }
            }
            var z = dic.Select(x => new
            {
                Char = x.Key,
                S = x.Value.Item1 == x.Value.Item2 ? "=" : x.Value.Item1 > x.Value.Item2 ? "1" : "2",
                Count = x.Value.Item1 > x.Value.Item2 ? x.Value.Item1 : x.Value.Item2,
            })
                .Where(x => x.Count > 1)
                .OrderByDescending(x => x.Count)
                .ThenBy(x => x.S == "=" ? 1 : 0)
                .ThenBy(x => x.S)
                .ThenBy(x => x.Char);

            var str = new List<string>();
            foreach (var x in z) {
                str.Add($"{x.S}:{new string(x.Char, x.Count)}");
            }

            return string.Join("/", str.ToArray());
        }

        //jakiegosgoscia
        //public static string MixGoscia(string s1, string s2)
        //{
        //    //get only lowercase chars and order alphabetically
        //    char[] sortedS1 = s1.Where(l => Char.IsLower(l)).OrderBy(a => a).ToArray();
        //    char[] sortedS2 = s2.Where(l => Char.IsLower(l)).OrderBy(a => a).ToArray();

        //    //create string builder to hold results
        //    StringBuilder sb = new StringBuilder();

        //    //identify each letter and count its instances
        //    for (int i = 97; i < 122; i++)
        //    {

        //        char[] sameChars1 = s1.Where(c => c.Equals((char)i)).ToArray();
        //        char[] sameChars2 = s2.Where(c => c.Equals((char)i)).ToArray();
        //        int countS1 = sameChars1.Length;
        //        int countS2 = sameChars2.Length;

        //        //check who has more of the character
        //        if (countS1 > countS2)
        //        {
        //            string newS1 = new String(sameChars1);
        //            sb.Append("1:" + newS1 + "/");

        //        }
        //        else if (countS2 > countS1)
        //        {
        //            string newS2 = new String(sameChars2);
        //            sb.Append("2:" + newS2 + "/");
        //        }
        //        else if (countS1 == countS2)
        //        {
        //            string newS = new String(sameChars2);
        //            sb.Append("=:" + newS + "/");
        //        }

        //    }
        //    //create final string output
        //    string result = "";
        //    string[] mySb = sb.ToString().Split('/');


        //    //Taking only what has more than 1 character and sorting with priority to length then type then alphabetical order 
        //    result = String.Join("/", mySb);
        //    mySb = result.Split('/').Where(x => x.Length > 3).Select(x => x)
        //                            .OrderByDescending(x => x.Length).ThenBy(x => x[0])
        //                            .ThenBy(x => x).ToArray();

        //    //output
        //    result = String.Join("/", mySb);
        //    return result;
        //}
    }
}
