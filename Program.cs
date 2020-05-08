using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace map
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "g fmnc wms bgblr rpylqjyrc gr zw fylb. rfyrq ufyr amknsrcpq ypc dmp. bmgle gr gl zw fylb gq glcddgagclr ylb rfyr'q ufw rfgq rcvr gq qm jmle. sqgle qrpgle.kyicrpylq() gq pcamkkclbcb. lmu ynnjw ml rfc spj.";
            string newMessage = Converter(message);
            Console.WriteLine($"{message}\ntranslates to\n{newMessage}");
            message = "/ pc / def / map.html";
            newMessage = Converter(message);
            Console.WriteLine($"{message}\ntranslates to\n{newMessage}");

        }
        static string Converter(string message) 
        {
            char[] s = new char[message.Length];
            s = message.ToCharArray(0, message.Length);
            message = "";
            for (int i=0; i < s.Length; i++) 
            {
                if (s[i] <= 'z' && s[i] >= 'a')
                {
                    if (s[i] + 2 <= 'z')
                    {
                        message += (char)(s[i] + 2);
                    }
                    else 
                    {
                        message += (char)(s[i] + 2 -'z'+'`');
                    }
                }
                else 
                {
                    message += s[i];
                }
            }
            return message;
        }
    }
}
