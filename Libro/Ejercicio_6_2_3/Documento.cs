using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_2_3
{
    class Documento
    {

        protected string autor;
        protected string titulo;
        protected string ubicacion;
        protected string crear;

        public Documento()
        {
            crear = "Creando documento";
        }
        public void mostrar()
        {
            Console.WriteLine(crear);
        }

        public void SetAutor (string NombreAutor)
        {
            autor = NombreAutor;
        }
        public void SetTitulo(string NombreTitulo)
        {
            titulo = NombreTitulo;
        }
        public void SetUbicacion(string Localizacion)
        {
            ubicacion = Localizacion;
        }
        public string GetAutor()
        {
            return autor;
        }
        public string GetTitulo()
        {
            return titulo;
        }
        public string GetUbicacion()
        {
            return ubicacion;
        }

    }
}
