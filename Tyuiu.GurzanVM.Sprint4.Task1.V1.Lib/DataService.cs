﻿using System.Security.Cryptography;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GurzanVM.Sprint4.Task1.V1.Lib
{
    public class DataService : ISprint4Task1V1
    {
        public int Calculate(int[] array)
        {
            int s = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    s += array[i];
                }
            }
            return s;
        }
    }
}
