using System;
using System.Collections.Generic;
using System.Text;

namespace ImtiazAdar
{
    class GetlineThree
    {
        static void Main(string[] args)
        {
            string sen;
            int casee = 0;
            while((sen = Console.ReadLine()) != null)
            {
                casee++;
                if (casee > 1)
                    Console.WriteLine();
                string[] newsen = Console.ReadLine().Split(' ');
                int male = 0, female = 0, total = 0;
                for(int i = 0; i < newsen.Length - 1; i++)
                {
                    if(newsen[i] == sen)
                    {
                        total++;
                        if (newsen[i + 1] == "M")
                            male++;
                        else if (newsen[i + 1] == "F")
                            female++;
                    }
                }
                Console.WriteLine($"Caso {casee}:");
                Console.WriteLine($"Pares Iguais: {total}");
                Console.WriteLine($"F: {female}");
                Console.WriteLine($"M: {male}");
            }
        }
    }
}
