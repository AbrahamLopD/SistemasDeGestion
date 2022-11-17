using _08_Ejercicio_DAL;
using _08_Ejercicio_Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Ejercicio_BL
{
    public class ListadoMisionesBL
    {
        #region Atributos
        private static ObservableCollection<Mision> listadoPersonas = new ObservableCollection<Mision>();
        #endregion

        #region Métodos
        /// <summary>
        /// Función que llama y devuelve la función GetListadoMisiones() de la capa DAL.
        /// Comprueba si es domingo y solo lo devuelve en caso contrario
        /// Precondición: La clase Mision debe existir
        /// Postcondición: ninguna
        /// </summary>
        /// <returns></returns>
        public static ObservableCollection<Mision> GetListadoMisiones()
        {
            ObservableCollection<Mision> listadoMisiones = new ObservableCollection<Mision>();

            if(DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                listadoMisiones = null;
            }
            else
            {
                listadoMisiones = ListadoMisionesDAL.GetListadoMisiones();
            }
            
            return listadoMisiones;
        }
        #endregion
    }
}
