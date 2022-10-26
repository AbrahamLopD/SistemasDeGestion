using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Pages_Entidades
{
    public class Persona
    {
        private string nombre;
        private string apellidos;

        public Persona()
        {
            this.Nombre = "";
            this.Apellidos = "";
        }

        public Persona(string nombre, string apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
    }
}
