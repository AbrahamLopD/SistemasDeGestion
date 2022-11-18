using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Ejercicios_Entidades
{
    public class Persona
    {

        #region Atributos
        private int id;
        private string nombre;
        private string apellidos;
        private string telefono;
        private string direccion;
        private string foto;
        private DateTime fechaNacimiento;
        private int idDepartamento;
        #endregion

        #region Constructor
        public Persona()
        {
            this.nombre = "";
            this.apellidos = "";
            this.telefono = "";
            this.direccion = "";
            this.foto = "";
            this.fechaNacimiento = DateTime.Now;
            this.idDepartamento = 1;
        }

        public Persona(string nombre, string apellidos, string telefono, string direccion, string foto, DateTime fechaNacimiento, int idDepartamento)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.direccion = direccion;
            this.foto = foto;
            this.fechaNacimiento = fechaNacimiento;
            this.idDepartamento = idDepartamento;
        }
        #endregion

        #region Getters y Setters
        public int Id { get => id; set => id = value;  }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Foto { get => foto; set => foto = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int IdDepartamento { get => idDepartamento; set => idDepartamento = value; }
        #endregion
    }
}
