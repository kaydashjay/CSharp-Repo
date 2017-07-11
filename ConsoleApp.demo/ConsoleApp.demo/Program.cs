using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Shapes;


namespace ConsoleApp.demo
{

    class Program
    {
        //privat evariables
        private static int num = 10;

        public static int GetNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            #region Inheritence Try/Catch
            Shape rect = new Rectangle (1, 2);
            Shape square = new Square(4);
            Shape triangle = new Triangle(3, 3);

            Shape s = new Rectangle(1, 2);
            IShape s2 = new Rectangle(2, 2);

            Console.WriteLine(s.ToString());
            if (rect is Rectangle)
            {
                Console.WriteLine("rect is a rectangle");
                Rectangle r = (Rectangle)rect;
                Rectangle r2 = rect as Rectangle;
            }

            Console.WriteLine("Rectangle " + rect.Area());
            Console.WriteLine("Square " + square.Area());
            Console.WriteLine("Triangle " + triangle.Area());

            Square sq = new Square(0);
            try
            {
                sq.Area();
            }
            catch (ShapeZeroAreaException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            Console.WriteLine("SQ area " + sq.Area());
            #endregion Inheritance Try/Catch

            List<Shape> shapes = new List<Shape>();
            shapes.Add(s);
            shapes.Add(new Square(4));
            shapes.Add(new Triangle(2, 4));
            shapes.Add(new Rectangle(4, 9));
            shapes.Add(new Triangle(2, 9));
            Console.WriteLine("List Contains " + shapes.Count + " Shapes");
            List<Shape> result = shapes.FindAll(p => p.Area() > 4);
            
            // Console.WriteLine(result.GetType());


            for (int i = 0; i < shapes.Count; i++)
            {
                //do something
                //var item = shapes[i];
                //item.Area();
                
            }

            foreach (var item in result)
            {
                Console.WriteLine(item.GetType());
                Console.WriteLine(item.Area());
                Console.WriteLine(item.ToString());
            }
            Circle c = Circle.GetCircle;
            c.Radius = 2;
            Circle c1 = Circle.GetCircle;
            Console.WriteLine(c.Area());
            
            Dictionary<string, Shape> dict = new Dictionary<string, Shape>();
            //dict.

            Console.ReadLine();


        }
    }
}
