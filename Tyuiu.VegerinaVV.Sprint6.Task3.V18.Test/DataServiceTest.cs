using Tyuiu.VegerinaVV.Sprint6.Task3.V18.Lib;
namespace Tyuiu.VegerinaVV.Sprint6.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] { { -19, -19, 1, 18, 7 },
                                            { 5, 3, -4, -6, -12 },
                                            { -15, 6, 2, 2, -14 },
                                            { -9, -10, 15, -5, -6 },
                                            { -13, -15, -9, 7, 1 } };

            int[,] res = ds.Calculate(matrix);

            int[,] wait = { { -19, -19, 1, 18, 7 },
                            { 5, 3, -4, -6, -12 },
                            { -15, 6, 2, 2, -14 },
                            { -9, 0, 15, -5, 0 },
                            { -13, -15, -9, 7, 1 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
