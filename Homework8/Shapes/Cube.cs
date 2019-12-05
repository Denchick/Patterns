using Homework8.Visitors;

namespace Homework8.Shapes
{
    public class Cube : Shape
    {
        public double Size { get; set; }
        public override double GetVolume()
        {
            return Size * Size * Size;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}