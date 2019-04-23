using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LSPViolation
{



    /// <summary>
    /// 
    /// </summary>
    public class Rectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Squre : Rectangle
    {
        private int _height;
        private int _width;


        public override int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                _height = value;
            }
        }
        public override int Height
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                _height = value;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class AreaCalculator
    {
        public static int CalculateArea(Squre squre)
        {
            return squre.Height * squre.Width;
        }

        public static int CalculateArea(Rectangle rectagle)
        {
            return rectagle.Height * rectagle.Width;
        }

    }
}
