using ControlEmpleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ControlEmpleado
{
    internal class menu
    {
        // menu principal
        public static void principal()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("1- Inicialiazar arreglos");
                Console.WriteLine("2- Ingresar Nombre de Empleado");
                Console.WriteLine("3- Modificar Empleado");
                Console.WriteLine("4- Borrar Empleado");
                Console.WriteLine("5- Consultar Empleado");
                Console.WriteLine("6- Reporte");
                Console.WriteLine("7- Salir");
                Console.WriteLine("Digite una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: Empleado.inicializarArreglos(); break;
                    case 2: Empleado.ingresarEmpleado(); break;
                    case 3: Empleado.modificarEmpleado(); break;
                    case 4: Empleado.excluirEmpleado(); break;
                    case 5: Empleado.consultarCedula(); break;
                    case 6: Empleado.ReporteEmpleado(); break;
                    case 7: Console.WriteLine("Saliendo del sistema"); break;
                    default: Console.WriteLine("*** Opcion incorrecta ***"); break;


                }
            } while (opcion != 7);   // mientras opcion sea diferente de 7 ==> true

        }

    }
}