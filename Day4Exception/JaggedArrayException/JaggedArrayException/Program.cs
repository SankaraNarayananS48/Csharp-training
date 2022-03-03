﻿class JaggedArrayException
{
    static void Main(String[] args)
    {
        int n,value;
        Console.WriteLine("Enter no of jagged array");
        n = int.Parse(Console.ReadLine());
        int[][] jaggedarray = new int[n][];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter the " + i + " th array size");
            jaggedarray[i] = new int[int.Parse(Console.ReadLine())];
        }
        Console.WriteLine("Enter jagged Array values");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter " + i + " jagged Array values of size " + jaggedarray[i].Length);
            for (int j = 0; j < jaggedarray[i].Length; j++)
            {
                try
                {
                    value  = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please Enter Valid Input");
                    value = int.Parse(Console.ReadLine());
                }

                jaggedarray[i][j] = value;
            }
        }
        Console.WriteLine("Printing jagged Array values");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Printing " + i + " jagged Array values of size " + jaggedarray[i].Length);
            for (int j = 0; j < jaggedarray[i].Length; j++)
            {
                Console.Write(jaggedarray[i][j] + " ");
            }
            Console.WriteLine(" ");
        }

    }
}