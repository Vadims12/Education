﻿using System;
namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
        m1: int[] MassNumber = new int[10];
            var rand = new Random();
            for (int i = 0; i < MassNumber.Length; i++)
            {
                MassNumber[i] = rand.Next(1, 10);
                Console.Write(MassNumber[i] + " ");
            }
            Console.WriteLine();
            while (MassNumber[0] == MassNumber[1])
            {
                MassNumber[1] = rand.Next(1, 10);
            }
        m: for (int i = 0; i < MassNumber.Length; i++)
            {
                Console.Write(MassNumber[i] + " ");
            }
            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < MassNumber.Length; i++)
            {
                for (int j = i + 1; j < MassNumber.Length - 1; j++)
                {
                    if (MassNumber[i] == MassNumber[j])
                    {
                        MassNumber[j] = MassNumber[j] * j;
                        count = 1;
                    }
                    if (count == 1)
                        goto m;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Вывод итогового массива: ");
            foreach (int number in MassNumber)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Хотите повторить? 1-да; любая другая кнопка - нет");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c == 1)
            {
                Console.Clear();
                goto m1;
            }
            return;
        }
    }
}