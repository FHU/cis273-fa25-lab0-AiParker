using System;

namespace Vector
{
    public struct Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double Magnitude => Math.Sqrt(X * X + Y * Y);
        public double Direction => Math.Atan2(Y, X) * (180.0 / Math.PI);

        public Vector Add(Vector v) => new Vector { X = X + v.X, Y = Y + v.Y };
        public Vector Subtract(Vector v) => new Vector { X = X - v.X, Y = Y - v.Y };
        public double Dot(Vector v) => X * v.X + Y * v.Y;
        public double AngleBetween(Vector v) => Math.Acos(Dot(v) / (Magnitude * v.Magnitude)) * (180.0 / Math.PI);
        public Vector Multiply(double scalar) => new Vector { X = X * scalar, Y = Y * scalar };
        public Vector Divide(double scalar) => new Vector { X = X / scalar, Y = Y / scalar };
        public Vector Normalize() => Divide(Magnitude);
        public override string ToString() => $"<{X}, {Y}>";

        public static Vector Add(Vector v1, Vector v2) => new Vector { X = v1.X + v2.X, Y = v1.Y + v2.Y };
        public static Vector Subtract(Vector v1, Vector v2) => new Vector { X = v1.X - v2.X, Y = v1.Y - v2.Y };
        public static double Dot(Vector v1, Vector v2) => v1.X * v2.X + v1.Y * v2.Y;
        public static double AngleBetween(Vector v1, Vector v2) => Math.Acos(Dot(v1, v2) / (v1.Magnitude * v2.Magnitude)) * (180.0 / Math.PI);
        public static Vector Multiply(Vector v, double scalar) => new Vector { X = v.X * scalar, Y = v.Y * scalar };
        public static Vector Divide(Vector v, double scalar) => new Vector { X = v.X / scalar, Y = v.Y / scalar };
        public static Vector Normalize(Vector v) => v.Divide(v.Magnitude);

        public static Vector operator +(Vector v1, Vector v2) => Add(v1, v2);
        public static Vector operator -(Vector v1, Vector v2) => Subtract(v1, v2);
        public static double operator *(Vector v1, Vector v2) => Dot(v1, v2);
        public static Vector operator *(Vector v, double scalar) => Multiply(v, scalar);
        public static Vector operator /(Vector v, double scalar) => Divide(v, scalar);
    }
}
