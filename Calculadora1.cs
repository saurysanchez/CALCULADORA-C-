using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";

            while (opcion != "0")
            {
                Console.Clear();
                Console.WriteLine("===== MENU DE LA CALCULADORA =====");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Ver si un estudiante aprobo");
                Console.WriteLine("0. Salir");
                Console.Write("Elija una opcion: ");
                opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Sumar();
                }
                else if (opcion == "2")
                {
                    Restar();
                }
                else if (opcion == "3")
                {
                    Multiplicar();
                }
                else if (opcion == "4")
                {
                    Dividir();
                }
                else if (opcion == "5")
                {
                    Estudiante();
                }
                else if (opcion == "0")
                {
                    Console.WriteLine("Adios!");
                }
                else
                {
                    Console.WriteLine("Esa opcion no existe.");
                }

                if (opcion != "0")
                {
                    Console.WriteLine();
                    Console.WriteLine("Presione Enter para volver al menu...");
                    Console.ReadLine();
                }
            }
        }

        static void Sumar()
        {
            try
            {
                Console.Write("Primer numero: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Segundo numero: ");
                double b = Convert.ToDouble(Console.ReadLine());

                double resultado = a + b;
                Console.WriteLine("Resultado: " + resultado);
            }
            catch
            {
                Console.WriteLine("Error: debe escribir solo numeros.");
            }
        }

        static void Restar()
        {
            try
            {
                Console.Write("Primer numero: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Segundo numero: ");
                double b = Convert.ToDouble(Console.ReadLine());

                double resultado = a - b;
                Console.WriteLine("Resultado: " + resultado);
            }
            catch
            {
                Console.WriteLine("Error: debe escribir solo numeros.");
            }
        }

        static void Multiplicar()
        {
            try
            {
                Console.Write("Primer numero: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Segundo numero: ");
                double b = Convert.ToDouble(Console.ReadLine());

                double resultado = a * b;
                Console.WriteLine("Resultado: " + resultado);
            }
            catch
            {
                Console.WriteLine("Error: debe escribir solo numeros.");
            }
        }

        static void Dividir()
        {
            try
            {
                Console.Write("Primer numero: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Segundo numero: ");
                double b = Convert.ToDouble(Console.ReadLine());

                if (b == 0)
                {
                    Console.WriteLine("Error: no se puede dividir entre cero.");
                }
                else
                {
                    double resultado = a / b;
                    Console.WriteLine("Resultado: " + resultado);
                }
            }
            catch
            {
                Console.WriteLine("Error: debe escribir solo numeros.");
            }
        }

        static void Estudiante()
        {
            try
            {
                Console.Write("Nombre del estudiante: ");
                string nombre = Console.ReadLine();

                Console.Write("Cuantas notas va a ingresar: ");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                if (cantidad <= 0)
                {
                    Console.WriteLine("Error: debe ingresar al menos una nota.");
                    return;
                }

                double suma = 0;

                for (int i = 1; i <= cantidad; i++)
                {
                    Console.Write("Nota " + i + " (0 a 100): ");
                    double nota = Convert.ToDouble(Console.ReadLine());

                    while (nota < 0 || nota > 100)
                    {
                        Console.WriteLine("La nota debe estar entre 0 y 100.");
                        Console.Write("Nota " + i + " (0 a 100): ");
                        nota = Convert.ToDouble(Console.ReadLine());
                    }

                    suma = suma + nota;
                }

                double promedio = suma / cantidad;

                Console.WriteLine();
                Console.WriteLine("Estudiante: " + nombre);
                Console.WriteLine("Promedio: " + promedio);

                if (promedio >= 70)
                {
                    Console.WriteLine("Resultado: APROBADO");
                }
                else
                {
                    Console.WriteLine("Resultado: REPROBADO");
                }
            }
            catch
            {
                Console.WriteLine("Error: debe escribir solo numeros donde se piden numeros.");
            }
        }
    }
}