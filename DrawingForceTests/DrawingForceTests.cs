using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DrawingForceTests
{
    [TestClass]
    public class DrawingForceTests
    {

        private CalcService.CalcService service;


        public DrawingForceTests()
        {
            service = new CalcService.CalcService();
        }


        // I rounded to what what I thought was the correct number after rounding correctly.
        [TestMethod]
        public void Test1()
        {
            var n = service.CalculateDrawingForce(0.00001963, 0.00001104, 410000000, 0.05, 0.438);

            Assert.AreEqual("2413.45", n.ToString());

        }

        // Having checked, the values below not viable due to r resulting in being higher than the maximum value of r. However the calculation is correct.
        [TestMethod]
        public void Test2()
        {
            var n = service.CalculateDrawingForce(0.000047563, 0.00001415, 106600000, 0.099, 0.1799);

            Assert.AreEqual("1695.97", n.ToString());

        }

        // Below values answer as the same as the one made on a calculator. They have an r value of 0.62.
        [TestMethod]
        public void Test3()
        {
            var n = service.CalculateDrawingForce(0.000015, 0.0000570, 410000000, 0.05, 0.438);

            Assert.AreEqual("22257.00", n.ToString());

        }
        // This is a xyz test
        [TestMethod]
        public void Test4()
        {
            var n = service.CalculateDrawingForce(0.0000145, 0.00001421, 300000000, 0.10, 0.02);

            Assert.AreEqual("53", n.ToString());

        }
    }
}
