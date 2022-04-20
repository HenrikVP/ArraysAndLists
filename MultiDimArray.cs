using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    internal class MultiDimArray
    {
        string[,] ballers = new string[5, 3];

        public void AddToArray()
        {
            ballers[0, 0] = "Rasmus";
            ballers[0, 1] = "Munch";
            ballers[0, 2] = "Sørensen";

            ballers[1, 0] = "Michael";
            ballers[1, 1] = "Greta";
            ballers[1, 2] = "Schmeichel";
        }


        public void PrintMultiDArray()
        {

            AddToArray();

            //foreach (var item in ballers)
            //{
            //    Console.WriteLine(item);
            //}

            for (int i = 0; i < ballers.GetLength(0); i++)
            {
                Console.WriteLine($" {ballers[i,0]} {ballers[i, 1]} {ballers[i, 2]}");
            }

        }
    }
}
