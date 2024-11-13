using Tyuiu.GurzanVM.Sprint4.Task3.V28.Lib;

namespace Tyuiu.GurzanVM.Sprint4.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] array = {
                {5, 4, 9, 8, 5},
                {4, 6, 6, 9, 9},
                {9, 8, 4, 8, 8},
                {6, 8, 6, 8, 9},
                {9, 4, 6, 6, 7}
            };
            DataService ds = new DataService();
            int expectedMin = 6;
            int actualMin = ds.Calculate(array);

            Assert.AreEqual(expectedMin, actualMin);
        }
    }
}