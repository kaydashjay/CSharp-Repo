using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Shapes
{/// <summary>
/// represents a Rectangle object
/// </summary>
    public class Rectangle : Shape
    {

        //fields or variables
        //private int length;
        //private int width;

       /* public Rectangle()
        {

            this.length = 0;
            this.width = 0;
        }*/
        #region constructors
        /// <summary>
        /// constructor that calls the Shape constructor
        /// </summary>
        /// <param name="length">Rectangle Length</param>
        /// <param name="width">Rectangle Width</param>
        ///
        public Rectangle(int length, int width) : base(length, width)
        {
        }
        #endregion constructos
        #region methods
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
       
#endregion methods


        //methods
    }
    }
