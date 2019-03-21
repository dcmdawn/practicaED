using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_2_3
{
    class Ejercicio_6_2_3
    {
        static void Main(string[] args)
        {

            Libro book = new Libro("J.K. Rowling", "El caliz de fuego", "Hogwarts");
            Documento makingDocument = new Documento();
            Libro makingook = new Libro();

            makingDocument.mostrar();
            makingook.mostrar();

            /*book.SetAutor("Harry Potter");
            book.SetTitulo("La Piedra Filosofal");
            book.SetUbicacion("Hogwarts");
            Console.WriteLine("El Autor es: " + book.GetAutor());
            Console.WriteLine("El Título es: " + book.GetTitulo());
            Console.WriteLine("La Ubicación es: " + book.GetUbicacion());*/
        }
    }
}
