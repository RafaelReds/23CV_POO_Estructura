using POO_Estructura.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace POO_Estructura.Services
{
    public class AlumnoService
    {
        public Alumno Agregar()
        {

            try
            {
                Alumno Res = new Alumno()
                {
                    ID = 1,
                    Nombre = "Rafael",
                    Apellido = "Rojas",
                    FechaDeIngreso = DateTime.Now,
                    Grado = 3,
                    Promedio = 8.5

                };
                return Res;
            }
           catch (Exception ex) 
            {

                throw new Exception("Ocurrio un error. :( " + ex.Message);

            }
        }

        public void Imprimir(Alumno Request)
        {
            try
            {
                Console.WriteLine("Fecha de Ingreso: " + Request.FechaDeIngreso);
                Console.WriteLine("Nombre: "+Request.Nombre);
                Console.WriteLine("Apellido: " + Request.Apellido);
                Console.WriteLine("Grado: " + Request.Grado);
            }
            catch (Exception ex) 
            {
                throw new Exception("Ocurrio un error. :( "+ex.Message);   
            }
        }

        #region ------ Validar aprobación / Validar promedio

        public bool ValidarProm(double Num1)
        {
            bool Validar = false;
            if (Num1 > 7) 
            {
                Validar = true;
            }
            return Validar;
        }

        #endregion 


    }
}

