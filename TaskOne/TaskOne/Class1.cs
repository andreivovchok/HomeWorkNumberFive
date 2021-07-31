using System;

namespace TaskOne
{
    public class ArrayWorker
    {
        public int[] Revers(int[] list)
        {
            int[] listCopy = new int[list.Length];
            Array.Copy(list, listCopy, list.Length);
            Array.Reverse(listCopy);
            return listCopy;
        }
        public int[] InsertValue(int[] source, int index, int newValue) 
        {
            int[] result = new int[source.Length + 1];
            result[index] = newValue;
            for(int i = 0; i < index; i++)
            {
                result[i] = source[i];
            }
            for(int i = index; i < source.Length; i++)
            {
                result[i + 1] = source[i];
            }
            return result;
        }
    }
}
