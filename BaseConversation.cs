using System;
using System.Collections.Generic;
using System.Text;

namespace ImtiazAdar
{
    class BaseConversation
    {
        static string binaryToHexa(string binary)
        {
            return Convert.ToString(Convert.ToInt32(binary, 2), 16);
        }
        static string binaryToDecimal(string binary)
        {
            return Convert.ToString(Convert.ToInt32(binary, 2));
        }
        static string hexaToDecimal(string hexa)
        {
            return Convert.ToString(Convert.ToInt32(hexa, 16));
        }
        static string hexaToBinary(string hexa)
        {
            return Convert.ToString(Convert.ToInt32(hexa, 16), 2);
        }
        static string decimalToBinary(string deci)
        {
            return Convert.ToString(Convert.ToInt32(deci, 10), 2);
        }
        static string decimalToHexa (string deci)
        {
            return Convert.ToString(Convert.ToInt32(deci, 10), 16);
        }
        //static void Main(string[] args)
        //{
        //    int N = Convert.ToInt32(Console.ReadLine());
        //    int i = 0;
        //    while(N-- > 0)
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        i++;
        //        sb.Append("Case " + i + ":\n");
        //        string[] sen = Console.ReadLine().Split(' ');
        //        string num = sen[0]; string type = sen[1];
        //        if (type.Equals("bin"))
        //        {
        //            string dec = binaryToDecimal(num);
        //            string hex = binaryToHexa(num);
        //            sb.Append(dec + " dec\n" + hex + " hex\n\n");
        //        }
        //        else if (type.Equals("dec"))
        //        {
        //            string hex = decimalToHexa(num);
        //            string bin = decimalToBinary(num);
        //            sb.Append(hex + " hex\n" + bin + " bin\n\n");
        //        }
        //        else if (type.Equals("hex"))
        //        {
        //            string dec = hexaToDecimal(num);
        //            string bin = hexaToBinary(num);
        //            sb.Append(dec + " dec\n" + bin + " bin\n\n");
        //        }
        //        Console.WriteLine(sb);
        //    }
        //}
    }
}
