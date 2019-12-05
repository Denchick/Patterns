using System;
using Homework8.Visitors;

namespace Homework8.Shapes
{
    public class Ball : Shape
    {
        public double Radius { get; set; }
        public override double GetVolume()
        {
            return 4.0 * Math.PI * Radius * Radius * Radius / 3;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}