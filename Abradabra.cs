using System;
using System.Collections.Generic;
using System.Text;

namespace ImtiazAdar
{
    class Abradabra
    {
        static void Main(string[] args)
        {
            string sen;
            int m = 0;
            while((sen = Console.ReadLine()) != null)
            {
                int len = sen.Length;
                for(int i = 0; i < len; i++)
                {
                    for (int j = 0; j < m; j++)
                        Console.Write(" ");
                    for (int j = 0; j < len - 1; j++)
                        Console.Write(sen[j] + " ");
                    Console.Write(sen[len - 1]);
                    Console.WriteLine();
                    m++;
                    len--;
                }
                Console.WriteLine();
            }
        }
    }
}
