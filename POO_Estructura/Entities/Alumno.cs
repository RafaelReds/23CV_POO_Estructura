using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Estructura.Entities
{
    public class Alumno
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaDeIngreso { get; set; }
        public int Grado { get; set; }
        public double Promedio { get; set; } //Es double porque puede ser decimal.

    }
}
