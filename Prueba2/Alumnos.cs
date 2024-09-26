using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2
{
    public class Alumnos
    {
        public string Nombre { get; set; }
        public double NotaExamen { get; set; }
        public double NotaAcumulada { get; set; }
        public double NotaFinal { get; set; }

        public Alumnos(string nombre, double notaExamen, double notaAcumulada, double notaFinal)
        {
            Nombre = nombre;
            NotaExamen = notaExamen;
            NotaAcumulada = notaAcumulada;
            NotaFinal = notaFinal;
        }

        public Alumnos()
        {
        }

        public double CalcularNotaFinal()
        {
            double NotaFinal = NotaAcumulada + NotaExamen;
            return NotaFinal;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre del estudiante {Nombre}");
            Console.WriteLine($"Nota final: {CalcularNotaFinal()}");
            if (CalcularNotaFinal() >= 60 && CalcularNotaFinal() <= 100)
            {
                Console.WriteLine("Aprobado, felicidades");
            }
            else if (CalcularNotaFinal() < 60)
            {
                Console.WriteLine("Mala noticia, reprobado");
            }
            else
            {
                Console.WriteLine("Nota incorrecta");
            }
        }

    }
}
