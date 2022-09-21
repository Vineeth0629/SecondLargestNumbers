using System;
using System.Collections;

public class Program
{
    public static void Main()
    {
       // string[] stringName = {"hello", "hi" ,"123" };
       // char[] charArray = { 'c', 'v' };
        int[] array = { 2, 11, 15, 1, 7, 99, 6, 85, 4 };
        Array.Sort(array); //sorting array  - Ascending 
        Array.Reverse(array); // Reverse Sorting array value - descending 
        //to read value in arrary arrayname[indexvalue]
        Console.WriteLine("Second Highest Value In Array " + array[1]);
        //
        int a = Convert.ToInt32(Console.ReadLine());
        int[] b = new int[a];
        foreach (var result in array)
        {
            Console.Write(result + " "); // Array values   
        }

        //for(int item=0; item<array.Length;item++)
        //{
        //    Console.Write(array[item] + "  ");
        //}
    }
}