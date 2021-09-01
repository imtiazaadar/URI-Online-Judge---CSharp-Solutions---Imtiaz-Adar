using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 *  Imtiaz Adar 
 */
namespace ImtiazAdar
{
    class HallOfMurderers
    {
        static void Main(string[] args)
        {
            List<string> murderer = new List<string>();
            List<string> dead = new List<string>();
            SortedDictionary<string, int> dic = new SortedDictionary<string, int>();
            string sen;
            //while((sen = ConsoleReadToken()) != null)
            for(int i = 0; i < 6; i++)
            {
                string[] sens = ConsoleReadAndSplitLine();
                //string[] sens = sen.Split(' ');
                murderer.Add(sens[0]);
                dead.Add(sens[1]);
            }
            for(int i = 0; i < murderer.Count; i++)
            {
                if (dic.ContainsKey(murderer[i]))
                {
                    dic[murderer[i]]++;
                }
                else dic[murderer[i]] = 1;
            }
            for(int i = 0; i < dead.Count; i++)
            {
                if (dic.ContainsKey(dead[i]))
                {
                    dic.Remove(dead[i]); dead.Remove(dead[i]);
                }
            }
            Console.WriteLine("HALL OF MURDERERS");
            foreach(var item in dic)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
        private static Queue<string> tokens = new Queue<string>();
        private static string[] ConsoleReadAndSplitLine()
        {
            return Console.ReadLine().Split(new[] { ' ', '\t', });
        }
        public static string ConsoleReadToken()
        {
            while (tokens.Count == 0)
                tokens = new Queue<string>(ConsoleReadAndSplitLine());
            return tokens.Dequeue();
        }
        public static int ConsoleReadInt()
        {
            return int.Parse(ConsoleReadToken());
        }
        public static long ConsoleReadLong()
        {
            return long.Parse(ConsoleReadToken());
        }
        public static double ConsoleReadDouble()
        {
            return double.Parse(ConsoleReadToken());
        }
        public static int[] ConsoleReadIntArray()
        {
            return ConsoleReadAndSplitLine().Select(int.Parse).ToArray();
        }
        public static long[] ConsoleReadLongArray()
        {
            return ConsoleReadAndSplitLine().Select(long.Parse).ToArray();
        }
        public static double[] ConsoleReadDoubleArray()
        {
            return ConsoleReadAndSplitLine().Select(double.Parse).ToArray();
        }
    }
}
