﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GurzanVM.Sprint4.Task0.V15.Lib
{
    public class DataService : ISprint4Task0V15
    {
        public int GetMultOddArrEl(int[] array)
        {
            
            int s = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    s += array[i];
                }              
            }
            return s;
        }
    }
}
