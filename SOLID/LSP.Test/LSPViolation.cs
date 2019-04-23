using System;
using LSPViolation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LSP.Test
{

    [TestClass]
    public class CalculateAreaTest
    {
        [TestMethod]
        public void SixFor2x3Rectange()
        {
            var myRectangle = new Rectangle { Height = 2, Width = 3 };
            Assert.AreEqual(6, AreaCalculator.CalculateArea(myRectangle));
        }

        [TestMethod]
        public void NineFor3x3Squre()
        {
            var squre = new Squre { Height = 3 };
            Assert.AreEqual(9, AreaCalculator.CalculateArea(squre));
        }

        [TestMethod]
        public void TwentyFor4x5Squre()
        {
            //Failed means not substitutable
            var rectangle = new Squre();
            rectangle.Height = 4;
            rectangle.Width = 5;
            Assert.AreEqual(20, AreaCalculator.CalculateArea(rectangle));

        }


    }

}
