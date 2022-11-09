using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Ejercicio_Entidades
{
    public class Mision
    {
        int id;
        string titulo;
        string descripcion;
        int credito;

        public Mision()
        {
            this.titulo = "";
            this.descripcion = "";
            this.credito = 0;
        }

        public Mision(int id, string titulo, string descripcion, int credito)
        {
            this.id = id;
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.credito = credito;
        }

        public int Id { get => id; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Credito { get => credito; set => credito = value; }
    }
}
