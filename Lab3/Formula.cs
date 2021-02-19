using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Formula
    {
        public struct Speed
        {
            public decimal v0;
            public decimal vx;
            public decimal vy;
        }
        public struct Coordinates
        {
            public decimal x;
            public decimal y;
        }
        public struct Angle
        {
            public double a;
            public decimal cosa;
            public decimal sina;
        }
        public struct Parameters
        {
            public decimal size;
            public decimal weight;
        }

        const decimal g = 9.81M;
        const decimal C = 0.15M;
        const decimal rho = 1.29M;
        const decimal dt = 0.1M;

        public Speed speed;
        public Coordinates coordinates;
        public Angle angle;
        public Parameters parameters;
        public decimal time;
        public decimal koef;

        public Formula(decimal _y, decimal _v0, double _a, decimal _size, decimal _weight)
        {
            time = 0;
            coordinates.x = 0;
            coordinates.y = _y;
            speed.v0 = _v0;
            angle.a = _a;
            angle.cosa = (decimal)Math.Cos(angle.a);
            angle.sina = (decimal)Math.Sin(angle.a);
            parameters.size = _size;
            parameters.weight = _weight;
            koef = 0.5M * C * rho * parameters.size / parameters.weight;
            speed.vx = speed.v0 * angle.cosa;
            speed.vy = speed.v0 * angle.sina;
        }

        public void FindNewCoordinates()
        {
            time += dt;
            decimal v = (decimal)Math.Sqrt((double)(speed.vx * speed.vx + speed.vy * speed.vy));
            speed.vx = speed.vx - koef * speed.vx * v * dt;
            speed.vy = speed.vy - (g + koef * speed.vy * v) * dt;
            coordinates.x = coordinates.x + speed.vx * dt;
            coordinates.y = coordinates.y + speed.vy * dt;
        }
    }
}
