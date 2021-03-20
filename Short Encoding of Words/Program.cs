namespace Short_Encoding_of_Words
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        internal static void Main(string[] args)
        {
            string[] teststring = new string[] {  "time", "me", "j" };
            Console.WriteLine("MinimumLengthEncoding(" + string.Join(",", teststring) + "):" + MinimumLengthEncoding(teststring));
        }

        public static int MinimumLengthEncoding(string[] words)
        {
            HashSet<string> good = new HashSet<string>(words);
            foreach (string word in words)
            {
                Console.WriteLine("good:" + string.Join(",", good)+" ("+word+")");
                for (int i = 1; i < word.Length; ++i)
                {
                   
                    good.Remove(word.Substring(i));
                    Console.WriteLine("    good:" + string.Join(",", good)+"("+i+":" + word.Substring(i) + ")");
                }
            }
            int ans = 0;
            foreach (string word in good)
            {
                ans += word.Length + 1;
                Console.WriteLine("ans:" + ans);
            }
            return ans;
            /*int result = words[0].Length;
            if (words.Length>1)
            {
                result++;
            }

            for (int i = 1; i < words.Length; i++)
            {
                Console.WriteLine("result:" + result);
                if (words[i].Length > words[i - 1].Length)
                {
                    result += words[i].Length;
                    if (String.Equals(words[i].Substring(words[i].Length - words[i-1].Length), words[i-1]))
                    {
                        result--;
                        result -= words[i - 1].Length;

                    }
                    if (i < words.Length - 1)
                    {
                        result++;
                    }
                }
                else if (String.Equals(words[i - 1].Substring(words[i - 1].Length - words[i].Length), words[i]))
                {
                    Console.WriteLine("get to here");
                    result--;
                    if (i < words.Length - 1)
                    {
                        result++;
                    }
                }
                else
                {
                    result += words[i].Length;
                    if (i < words.Length - 1)
                    {
                        result++;
                    }
                }

            }
            result++;
            return result;*/
        }
    }
}
