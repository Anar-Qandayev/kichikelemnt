using System;

namespace arraykichikelement
{
    class Program
    {
        static void Main(string[] args)
        {

            #region
            int[] arr = { 5, 3, 9, 23, 35, 55 };
            int min = arr[0];//5

            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(min);
            #endregion
            #region
            int count = 0;
            string ad = "anar fdggv asasds atr45";
            for (int i = 0; i < ad.Length; i++)
            {
                if (ad[i] == 'a' || ad[i] == 'A')
                {
                    count++;

                }
            }
            Console.WriteLine(count + " A herfi var");
            #endregion
        }

    }
