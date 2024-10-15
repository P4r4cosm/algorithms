using System;
using System.Runtime.InteropServices;
class Program
{
    public static int? BinarySearch(int[] array,int value)
    {
        int mid,quess;
        int low = 0;
        int high=array.Length-1;
        for(int i=0;i<Math.Log2(array.Length);i++)
        {
            mid = (low+high)/ 2;
            quess = array[mid];
            if (quess < value) 
            {
                low = mid+1;
            }
            else if (quess>value)
            {
                high=mid-1;
            }
            else
            {
                return mid; 
            }
        }
        return null;
    }
    public static int GetSmallElement(int[] array)
    {
        int min = int.MaxValue;
        int index=0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]<min)
            {
                min = array[i];
                index = i;
            }
        }
        return index;
    }
    public static int[] DeleteElement(int[] array, int index)
    {
        if (index < 0 || index >= array.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Индекс выходит за пределы массива.");
        }
        int[] result= new int[array.Length-1];
        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (i == index) continue;
            result[j++] = array[i];
        }
        return result;
    }
    public static int[] SelectionSort(int[] array)
    {
        int[] result= new int[array.Length];
        for (int i = 0; i < result.Length; i++)
        {
            int index_small = GetSmallElement(array);
            result[i] = array[index_small];
            array=DeleteElement(array, index_small);
        }
        return result;
    }
    public static void Main()
    {
        int[] array = { 5, 10, 15, 0, 5, 43, 10, 50, 20 };    
        array=SelectionSort(array);
        foreach (int i in array)
        {
            Console.WriteLine(i);
        }
        
    }
}
