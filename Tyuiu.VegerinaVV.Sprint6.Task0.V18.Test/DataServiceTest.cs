using Tyuiu.VegerinaVV.Sprint6.Task0.V18.Lib;
namespace Tyuiu.VegerinaVV.Sprint6.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 1.056;
            Assert.AreEqual(wait, res);
        }
    }
}
