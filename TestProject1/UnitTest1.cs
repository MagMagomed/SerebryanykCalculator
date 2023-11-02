using SerebryanykCalculator;

namespace TestProject1
{
    public class Tests
    {
        Calculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void RealRubleToSerebryanykTest()
        {
            Assert.That(calculator.RealRubleToSerebryanyk(25000), Is.EqualTo(3m));
        }
        [Test]
        public void SerebryanykToRealRubleTest()
        {
            Assert.That(calculator.SerebryanykToRealRuble(3m), Is.EqualTo(25000m));
        }
    }
}