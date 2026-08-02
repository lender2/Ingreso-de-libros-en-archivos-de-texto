using System;
using System.IO;

namespace LibrosApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int cantidadLibros = 5;
            Libro[] libros = new Libro[cantidadLibros];

            Console.WriteLine("=================================================");
            Console.WriteLine(" REGISTRO DE LIBROS - Algoritmos Computacionales ");
            Console.WriteLine("=================================================");

            // ----- Captura de datos por teclado -----
            for (int i = 0; i < cantidadLibros; i++)
            {
                Console.WriteLine($"\n--- Ingrese los datos del Libro {i + 1} ---");

                Console.Write("Código: ");
                string codigo = Console.ReadLine();

                Console.Write("Título: ");
                string titulo = Console.ReadLine();

                Console.Write("Autor: ");
                string autor = Console.ReadLine();

                Console.Write("Año: ");
                int anio = LeerEntero();

                Console.Write("Editorial: ");
                string editorial = Console.ReadLine();

                Console.Write("Número de páginas: ");
                int numeroPaginas = LeerEntero();

                libros[i] = new Libro(codigo, titulo, autor, anio, editorial, numeroPaginas);
            }

            // ----- Mostrar los datos en pantalla -----
            Console.WriteLine("\n\n===== LISTADO DE LIBROS INGRESADOS =====");
            for (int i = 0; i < libros.Length; i++)
            {
                Console.WriteLine($"\nLibro {i + 1}");
                Console.WriteLine("-------------------");
                Console.WriteLine(libros[i]);
            }

            // ----- Guardar los datos en un archivo de texto -----
            string rutaArchivo = GuardarEnArchivo(libros);

            Console.WriteLine("\nLos datos se guardaron correctamente.");
            Console.WriteLine($"Ruta del archivo: {rutaArchivo}");

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }

        /// <summary>
        /// Solicita un número entero por teclado, validando que el usuario
        /// ingrese un valor numérico correcto.
        /// </summary>
        static int LeerEntero()
        {
            int valor;
            while (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.Write("Valor no válido. Por favor ingrese un número entero: ");
            }
            return valor;
        }

        /// <summary>
        /// Guarda el arreglo de libros en un archivo de texto (libros.txt)
        /// dentro de la carpeta del proyecto y devuelve la ruta completa.
        /// </summary>
        static string GuardarEnArchivo(Libro[] libros)
        {
            string nombreArchivo = "libros.txt";

            using (StreamWriter writer = new StreamWriter(nombreArchivo, false))
            {
                writer.WriteLine("===== LISTADO DE LIBROS =====");
                for (int i = 0; i < libros.Length; i++)
                {
                    writer.WriteLine();
                    writer.WriteLine($"Libro {i + 1}");
                    writer.WriteLine("-------------------");
                    writer.WriteLine(libros[i].ToString());
                }
            }

            return Path.GetFullPath(nombreArchivo);
        }
    }
}
