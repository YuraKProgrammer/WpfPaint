using NUnit.Framework;
using WpfPaint2;

namespace TestProject1
{
    public class PaintUtils_Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void NewValue_Test()
        {
            PaintUtils paintUtils = new PaintUtils();
            paintUtils.NewValue(255, 50);
            Assert.Pass();
        }

        [Test]
        [TestCase(123,230)]
        [TestCase(0,0)]
        [TestCase(11,198)]
        [TestCase(-9,238)]
        [TestCase(50,4)]
        public void GetAlpha_Test(int value, byte espected)
        {
            PaintUtils paintUtils = new PaintUtils();
            var result = paintUtils.GetAlpha(value);
            Assert.AreEqual(espected, result);
        }
    }
}