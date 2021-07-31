using System;
using TaskOne;
namespace ConsoleApp1
{
    class Program
    {
        
        static void Main()
        {
            ArrayWorker arrayWorker = new ArrayWorker();
            int[] commonArray = { 2, 5, 7, 8, 6, 8};
           
            int[] result = arrayWorker.Revers(commonArray);
            for (int i = 0; i < commonArray.Length; i++)
            {
                Console.Write(commonArray[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }


            int[] insertResult = arrayWorker.InsertValue(commonArray, 4, 54);
            Console.WriteLine();
            for (int i = 0; i < insertResult.Length; i++)
            {
                Console.Write(insertResult[i] + " ");
            }
        }
        
    }
}
