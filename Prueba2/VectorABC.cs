using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2
{
    public class VectorABC
    {
        public double X { get; set; }
        public double Y { get; set; }

        public VectorABC(double x, double y)
        {
            X = x;
            Y = y;
        }

        public VectorABC()
        {

        }

        public double Magnitud()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public static double Distacia(VectorABC a, VectorABC b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }
    }

    public class Triangulo
    {
        public VectorABC A { get; set; }
        public VectorABC B { get; set; }
        public VectorABC C { get; set; }

        public bool esTriangulo()
        {
            double ab = VectorABC.Distacia(A, B);
            double bc = VectorABC.Distacia(B, C);
            double ca = VectorABC.Distacia(C, A);

            return (ab + bc > ca) && (ab + ca > bc) && (bc + ca > ab);
        }

        public double Perimetro()
        {
            double ab = VectorABC.Distacia(A, B);
            double bc = VectorABC.Distacia(B, C);
            double ca = VectorABC.Distacia(C, A);

            return ab + bc + ca;
        }

        public string TipoDeTriangulo()
        {
            double ab = VectorABC.Distacia(A, B);
            double bc = VectorABC.Distacia(B, C);
            double ca = VectorABC.Distacia(C, A);

            if (ab == bc && bc == ca)
            {
                return "EQUILATERO";
            }
            else if (ab == bc || bc == ca || ca == ab)
            {
                return "ISOSCELES";
            }
            else
            {
                return "ESCALENO";
            }
        }

        public void MostrarInfo()
        {
            if (esTriangulo())
            {
                Console.WriteLine("Los vectores forman un triangulo");
                Console.WriteLine($"Perimetro: {Perimetro():F2}");
                Console.WriteLine($"Tipo de triangulo: {TipoDeTriangulo()}");
            }
            else
            {
                Console.WriteLine("Los vectores no forman ningun triangulo");
            }
        }
    }
}
