using System;

namespace H.W._5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Task
             int tipindən bir array olur 
            içində müsbət və mənfi ədədlər olur 
            elə bir method yazın ki, bu array-i parametr olaraq qəbul etsin və qəbul etdiyi array-in əvvəlcədən assign olunması məcburi olsun 
            daha sonra içindəki mənfi ədədləri müsbətə çevirib həmin array-i geriyə qaytarsın
             */

            int[] arr = { 4, -2, 78, -63 };
            int[] array = Changer(ref arr);
            foreach (var item in arr)
            {
                Console.WriteLine($"Num: {item}");
            }


        }
            static int[] Changer(ref int[] Chan )
        {
            for (int i = 0; i < Chan.Length; i++)
            {
                if (Chan[i] < 0)
                {
                    Chan[i] = Chan[i] * (-1);
                }






            }
            return Chan;





        }







    }
}
