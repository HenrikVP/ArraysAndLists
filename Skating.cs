namespace ArraysAndLists
{
    internal static class Skating
    {
        private static string[] SkatingStuff = new string[5];
        private static int counter;

        public static void AddSkatingStuff()
        {
            SkatingStuff[0] = "Rulleskøjter";
            SkatingStuff[1] = "Longboard";
            SkatingStuff[2] = "Løbehjul";
            SkatingStuff[3] = "Skateboard";
            SkatingStuff[4] = "Strygebræt";
            //SkatingStuff[5] = "IsThisEvenPossible?"; NO!

        }


        internal static void PrintArray()
        {
            foreach (var item in SkatingStuff)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < SkatingStuff.Length; i++)
            {
                Console.WriteLine(SkatingStuff[i] + " " + i);
            }


            while (counter < SkatingStuff.Length)
            {
                Console.WriteLine(SkatingStuff[counter]);
                counter++;
            }
        }

    }
}
