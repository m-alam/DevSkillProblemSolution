using System;

namespace ConsoleApp1
{
    class Reverse
    {
        public static void Main(string[] args)
        {
            
            int T;
            T=int.Parse(Console.ReadLine());
            for(int i= 0;i<T;i++)
            {
                string s;
                s= Console.ReadLine();
                int x = s.Length - 1;
                string rev = "";
                while (x >= 0)
                {
                    rev = rev + s[x];
                    x--;
                }
                Console.WriteLine(rev);
            }
            
        }

    }
}