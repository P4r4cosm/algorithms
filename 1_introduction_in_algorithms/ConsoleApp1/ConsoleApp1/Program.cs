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
                high=mid;
            }
            else
            {
                return mid; 
            }
        }
        return null;
    }
    public static void Main()
    {
        int[] array=new int[100];
        for (int i=0;i<array.Length;i++) 
        {
                array[i] = i*2;
        }
        Console.WriteLine( BinarySearch(array,10));
    }
}
