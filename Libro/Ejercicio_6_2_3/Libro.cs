using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_2_3
{
    class Libro : Documento
    {
        protected int paginas;

        public Libro(string aut, string titu, string ubi)
        {
            autor = aut;
            titulo = titu;
            ubicacion = ubi;
            Console.WriteLine("El Autor es: " + autor + " el título es: " + titulo + " la ubicación es: " + ubicacion);
        }

        public Libro(string aut, string titu)
        {
            autor = aut;
            titulo = titu;
            ubicacion = "No detallada";
            Console.WriteLine("El Autor es: " + autor + " el título es: " + titulo + " la ubicación es: " + ubicacion);
        }

        public Libro()
        {
            crear = "Creando libro";
        }

        public void SetPaginas(int NumPag)
        {
            paginas = NumPag;
        }

        public int GetPaginas()
        {
            return paginas;
        }

    }
}
