using System;

namespace LibrosApp
{
    /// <summary>
    /// Representa un libro con su información básica.
    /// </summary>
    public class Libro
    {
        public string Codigo { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Anio { get; set; }
        public string Editorial { get; set; }
        public int NumeroPaginas { get; set; }

        public Libro() { }

        public Libro(string codigo, string titulo, string autor, int anio, string editorial, int numeroPaginas)
        {
            Codigo = codigo;
            Titulo = titulo;
            Autor = autor;
            Anio = anio;
            Editorial = editorial;
            NumeroPaginas = numeroPaginas;
        }

        /// <summary>
        /// Devuelve la información del libro formateada para mostrarla
        /// en pantalla o guardarla en el archivo de texto.
        /// </summary>
        public override string ToString()
        {
            return $"Código: {Codigo}{Environment.NewLine}" +
                   $"Título: {Titulo}{Environment.NewLine}" +
                   $"Autor: {Autor}{Environment.NewLine}" +
                   $"Año: {Anio}{Environment.NewLine}" +
                   $"Editorial: {Editorial}{Environment.NewLine}" +
                   $"Número de páginas: {NumeroPaginas}";
        }
    }
}
