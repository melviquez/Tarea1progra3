using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1progra3
{
    using System;

    namespace TAREA1
    {
        using System;
        using System.Collections.Generic;

        namespace TAREA1
        {
            internal class Estudiante
            {
                public string Nombre { get; set; }
                private int Edad;
                public double Promedio { get; set; }

                public void SetEdad(int edad)
                {
                    Edad = edad;
                }

                public bool EsMayorDeEdad()
                {
                    return Edad >= 18;
                }

                public void MostrarInfo()
                {
                    Console.WriteLine($"Nombre: {Nombre}, Promedio: {Promedio:F2}");
                }
            }

            internal class Program
            {
                static void Main(string[] args)
                {
                    List<Estudiante> estudiantes = new List<Estudiante>();
                    int cantidadEstudiantes;

                    Console.Write("Ingrese la cantidad de estudiantes a registrar: ");
                    cantidadEstudiantes = int.Parse(Console.ReadLine());

                    for (int i = 0; i < cantidadEstudiantes; i++)
                    {
                        Estudiante estudiante = new Estudiante();

                        Console.Write($"\nIngrese el nombre del estudiante #{i + 1}: ");
                        estudiante.Nombre = Console.ReadLine();

                        Console.Write("Ingrese la edad del estudiante: ");
                        estudiante.SetEdad(int.Parse(Console.ReadLine()));

                        Console.Write("Ingrese el promedio del estudiante: ");
                        estudiante.Promedio = double.Parse(Console.ReadLine());

                        estudiantes.Add(estudiante);
                    }

                    Console.WriteLine("\nEstudiantes con promedio mayor o igual a 70:");
                    int contador = 0;

                    while (contador < estudiantes.Count)
                    {
                        if (estudiantes[contador].Promedio >= 70)
                        {
                            estudiantes[contador].MostrarInfo();

                            if (estudiantes[contador].EsMayorDeEdad())
                            {
                                Console.WriteLine($"{estudiantes[contador].Nombre} es mayor de edad.");
                            }
                            else
                            {
                                Console.WriteLine($"{estudiantes[contador].Nombre} no es mayor de edad.");
                            }
                        }
                        contador++;
                    }

                    Console.WriteLine("\nPresione Enter para continuar...");
                    Console.ReadLine();
                }
            }
        }

    }
}
