using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Shapes
{
    public class Circle : Shape
    {
        private static Circle instance = null;

        /// <summary>
        /// private constructor
        /// </summary>
        private Circle()
        {
        }

        ///<summary>
        ///get the instance
        /// </summary>
        public static Circle GetCircle
        {
            get
            {
                if (instance == null)
                {
                    instance = new Circle();
                }
                return instance;
            }
        }

        public int Radius
        {
            get
            {
                return Length;
            }

            set
            {
                Length = value;
                Width = value;
            }
        }
        #region methods 

        public new double Area()
        {
            return Math.PI * Radius * Radius;
        }

        #endregion methods
    }
}
