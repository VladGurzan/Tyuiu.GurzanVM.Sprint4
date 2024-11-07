using Tyuiu.GurzanVM.Sprint4.Task2.V6.Lib;

namespace Tyuiu.GurzanVM.Sprint4.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 0, 3, 5, 2, 1, 6, 7, 8, 3, 1, 2, 4, 7, 6 };

            int res = ds.Calculate(numsArray);
            int WaitArray = 2205;

            Assert.AreEqual(WaitArray, res);
        }
    }
}