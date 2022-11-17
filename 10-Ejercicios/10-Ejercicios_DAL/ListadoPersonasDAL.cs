using _10_Ejercicios_Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Ejercicios_DAL
{
    public static class ListadoPersonasDAL
    {
        #region Atributos
        private static List<Persona> listadoPersonas = new List<Persona>();
        #endregion

        static ListadoPersonasDAL()
        {
            listadoPersonas.Add(new Persona("Jose Miguel", "Ferreira", "654321978", "Calle una, 34", "https://kiokids.net/3910-thickbox_default/banera-rosa-evolutiva-para-bebe.jpg", DateTime.Now, 1));
            listadoPersonas.Add(new Persona("Enrique", "Hurtado", "654321978", "Calle una, 34", "https://kiokids.net/3910-thickbox_default/banera-rosa-evolutiva-para-bebe.jpg", DateTime.Now, 1));
            listadoPersonas.Add(new Persona("Raúl", "Benavides", "654321978", "Calle una, 34", "https://kiokids.net/3910-thickbox_default/banera-rosa-evolutiva-para-bebe.jpg", DateTime.Now, 1));
            listadoPersonas.Add(new Persona("Jorge", "Dayoub", "654321978", "Calle una, 34", "https://kiokids.net/3910-thickbox_default/banera-rosa-evolutiva-para-bebe.jpg", DateTime.Now, 1));
            listadoPersonas.Add(new Persona("Celia", "Martín-Fontecha", "654321978", "Calle una, 34", "https://kiokids.net/3910-thickbox_default/banera-rosa-evolutiva-para-bebe.jpg", DateTime.Now, 1));
            listadoPersonas.Add(new Persona("Ana", "Pereira", "654321978", "Calle una, 34", "https://kiokids.net/3910-thickbox_default/banera-rosa-evolutiva-para-bebe.jpg", DateTime.Now, 1));
            listadoPersonas.Add(new Persona("Abraham", "López", "654321978", "Calle una, 34", "https://kiokids.net/3910-thickbox_default/banera-rosa-evolutiva-para-bebe.jpg", DateTime.Now, 1));
            listadoPersonas.Add(new Persona("Alonso", "Pérez", "654321978", "Calle una, 34", "https://kiokids.net/3910-thickbox_default/banera-rosa-evolutiva-para-bebe.jpg", DateTime.Now, 1));
            listadoPersonas.Add(new Persona("Gloria", "Reina", "654321978", "Calle una, 34", "https://kiokids.net/3910-thickbox_default/banera-rosa-evolutiva-para-bebe.jpg", DateTime.Now, 1));
            listadoPersonas.Add(new Persona("Carla", "Manzano", "654321978", "Calle una, 34", "https://kiokids.net/3910-thickbox_default/banera-rosa-evolutiva-para-bebe.jpg", DateTime.Now, 1));
        }

        #region Propiedad
        public static List<Persona> ListadoPersonas { set => listadoPersonas = value; }
        #endregion

        #region Métodos
        /// <summary>
        /// Función que devuelve un listado de personas
        /// Precondición: La clase Persona debe existir
        /// Postcondición: ninguna
        /// </summary>
        /// <returns></returns>
        public static List<Persona> ListarPersonas()
        {
            return listadoPersonas;
        }

        /// <summary>
        /// Función que devuelve un listado de personas filtrado por una búsqueda hecha
        /// Precondición: La clase Persona debe existir
        /// Postcondición: ninguna
        /// </summary>
        /// <returns></returns>
        public static List<Persona> ListarPersonasBySearch(string search)
        {
            List<Persona> listaPersonas = new List<Persona>();

            foreach (Persona persona in listadoPersonas)
            {
                if(persona.Nombre.ToLower().Contains(search) || persona.Apellidos.ToLower().Contains(search))
                {
                    listaPersonas.Add(persona);
                }
            }

            return listaPersonas;
        }
        #endregion
    }
}
