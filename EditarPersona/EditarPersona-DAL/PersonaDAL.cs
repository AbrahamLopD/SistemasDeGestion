using EditarPersona_Entidades;

namespace EditarPersona_DAL
{
    public class PersonaDAL
    {
        /// <summary>
        /// Accedemos a la base de datos y devolvemos una persona que corresponda con el id dado
        /// Precondición: tener base de datos conectada, la id aportada existe en la base de datos
        /// Postcondición: La persona nunca estará vacía
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Persona</returns>
        public Persona GetPersonaById(int id)
        {
            return new Persona();
        }

        /// <summary>
        /// Inserta o actualiza una persona nueva en la base de datos y devuelve el número de filas afectadas
        /// Precondiciones: la base de datos debe estar accesible
        /// Postcondición: El número de filas es mayor o igual que cero
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public int AddPersona(Persona persona)
        {
            int numFilasAfectadas = 0;
            //  Código que inserta una nueva persona en la bbdd
            return numFilasAfectadas;
        }
    }
}
