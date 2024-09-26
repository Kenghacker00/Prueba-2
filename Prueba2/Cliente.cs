using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public string TipoCliente { get; set; }

        public Cliente(string nombre, int cantidad, double precio, string tipoCliente)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
            TipoCliente = tipoCliente;
        }

        public Cliente()
        {
        }

        public double CalcularSubtotal()
        {
            return Cantidad * Precio;
        }

        public double CalcularDescuento(double subtotal)
        {
            double porcDescuento;
            if (TipoCliente == "A" || Cantidad > 100)
            {
                porcDescuento = 0.10;
            }
            else
            {
                porcDescuento = 0.05;
            }
            return subtotal * porcDescuento;
        }

        public double CalcularImpuesto(double subtotalConImpesto)
        {
            return subtotalConImpesto * 0.15;
        }

        public double CalcularTotal(double subtotalConImpesto, double impuesto)
        {
            return subtotalConImpesto + impuesto;
        }

        public void MostrarDatos()
        {
            double subtotal = CalcularSubtotal();
            double montoDescuento = CalcularDescuento(subtotal);
            double subtotalConDescuento = subtotal - montoDescuento;
            double impuesto = CalcularImpuesto(subtotalConDescuento);
            double total = CalcularTotal(subtotalConDescuento, impuesto);

            Console.WriteLine($"Nombre del cliente {Nombre}");
            Console.WriteLine($"Subtotal: {subtotal}");
            Console.WriteLine($"Monto del descuento {montoDescuento}");
            Console.WriteLine($"Impuesto: {impuesto}");
            Console.WriteLine($"Total a pagar: {total}");
        }

    }
}