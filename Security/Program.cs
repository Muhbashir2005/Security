using System;
using System.Collections.Generic;

namespace CodeChallenges
{
    class Program
    {
        public static void Main(string[] args)
        {
            string word = "xxxxxx$xxGxT";
            bool check = CheckSecurity(word);
            string result = Print(check);
            Console.WriteLine(result);
        }

        private static bool CheckSecurity(string input)
        {
            bool result = false;
            char[] z = input.ToCharArray();
            List<char> inputs = new List<char>();
            foreach (var item in z)
            {
                if (item != 'x')
                {
                    inputs.Add(item);
                }
            }
            for (int i = 0; i < inputs.Count - 1; i++)
            {
                if (inputs[i] == '$' && inputs[i + 1] == 'T')
                {
                    result = true;
                }
            }
            return result;
        }
        private static string Print(bool check)
        {
            if (check == true)
            {
                return "ALARM";
            }
            return "QUIET";
        }
    }
}

