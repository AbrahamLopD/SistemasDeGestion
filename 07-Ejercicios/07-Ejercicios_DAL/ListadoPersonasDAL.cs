using _07_Ejercicios_Entidades;

namespace _07_Ejercicios_DAL
{
    public static class ListadoPersonasDAL
    {
        /// <summary>
        /// Función que devuelve un listado de personas que nadie conoce...
        /// Precondición: La clase Persona debe existir
        /// Postcondición: ninguna
        /// </summary>
        /// <returns></returns>
        public static List<Persona> ListarPersonas()
        {
            List<Persona> listaPersonas = new List<Persona>();

            listaPersonas.Add(new Persona(0, 3, "Abraham", "López"));
            listaPersonas.Add(new Persona(1, 1, "Jose Miguel", "Ferreira"));
            listaPersonas.Add(new Persona(2, 3, "Enrique", "Hurtado"));
            listaPersonas.Add(new Persona(3, 1, "Raúl", "Benavides"));
            listaPersonas.Add(new Persona(4, 2, "Jorge", "Dayoub"));

            return listaPersonas;
        }
    }
}
