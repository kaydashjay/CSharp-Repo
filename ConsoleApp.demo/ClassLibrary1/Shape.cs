using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace ConsoleApp.Shapes
{/// <summary>
/// a shape class
/// </summary>
[DataContract]
        public class Shape :IShape
        {
        //fields or variables
        [DataMember]
        private int length;
        [DataMember]
        private int width;
        #region constructors
        /// <summary>
        /// constructor 
        /// </summary>
        public Shape()
            {
                this.length = 0;
                this.width = 0;
            }
            /// <summary>
            /// overload constructor
            /// </summary>
            /// <param name="length">Shape Length</param>
            /// <param name="width">Shape Width</param>
            ///

            public Shape(int length, int width)
            {
                this.length = length;
                this.width = width;
            }
        #endregion constructors

        #region property
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
            
        }
        #endregion property

        #region methods
        /// <summary>
        /// calculate the area of shape
        /// </summary>
        /// <returns>area of shape</returns>
        public virtual double Area()
            {
            //if (length*width==0)
            //{
             //   throw new ShapeZeroAreaException($"Area is 0, length is {length} and width is {width}. ");
            //}
           
                return this.width * this.length;

            
        }
        private string GetSpapeInfo()
        {
            string result = "";
            //result = "length is " + this.length + " and width is " + this.width;

            result = $"length is {length} and width is {width}"; //string interpulation

            return result;
        }

        public override string ToString()
        {
            return $"The Shape : {this.GetSpapeInfo()}";
        }
        #endregion methods
    }

}



