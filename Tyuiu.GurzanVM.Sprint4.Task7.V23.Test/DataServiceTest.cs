using Tyuiu.GurzanVM.Sprint4.Task7.V23.Lib;

namespace Tyuiu.GurzanVM.Sprint4.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 4;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "678135972584";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}