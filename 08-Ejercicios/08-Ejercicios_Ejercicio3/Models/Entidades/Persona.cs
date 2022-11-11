using System.ComponentModel.DataAnnotations;

namespace _08_Ejercicios_Ejercicio3.Models.Entidades
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellidos;
        private int edad;
        private string telefono;

        public Persona()
        {
            this.id = -1;
            this.nombre = "";
            this.apellidos = "";
            this.edad = 18;
            this.telefono = "";
        }

        public Persona(string nombre, string apellidos, int edad, string telefono)
        {
            this.id = -1;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
            this.telefono = telefono;
        }

        public int Id { get => id; }
        [Required(ErrorMessage = "Campo Obligatorio")] 
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        //[MaxLength(50), Required]
        public int Edad { get => edad; set => edad = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
