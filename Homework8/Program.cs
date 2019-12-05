using Homework8.Shapes;
using Homework8.Visitors;

namespace Homework8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var surfaceAreaVisitor = new DrawVisitor();
            var shapes = new Shape[]
            {
                new Ball {Radius = 3}, 
                new Cube {Size = 4}, 
                new Cyllinder {Height = 10, Radius = 5}
            };

            foreach (var shape in shapes)
            {
                shape.Accept(surfaceAreaVisitor);
            }
        }
        
    }
}