using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ControlEmpleado
{

    internal class Empleado

    { static int opcion = 0;
        public static string[] nombre = new string[1];  // nombre dela persona
        public static float[]salario = new float[1];         //salario
        public static string[]direccion = new string[1];  // direccion 
        public static float[] telefono= new float[1];      // numero de telefono
        public static string[] cedula = new string[1];            // cedula de la persona
        

        // metodo para inicializar arreglos
        public static void inicializarArreglos()
        {

            for (int i = 0; i < cedula.Length; i++)
            {
                cedula[i] = "";
                nombre[i] = "";
                salario[i] = 0;
                telefono[i] = 0;
                direccion[i]= "";
            }
            Console.WriteLine("Los arreglos han sido inicializados");
            Console.Clear();

        }

        public static void ReporteEmpleado() 
        {
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine($" Nombre: {nombre[i]}  Cedula: {cedula[i]} Telefono: {telefono[i]}  Direccion: {direccion[i]}  Salario: {salario[i]} ");

            }
        
        }

        public static void Reporte()
        {
            do
            {

                opcion = 0;
                Console.WriteLine("1 - Lista Empleados ");
                Console.WriteLine("2 - Calcular promedio salario ");
                Console.WriteLine("3 - Salir ");
                Console.WriteLine("Digite Una Opcion ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: Empleado.ReporteEmpleado(); break;
                    case 2: Empleado.reporteCalculoPromedio(); break;
                    case 3: menu(); break;
                    default:
                        break;

                }

            } while (opcion != 7);
        
        
        }

        public static void reporteCalculoPromedio()
        {
            float promedioSalario = 0;
            for (int i = 0;i < cedula.Length; i++)
            {
                promedioSalario += salario[i];
            }
            promedioSalario/= salario.Length;
            Console.WriteLine($"El promedio de los salarios es de: {promedioSalario} ");

        }


        // metodo para ingresar Empleado
        public static void ingresarEmpleado()
        {
            Console.Clear();
            int indice = 0;
            while (indice < cedula.Length)
            {

                Console.Write("Digite el Nombre del Empleado: ");
                nombre[indice] = Console.ReadLine();
                Console.Write("Digite el numero de cedula: ");
                cedula[indice] = (Console.ReadLine());
                Console.Write("Digite la Direccion: ");
                direccion[indice] = Console.ReadLine();
                Console.Write("Digite el Telefono: ");
                telefono[indice] = float.Parse(Console.ReadLine()); 
                Console.Write("Digite el Salario: ");
                salario[indice] = float.Parse(Console.ReadLine());
               
                indice++;
                Console.Clear();
            }
            Console.WriteLine("El Empleado fue agregado con exito");
        }

        // metodo para modificar Empleados
        public static void modificarEmpleado()
        {

            Console.Clear();
            Console.Write("Digite el Numero de Cedula del Empleado que desea modificar: ");
            s nuevocodigo =Console.ReadLine();

            for (int i = 0; i < cedula.Length; i++)
            {
                if ( nuevocodigo = cedula[i])
                {
                    Console.WriteLine($" Nombre: {nombre[i]}  Cedula: {cedula[i]} Telefono: {telefono[i]}  Direccion: {direccion[i]}  Salario: {salario[i]} ");
                    Console.Write("Digite un Nombre: ");
                    nombre[i] = Console.ReadLine();
                    break;
                }

            }

        }

        

        // metodo para consultar Empleado
        public static void consultarCedula()
        {
            Console.Clear();
            Console.WriteLine("Digite el Numero De Cedula: ");
            int CedulaEmpleado = int.Parse(Console.ReadLine());
            for (int i = 0; i < cedula.Length; i++)
            {
                if (CedulaEmpleado == cedula[i])
                {
                    Console.WriteLine($"Nombre: {nombre[i]} Cedula: {cedula[i]}  Telefono: {telefono[i]} Direccion:{direccion[i]} Salario:{salario[i]}");
                    nombre[i] = Console.ReadLine();
                    break;
                }
            }
            Console.WriteLine("*** FIN DEL REPORTE ***");
        }

        // metodo para eliminar Empleado
        public static void excluirEmpleado()
        {
            string Empleado = "";
            Console.Clear();
            Console.WriteLine("Digite el nombre del Empleado que desea borrar ");
            Empleado = Console.ReadLine();
            for (int i = 0; i < cedula.Length; i++) { 
              
                if (nombre[i] == Empleado)
                {
                    nombre[i] = "";

                }
            }
        
        
        }


    }
}