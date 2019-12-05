using System;
using Homework8.Shapes;

namespace Homework8.Visitors
{
    public class DrawVisitor: IVisitor
    {
        public void Visit(Ball ball)
        {
            Console.WriteLine($"Draw ball with radius {ball.Radius}");
        }

        public void Visit(Cube cube)
        {
            Console.WriteLine($"Draw cube with edge lenght {cube.Size}");
        }

        public void Visit(Cyllinder cyllinder)
        {
            Console.WriteLine($"Draw cyllinder with height {cyllinder.Height} and raduis {cyllinder.Radius}");
        }
    }
}