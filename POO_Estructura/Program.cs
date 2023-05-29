using POO_Estructura.Entities;
using POO_Estructura.Services;
using System;

namespace POO_Estructura
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            AlumnoService Servicio = new AlumnoService();
            Alumno Alumno1 = Servicio.Agregar();

            Servicio.Imprimir(Alumno1);

            Console.WriteLine("La calificación es: " + Servicio.ValidarProm(Alumno1.Promedio));

            Console.WriteLine("Hello World!");
        }
    }
}
