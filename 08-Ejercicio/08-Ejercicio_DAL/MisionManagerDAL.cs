using _08_Ejercicio_Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Ejercicio_DAL
{
    public class MisionManagerDAL
    {
        /// <summary>
        /// Función que recibe una id y devuelve la misión con dicho id
        /// Precondición: El id dado debe ser válido
        /// Postcondición: La salida de la misión será nula si la persona no existe
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Devuelve una persona, si la persona no existe, devolverá nulo</returns>
        public static Mision GetMisionById(int id)
        {
            ObservableCollection<Mision> listadoMision = ListadoMisionesDAL.GetListadoMisiones();

            int i = 0;
            while (i < listadoMision.Count)
            {
                if (listadoMision[i].Id == id)
                {
                    return listadoMision[i];
                }
                i++;
            }

            return null;
        }
    }
}
