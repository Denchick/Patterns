using System;
using Homework8.Shapes;

namespace Homework8.Visitors
{
    public class SurfaceAreaVisitor : IVisitor
    {
        public double SurfaceArea { get; private set; }
        public void Visit(Ball ball)
        {
            SurfaceArea = 4 * Math.PI * ball.Radius * ball.Radius;
        }

        public void Visit(Cube cube)
        {
            SurfaceArea = 6 * cube.Size * cube.Size;
        }

        public void Visit(Cyllinder cyllinder)
        {
            SurfaceArea = 2 * Math.PI * cyllinder.Radius * (cyllinder.Height + cyllinder.Radius);
        }
    }
}