﻿using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());
            int coins = 0;

            while (change > 0m)
            {
                if (change >= 2)
                {
                    change -= 2;
                }
                else if (change >= 1)
                {
                    change -= 1;
                }
                else if (change >= 0.50m)
                {
                    change -= 0.50m;
                }
                else if (change >= 0.20m)
                {
                    change -= 0.20m;
                }
                else if (change >= 0.10m)
                {
                    change -= 0.10m;
                }
                else if (change >= 0.05m)
                {
                    change -= 0.05m;
                }
                else if (change >= 0.02m)
                {
                    change -= 0.02m;
                }
                else if (change >= 0.01m)
                {
                    change -= 0.01m;
                }
                coins++;
            }
            Console.WriteLine(coins);
        }
    }
}
