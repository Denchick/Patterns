using System;
using Homework8.Visitors;

namespace Homework8.Shapes
{
    public class Cyllinder : Shape
    {
        public double Height { get; set; }
        public double Radius { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override double GetVolume()
        {
            return Math.PI * Radius * Radius * Height;
        }
    }
}