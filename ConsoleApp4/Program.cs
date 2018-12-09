using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().PrimeraPractica();
        }

        /// <summary>
        /// este metodo muestra la primera practica
        /// </summary>
        public void PrimeraPractica()
        {
            foreach (var item in Empleado.GetAllEmpleados("v"))
            {
                Console.WriteLine("Nombre: " + item.Nombre + " " + item.Apellido);
                Console.WriteLine("Sueldo: " + item.Sueldo + "\n");
            }
            Console.ReadKey();
        }
    }
}
