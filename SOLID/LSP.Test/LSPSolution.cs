using LSPSolution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.TestSolution
{

    #region testing
    [TestClass]
    public class CalculateAreaTest
    {
        [TestMethod]
        public void SixFor2x3Rectange()
        {
            var myRectangle = new Rectangle { Height = 2, Width = 3 };
            Assert.AreEqual(6, myRectangle.Area());
        }

        [TestMethod]
        public void NineFor3x3Squre()
        {
            var squre = new Squre { SideLength = 3 };
            Assert.AreEqual(9, squre.Area());
        }

        [TestMethod]
        public void TwentyFor4x5ShapeAnd9For3x3Squre()
        {
            var shapes = new List<Shape>
            {
                new Rectangle{Height = 4, Width = 5},
                new Squre{SideLength = 3}
            };
            var areas = new List<int>();
            #region problem
            //So you are following both polymorphism and OCP          
            #endregion
            foreach (Shape shape in shapes) //Iteration
            {
                areas.Add(shape.Area());
            }
            Assert.AreEqual(20, areas[0]);
            Assert.AreEqual(9, areas[1]);
        }
    }


    #endregion testing
}
