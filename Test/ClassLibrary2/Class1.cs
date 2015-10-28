using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumberLibrary
{
    public class PrintNumberClass
    {
        public static string[] printnumber(int n, params KeyValuePair<int, string>[] pairs)
        {

            string[] output = new string[n + 1];
            for (int i = 1; i <= n; i++)
            {
                output[i] = i.ToString();
                //Console.WriteLine(i);

                foreach (var args in pairs)
                {
                    if (i % args.Key == 0)
                    {
                        //override the i value with the string given
                        if (output[i] == i.ToString())
                            output[i] = string.Empty;

                        output[i] += args.Value;
                        //break;
                    }
                }


            }
            return output;
        }

    }

    
}