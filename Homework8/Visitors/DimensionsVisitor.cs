using Homework8.Shapes;

namespace Homework8.Visitors
{
    public class DimensionsVisitor : IVisitor
    {
        public Dimensions Dimensions { get; private set; }
        public void Visit(Ball ball)
        {
            Dimensions = new Dimensions(2 * ball.Radius, 2 * ball.Radius);
        }

        public void Visit(Cube cube)
        {
            Dimensions = new Dimensions(cube.Size, cube.Size);
        }

        public void Visit(Cyllinder cyllinder)
        {
            Dimensions = new Dimensions(2 * cyllinder.Radius, cyllinder.Height);
        }
    }
}