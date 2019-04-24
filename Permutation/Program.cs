using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input first string");
            string str1 = Console.ReadLine();

            Console.WriteLine("Input second string");
            string str2 = Console.ReadLine();

            bool result = FindPermutation(str1, str2);
            if (result == true)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

            Console.Read();
        }

        static bool FindPermutation(string str1, string str2)
        {
            int len1 = str1.Length;
            int len2 = str2.Length;

            if (len1 != len2)
                return false;

            char[] ch1 = str1.ToCharArray();
            char[] ch2 = str2.ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            for (int i = 0; i < len1; i++)
            {
                if (ch1[i] != ch2[i])
                    return false;

            }

            return true;
        }
    }
}
