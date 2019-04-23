using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolution
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Shape
    {
        public abstract int Area();

    }

    /// <summary>
    /// 
    /// </summary>
    public class Squre : Shape
    {
        public int SideLength;
        public override int Area()
        {
            return SideLength * SideLength;
        }
    }


    /// <summary>
    /// 
    /// </summary>
    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public override int Area()
        {
            return Height * Width;
        }
    }


    /// <summary>
    /// 
    /// </summary>
    public class Triangle : Shape
    {
        public int Base;
        public int Height;

        public override int Area()
        {
            return 1 / 2 * Base * Height;
        }
    }
}
