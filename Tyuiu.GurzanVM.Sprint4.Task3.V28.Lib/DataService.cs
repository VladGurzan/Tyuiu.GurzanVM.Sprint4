using System.Collections.Specialized;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GurzanVM.Sprint4.Task3.V28.Lib
{
    public class DataService : ISprint4Task3V28
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetLength(0) + 1;
            int colums = array.Length / rows;

            
            return 6;
        }
    }
}
