using NUnit.Framework;

namespace TestProject1
{
    [TestFixture(1, Category = "ClassA")]
    [TestFixture(2, Category = "ClassA")]
    [TestFixture(3, Category = "ClassA")]
    [TestFixture(4, Category = "ClassA")]
    [TestFixture(5, Category = "ClassA")]
    [TestFixture(6, Category = "ClassA")]
    [TestFixture(7, Category = "ClassA")]
    [TestFixture(8, Category = "ClassA")]
    [TestFixture(9, Category = "ClassA")]
    [TestFixture(10, Category = "ClassA")]
    [TestFixture(11, Category = "ClassA")]
    [TestFixture(12, Category = "ClassA")]
    [TestFixture(13, Category = "ClassA")]
    [TestFixture(14, Category = "ClassA")]
    [TestFixture(15, Category = "ClassA")]
    [TestFixture(16, Category = "ClassA")]
    [TestFixture(17, Category = "ClassA")]
    [TestFixture(18, Category = "ClassA")]
    [TestFixture(19, Category = "ClassA")]
    [TestFixture(20, Category = "ClassA")]
    [TestFixture(21, Category = "ClassA")]
    [TestFixture(22, Category = "ClassA")]
    [TestFixture(23, Category = "ClassA")]
    [TestFixture(24, Category = "ClassA")]
    [TestFixture(25, Category = "ClassA")]
    [TestFixture(26, Category = "ClassA")]
    [TestFixture(27, Category = "ClassA")]
    [TestFixture(28, Category = "ClassA")]
    [TestFixture(29, Category = "ClassA")]
    [TestFixture(30, Category = "ClassA")]
    public class ClassA : TestsParams
    {
        private int _testNum { get; set; }
        
        public ClassA(int testNum)
        {
            _testNum= testNum;
        }
        
        [TestCaseSource(nameof(TestParams))]
        public void Test1(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        [TestCaseSource(nameof(TestParams))]
        public void Test2(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        [TestCaseSource(nameof(TestParams))]
        public void Test3(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        [TestCaseSource(nameof(TestParams))]
        public void Test4(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        
        [TestCaseSource(nameof(TestParams))]
        public void Test5(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        [TestCaseSource(nameof(TestParams))]
        public void Test6(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        [TestCaseSource(nameof(TestParams))]
        public void Test7(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        [TestCaseSource(nameof(TestParams))]
        public void Test8(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        [TestCaseSource(nameof(TestParams))]
        public void Test9(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        [TestCaseSource(nameof(TestParams))]
        public void Test10(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        [TestCaseSource(nameof(TestParams))]
        public void Test11(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        [TestCaseSource(nameof(TestParams))]
        public void Test12(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        [TestCaseSource(nameof(TestParams))]
        public void Test13(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        [TestCaseSource(nameof(TestParams))]
        public void Test14(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        [TestCaseSource(nameof(TestParams))]
        public void Test15(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        [TestCaseSource(nameof(TestParams))]
        public void Test16(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        [TestCaseSource(nameof(TestParams))]
        public void Test17(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        [TestCaseSource(nameof(TestParams))]
        public void Test18(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        [TestCaseSource(nameof(TestParams))]
        public void Test19(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }
        public void Test20(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        public void Test21(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        public void Test22(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        public void Test23(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        public void Test24(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        public void Test25(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        public void Test26(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        public void Test27(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        public void Test28(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        public void Test29(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

        public void Test30(string kpi, string period, int QSDim1, int QSDim2)
        {
            Console.WriteLine($"Class A -> {_testNum}");
            Assert.Pass();
        }

    }
}