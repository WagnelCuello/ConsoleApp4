using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Controller
    {
        public static void MostrarMatriz()
        {
            Console.Clear();
            Console.WriteLine("===> MATRIZ 3X4 <===");
            int[,] matriz = new int[3, 4];

            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    Console.Write("Ingrese un valor en la fila [{0}] columna [{1}]: ", fila, columna);
                    matriz[fila, columna] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\nImprimiendo la primera fila...");
            int[] fila1 = new int[4];
            for (int i = 0; i < 3; i++)
                for (int n = 0; n < 4; n++)
                    if (i == 0) fila1[n] = matriz[i, n];
            Console.WriteLine("[" + fila1[0] + "," + fila1[1] + "," + fila1[2] + "," + fila1[3] + "]");

            Console.WriteLine("Imprimiendo la ultima fila...");
            for (int i = 0; i < 3; i++)
                for (int n = 0; n < 4; n++)
                    if (i == 2) fila1[n] = matriz[i, n];
            Console.WriteLine("[" + fila1[0] + "," + fila1[1] + "," + fila1[2] + "," + fila1[3] + "]");

            Console.WriteLine("Imprimiendo la primera columna...");
            for (int i = 0; i < 3; i++)
                for (int n = 0; n < 4; n++)
                    if (i >= 0 && n == 0) fila1[i] = matriz[i, n];
            Console.WriteLine("[" + fila1[0] + "," + fila1[1] + "," + fila1[2] + "]");

            Console.Write("\nPresione una tecla para continuar...\n");
            Console.ReadKey();
        }

        public static void MostrarMenu()
        {
            int valor = 1;
            List<Empleado> listMatutinos = new List<Empleado>();
            List<Empleado> listVespertinos = new List<Empleado>();

            do
            {
                Console.Clear();
                Console.WriteLine("===> MANTENIMIENTO DE EMPLEADOS <===");
                Empleado e = new Empleado();
                Console.Write("Ingrese el nombre: ");
                e.Nombre = Console.ReadLine();
                Console.Write("Ingrese el apellido: ");
                e.Apellido = Console.ReadLine();
                Console.Write("Ingrese el turno: ");
                e.Turno = Console.ReadLine();
                Console.Write("Ingrese el sueldo: ");
                e.Sueldo = Decimal.Parse(Console.ReadLine());

                if (e.Turno == "mañana" || e.Turno == "matutino" || e.Turno == "m") listMatutinos.Add(e);
                else listVespertinos.Add(e);

                Console.WriteLine("---------------------------------");
                Console.WriteLine("[1] Volver");
                Console.WriteLine("[2] Mostrar");
                Console.WriteLine("[0] Salir");
                Console.Write("Ingrese un valor: ");
                valor = Convert.ToInt32(Console.ReadLine());
                if (valor == 2)
                {
                    // Turno matutino
                    Console.WriteLine("\nEmpleados turno de la mañana...");
                    foreach (var item in listMatutinos)
                    {
                        Console.WriteLine("Nombre: {0} {1}", item.Nombre, item.Apellido);
                        Console.WriteLine("Sueldo: {0}\n", item.Sueldo);
                    }
                    // Turno vespertino
                    Console.WriteLine("Empleados turno de la tarde...");
                    foreach (var item in listVespertinos)
                    {
                        Console.WriteLine("Nombre: {0} {1}", item.Nombre, item.Apellido);
                        Console.WriteLine("Sueldo: {0}\n", item.Sueldo);
                    }
                    Console.WriteLine("\n[1] Ir al menu anterior");
                    Console.WriteLine("[0] Salir");
                    Console.Write("Ingrese una opcion: ");
                    valor = int.Parse(Console.ReadLine());
                }
            } while (valor > 0);
        }
    }
}
