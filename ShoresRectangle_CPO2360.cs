using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShoresRectangle_CPO2360
{
    class Rectangle // I selected rectangle class and desconstruct example from the txt.
    {
        public readonly float Width, Height; //Read only for Height and width of the Rectangle. 

        public Rectangle(float width, float height) 
        {
            Width = width;
            Height = height;
        }

        public void Deconstruct(out float width, out float height)
        {
            width = Width;
            height = Height;

            /* It feels like there should be a calculation here for either area (w*h) or perimeter ((2*W) + (2*h)). 
            I went with area. */
        }

        public float CalculateArea() { return Height * Width; } //this calculation is provided by VS\C#.
    }
    internal class Program

        /* From the Class.txt
            To call the deconstructor, we use the following special syntax:
            var rect = new Rectangle(3, 4);
            (float width, float height) = rect;       // Deconstruction
            Console.WriteLine(width + " " + height);  // 3 4

            // We can also use implicit typing:  
            var(x, y) = rect;  // Deconstruction
            Console.WriteLine(x + " " + y); 
           
            My attempt below */
    {
        static void Main(string[] args)
        {
            var rect = new Rectangle(1013, 2024);
            float Area = rect.CalculateArea();
            (float w, float h) = rect;
            Console.WriteLine("Width = {w}");
            Console.WriteLine("Height = {h}");
            Console.WriteLine(Area); 
            
        }
    }
}
