using Tyuiu.GurzanVM.Sprint4.Task4.V21.Lib;

namespace Tyuiu.GurzanVM.Sprint4.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 3, 6, 4, 6, 6 },
                                          { 7, 5, 5, 5, 8 },
                                          { 8, 3, 6, 7, 7 },
                                          { 5, 3, 8, 4, 5 },
                                          { 3, 7, 4, 3, 8 } };
            int res = ds.Calculate(mas2);
            int wait = 68;

            Assert.AreEqual(wait, res);
        }
    }
}