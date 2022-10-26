using _07_Ejercicios_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Ejercicios_DAL
{
    public class ManejadoraPesonaDAL
    {
        /// <summary>
        /// Función que recibe una id y devuelve la persona con dicho id
        /// Precondición: El id dado debe ser válido
        /// Postcondición: La salida de la persona será nula si la persona no existe
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Persona GetPersonaById(int id)
        {
            List<Persona> listaPersonas = ListadoPersonasDAL.ListarPersonas();

            return listaPersonas.Find(persona => persona.Id == id);
        }

        /// <summary>
        /// Función que recibe una persona y la guarda
        /// Precondición: La persona dada debe tener todos sus atributos a excepción del id que no se tendrá en cuenta
        /// Postcondición: ninguna
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static void AddPersona(Persona persona)
        {
            //  insertar los atributos de la persona en una nueva persona de la lista
        }
    }
}
