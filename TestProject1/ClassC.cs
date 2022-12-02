using NUnit.Framework;

namespace TestProject1
{
    [TestFixture(33, Category = "ClassC")]
    [TestFixture(34, Category = "ClassC")]
    public class ClassC : TestsParams
    {
        private int _testNum { get; set; }

        public ClassC(int testNum)
        {
            _testNum = testNum;
        }

        [TestCaseSource(nameof(TestParams))]
        public void Test33(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class C -> {_testNum}");
            Assert.Pass();
        }

        [TestCaseSource(nameof(TestParams))]
        public void Test34(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class C -> {_testNum}");
            Assert.Pass();
        }
    }
}