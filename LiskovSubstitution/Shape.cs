using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class Shape
    {

        public  virtual void draw()
        {
            Console.WriteLine("Draw Shape");

        }


    }

    public class Circle : Shape
    {

        public override void draw()
        {
            Console.WriteLine("Draw circle");
        }

    }


    public class Client
    {

        public  void draw(Shape shape)
        {
            shape.draw();
        }
    }





}
