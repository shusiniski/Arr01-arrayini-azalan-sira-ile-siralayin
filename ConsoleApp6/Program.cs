using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        int[] Arr01 = new int[] { 97, 92, 81, 60, 58, 12, 45 };

        Console.WriteLine("Original Array");

        for (int i = 0; i < Arr01.Length; i++)
            Console.WriteLine(Arr01[i]);

        Array.Sort(Arr01);

        Console.WriteLine("Sorted Array");

        for (int i = 0; i < Arr01.Length; i++)
            Console.WriteLine(Arr01[i]);

        Array.Reverse(Arr01);

        Console.WriteLine("Reversed Array");

        for (int i = 0; i < Arr01.Length; i++)
            Console.WriteLine(Arr01[i]);


    }
}