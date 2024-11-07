﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GurzanVM.Sprint4.Task2.V6.Lib
{
    public class DataService : ISprint4Task2V6
    {
        public int Calculate(int[] array)
        {
            int SumArray = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    SumArray *= array[i];
                }
            }
            return SumArray;
        }
    }
}