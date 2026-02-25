using MyConsoleApp;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int a = 5; int b = 6; int c = 7;
            int res = Logic.Calculate(a, b, c);
            //ClassicAssert.AreEqual(18, res);
            Assert.That(res, Is.EqualTo(30));
        }
        [Test]
        public void Test2()
        {
            int a = 3; int b = 4; int c = 5;
            int res = Logic.Calculate(a, b, c);
            Assert.That(res, Is.EqualTo(12));
        }
        [Test]
        public void Test3()
        {
            int res = Logic.Calculate(0,0,0);
            Assert.That(res, Is.EqualTo(0));
        }
        [Test]
        public void Test4()
        {
            int res = Logic.Calculate(-10,-3,-4);
            Assert.That(res, Is.EqualTo(40));
        }
        [Test]
        public void Test5()
        {
            int res = Logic.Calculate(-3,5, 7);
            Assert.That(res, Is.EqualTo(-15));
        }
    }
}
