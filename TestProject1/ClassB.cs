using NUnit.Framework;

namespace TestProject1
{
    [TestFixture(31, Category = "ClassB")]
    [TestFixture(32, Category = "ClassB")]
    public class ClassB :  TestsParams
    {
        private int _testNum { get; set; }

        public ClassB(int testNum)
        {
            _testNum = testNum;
        }
        
        [TestCaseSource(nameof(TestParams))]
        public void Test31(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class B -> {_testNum}");
            Assert.Pass();
        }

        [TestCaseSource(nameof(TestParams))]
        public void Test32(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class B -> {_testNum}");
            Assert.Pass();
        }
    }
}