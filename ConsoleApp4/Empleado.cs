using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Sueldo { get; set; }
        public string Turno { get; set; }

        /// <summary>
        /// Este metodo retorna una lista de todos los empleados
        /// </summary>
        /// <param name="turno">[m] turno de la mañana, [v] turno de la tarde</param>
        /// <returns>Lista de empleados con turno de la mañana o tarde</returns>
        public static List<Empleado> GetAllEmpleados(string turno)
        {
            var listMatutino = new List<Empleado>()
            {
                new Empleado()
                {
                    Nombre = "ROBERTO",
                    Apellido = "DE LEON",
                    Sueldo = 25000,
                    Turno = "MATUTINO"
                },
                new Empleado()
                {
                    Nombre = "MARIO",
                    Apellido = "CIMARRO",
                    Sueldo = 25000,
                    Turno = "MATUTINO"
                },
                new Empleado()
                {
                    Nombre = "JULIO",
                    Apellido = "PEREZ",
                    Sueldo = 25000,
                    Turno = "MATUTINO"
                }
            };
            var listVespertino = new List<Empleado>()
            {
                new Empleado()
                {
                    Nombre = "JULIA",
                    Apellido = "MATOS",
                    Sueldo = 30000,
                    Turno = "VESPERTINO"
                },
                new Empleado()
                {
                    Nombre = "PEDRO",
                    Apellido = "MARTINEZ",
                    Sueldo = 30000,
                    Turno = "VESPERTINO"
                },
                new Empleado()
                {
                    Nombre = "TU",
                    Apellido = "CAMARON",
                    Sueldo = 30000,
                    Turno = "VESPERTINO"
                }
            };
            if (turno == "m") return listMatutino; else return listVespertino;
        }
    }
}
