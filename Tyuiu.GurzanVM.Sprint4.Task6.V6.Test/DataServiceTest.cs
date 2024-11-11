using System.Numerics;
using Tyuiu.GurzanVM.Sprint4.Task6.V6.Lib;

namespace Tyuiu.GurzanVM.Sprint4.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();


            var name = new string[] { "�����", "����", "������", "�����", "������", "�������", "����" };
            string[] res = ds.Calculate(name);
            string[] wait = { "�����", "�����" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}