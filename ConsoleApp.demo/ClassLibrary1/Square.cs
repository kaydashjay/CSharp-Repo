using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Shapes
{
    public class Square : Rectangle
    {
        /// <summary>
        /// overload constructor
        /// </summary>
        /// <param name="length">Shape Length</param>
        /// <param name="width">Shape Width</param>
        ///

        public Square(int length): base(length, length)
        {
        }
    }
}

