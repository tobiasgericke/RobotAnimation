using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAnimation
{
    internal class TeachPoint
    {
        private double angle;
        private double radius;

        public TeachPoint(double angle, double radius)
        {
            this.angle = angle;
            this.radius = radius;
        }

        public double Angle
        {
            get => angle;
            set => radius = value;
        }
        public double Radius
        {
            get => radius;
            set => radius = value;
        }
    }
}
