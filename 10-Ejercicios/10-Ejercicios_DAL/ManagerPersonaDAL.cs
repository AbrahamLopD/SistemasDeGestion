using _10_Ejercicios_Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Ejercicios_DAL
{
    public class ManagerPersonaDAL
    {
        /// <summary>
        /// Función que recibe una id y devuelve la persona con dicho id
        /// Precondición: El id dado debe ser válido
        /// Postcondición: La salida de la persona será nula si la persona no existe
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Devuelve una persona, si la persona no existe, devolverá nulo</returns>
        public static Persona GetPersonaById(int id)
        {
            List<Persona> listaPersonas = ListadoPersonasDAL.ListarPersonas();

            return listaPersonas.Find(persona => persona.Id == id);
        }

        /// <summary>
        /// Función que recibe una persona y la borra
        /// Precondición: La persona dada debe ser válida
        /// Postcondición: ninguna
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Devuelve el número de columnas afectadas</returns>
        public static int DeletePersonaById(int id)
        {
            List<Persona> listaPersonas = ListadoPersonasDAL.ListarPersonas();

            Persona personaABorrar = listaPersonas.Find(persona => persona.Id == id);

            if(personaABorrar != null)
            {
                listaPersonas.Remove(personaABorrar);
                return 1;
            }

            return 0;
        }
    }
}
