using System;
using Projet_0;

namespace exchange_letter {
    public class exchange_letter {
        public static string[] ExchangeFirstLetter(string sentence) {
            Console.WriteLine("It's a original text : " + sentence);
            var temp = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            char[] s;
            char[] f = new char[temp.Length];

            var i = 0;
            foreach (var s1 in temp) {
                s = s1.ToCharArray();
                f[i] = s[0];
                i++;
                if (i >= temp.Length) {
                    break;
                }
            }

            Array.Reverse(f);
            for (int j = 0;
                j < temp.Length;
                j++) {
                s = temp[j].ToCharArray();
                s[0] = f[j];
                temp[j] = new string(s);
            }

            var ij = "It's a changed  text : ";
            Console.Write(ij);
            return temp;
        }
    }
}