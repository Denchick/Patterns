using Homework8.Shapes;

namespace Homework8.Visitors
{
    public interface IVisitor
    {
        void Visit(Ball ball);
        void Visit(Cube cube);
        void Visit(Cyllinder cyllinder);
    }
}