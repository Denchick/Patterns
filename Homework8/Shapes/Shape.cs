using Homework8.Visitors;

namespace Homework8.Shapes
{
    public abstract class Shape
    {
        public abstract double GetVolume();
        public abstract void Accept(IVisitor visitor);
    }
}