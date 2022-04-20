using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    internal class Tools
    {
        public Tools()
        {

        }
        internal void WriteArray(string[] strArr)
        {
            int counter = 0;
            NewMethod(strArr);

            for (int i = 0; i < strArr.Length; i++)
            {
                Console.WriteLine(strArr[i] + " " + i);
            }

            while (counter < strArr.Length)
            {
                Console.WriteLine(strArr[counter]);
                counter++;
            }
        }

        private static void NewMethod(string[] strArr)
        {
            foreach (var item in strArr)
            {
                Console.WriteLine(item);
                if (item == "Skateboard")
                {
                    Console.WriteLine("Found the skateboard");
                    break;
                }
            }
        }
    }
}
