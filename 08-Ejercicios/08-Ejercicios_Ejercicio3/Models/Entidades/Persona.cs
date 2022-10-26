namespace _08_Ejercicios_Ejercicio3.Models.Entidades
{
    public class Persona
    {
        private string nombre;
        private string apellidos;
        private int edad;

        public Persona()
        {
            this.nombre = "";
            this.apellidos = "";
            this.edad = 18;
        }

        public Persona(string nombre, string apellidos, int edad)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
