namespace ArraysAndLists
{
    internal class Skating
    {
        //private static string[] SkatingStuff = new string[5];
        List<object> list = new List<object>() { "One","Two", 3};

        object[] objArr = new object[3];
        
        void AddToObjectArray()
        {
            objArr[0] = 3;
            objArr[1] = "Fourth";
        }
        void AddToList()
        {
            list.Add("Three");
        }

        void PrintList()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static string[] AddSkatingStuff()
        {
            string[] SkatingStuff = new string[5];
            SkatingStuff[0] = "Rulleskøjter";
            SkatingStuff[1] = "Longboard";
            SkatingStuff[2] = "Løbehjul";
            SkatingStuff[3] = "Skateboard";
            SkatingStuff[4] = "Strygebræt";
            //SkatingStuff[5] = "IsThisEvenPossible?"; NO!
            return SkatingStuff;
        }

        

    }
}
