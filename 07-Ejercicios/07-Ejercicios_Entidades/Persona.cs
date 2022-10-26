using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Ejercicios_Entidades
{
    public class Persona
    {
        #region Atributos
        private int id;
        private int idDepartamento;
        private string nombre;
        private string apellidos;
        #endregion

        #region Constructor
        public Persona()
        {
            this.idDepartamento = 1;
            this.nombre = "";
            this.apellidos = "";

        }

        public Persona(int id, int idDepartamento, string nombre, string apellidos)
        {
            this.id = id;
            this.idDepartamento = idDepartamento;
            this.nombre = nombre;
            this.apellidos = apellidos;
        }
        #endregion

        #region Getters y Setters
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Id { get => id; set => id = value; }
        public int IdDepartamento { get => idDepartamento; set => idDepartamento = value; }
        #endregion
    }
}
