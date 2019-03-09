using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());      // number of test cases
            if (t > 0)
            {
                for (int i = 0; i < t; i++)
                {
                    string[] s = Console.ReadLine().Split(' ');
                    string word = s[0];
                    int n = int.Parse(s[1]);
                    int m = int.Parse(s[2]);
                    char[] substr = word.ToCharArray();
                    Array.Sort(substr, n, m - n + 1);
                    Array.Reverse(substr, n, m - n + 1);
                    Console.WriteLine(substr);
                    Console.Write("Hello");
                }
            }           
        }
    }
}
