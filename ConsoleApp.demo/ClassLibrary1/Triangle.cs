using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Shapes
{
    public class Triangle : Shape
    {
        /// <summary>
        /// constructor 
        /// </summary>
        public Triangle()
        {
            this.length = 0;
            this.width = 0;
        }
        /// <summary>
        /// overload constructor
        /// </summary>
        /// <param name="length">Triangle Length</param>
        /// <param name="width">Triangle Width</param>
        ///

        public Triangle(int length, int width):base (length, width)
        {
            this.length = length;
            this.width = width;
        }

        //fields or variables
        private int length;
        private int width;

        /// <summary>
        /// override the base Shape Area() method
        /// </summary>
        /// <returns></returns>
        //methods
        public override double Area()
        {
            return base.Area() / 2;

        }
    }
}
