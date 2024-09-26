using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using Prueba2;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Clientes");
        Console.WriteLine("2. Alumnos");
        Console.WriteLine("3. Numeros Consecutivos");
        Console.WriteLine("4. Suma de los N primeros numeros pares");
        Console.WriteLine("5. Clave 'eureka'");
        Console.WriteLine("6. Numeros que son multiplos de 2 o de 3 entre 1 y 100");
        Console.WriteLine("7. Vectores");
        Console.WriteLine("8. Calcular en forma de tabla");

        Cliente cliente = new Cliente();
        Alumnos alumno = new Alumnos();
        VectorABC A = new VectorABC();
        VectorABC B = new VectorABC();
        VectorABC C = new VectorABC();


        int op = int.Parse(Console.ReadLine());
        switch (op)
        {
            case 1:
                Console.WriteLine("Ingrese el nombre del cliente: ");
                cliente.Nombre = Console.ReadLine();

                Console.WriteLine("Ingresa la cantidad de productos: ");
                cliente.Cantidad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el precio del producto: ");
                cliente.Precio = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese tipo de cliente: (A/B)");
                cliente.TipoCliente = Console.ReadLine();

                cliente.MostrarDatos();
                break;

            case 2:
                int aprobados = 0;
                int reprobados = 0;
                bool continuar;
                do
                {
                    Console.WriteLine("Ingrese el nombre del estudiante: ");
                    alumno.Nombre = Console.ReadLine();

                    Console.WriteLine("Digite la nota acumulada: ");
                    alumno.NotaAcumulada = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite la nota del examen: ");
                    alumno.NotaExamen = double.Parse(Console.ReadLine());
                    alumno.MostrarDatos();
                    if (alumno.CalcularNotaFinal() >= 60 && alumno.CalcularNotaFinal() <= 100)
                    {
                        aprobados++;
                    }
                    else if (alumno.CalcularNotaFinal() < 60)
                    {
                        reprobados++;
                    }

                    Console.WriteLine("Desea ingresar otro alumno? ");
                    if (Console.ReadLine().ToLower() == "si")
                    {
                        continuar = true;
                    }
                    else
                    {
                        continuar = false;
                        Console.WriteLine($"Reprobados: {reprobados}");
                        Console.WriteLine($"Aprobados: {aprobados}");
                    }


                } while (continuar);

                break;

            case 3:
                int suma = 0;
                for (int i = 101; i <= 201; i++)
                {
                    suma += i;
                }
                Console.WriteLine($"Suma: {suma}");

                break;

            case 4:
                int num = 0, cont = 0, sum = 0;

                Console.WriteLine("Ingrese el numero: ");
                num = int.Parse(Console.ReadLine());

                int temp = num;
                if (num % 2 != 0)
                {
                    num++;
                }

                sum = num;

                for (int i = 1; i <= temp; i++)
                {
                    cont += sum;
                    sum = sum + 2;
                }
                Console.WriteLine($"La suma es: {cont}");

                break;

            case 5:
                string eureka = "eureka";
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine("Digite la palabra: ");
                    string palabra = Console.ReadLine();
                    if (palabra.ToLower() == eureka)
                    {
                        Console.WriteLine("Correcto!");
                        break;
                    }
                    else
                    {
                        if ((3 - i) == 0)
                        {
                            Console.WriteLine("Haz perdido");
                            break;
                        }
                        Console.WriteLine($"Te quedan {3 - i} intentos");
                    }
                }
                break;

            case 6:
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"{i} es multiplo de 2");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine($"{i} es multiplo de 3");
                    }
                }
                break;

            case 7:
                Console.WriteLine("Ingrese las coordenadas del vector A (x y): ");
                A.X = double.Parse(Console.ReadLine());
                A.Y = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese las coordenadas del vector B (x y): ");
                B.X = double.Parse(Console.ReadLine());
                B.Y = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese las coordenadas del vector C (x y): ");
                C.X = double.Parse(Console.ReadLine());
                C.Y = double.Parse(Console.ReadLine());

                Triangulo triangulo = new Triangulo();
                triangulo.A = A;
                triangulo.B = B;
                triangulo.C = C;

                triangulo.MostrarInfo();

                break;

            case 8:
                Console.WriteLine(" N\tN^2\tN^3\tN^4");
                Console.WriteLine("--------------------------");

                for (int N = 1; N <= 10; N++)
                {
                    int n2 = N * N;
                    int n3 = N * N * N;
                    int n4 = N * N * N * N;

                    Console.WriteLine($"{N}\t{n2}\t{n3}\t{n4}");
                }

                break;

            default:
                Console.WriteLine("Opcion no valida");

                break;
        }
    }
}