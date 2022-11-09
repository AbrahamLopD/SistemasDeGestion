using _08_Ejercicio_Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Ejercicio_DAL
{
    public class ListadoMisionesDAL
    {
        #region Atributos
        private static ObservableCollection<Mision> listadoPersonas = new ObservableCollection<Mision>();
        #endregion

        #region Métodos
        /// <summary>
        /// Función que devuelve un listado de misiones de La Nueva República
        /// Precondición: La clase Mision debe existir
        /// Postcondición: ninguna
        /// </summary>
        /// <returns></returns>
        public static ObservableCollection<Mision> GetListadoMisiones()
        {
            ObservableCollection<Mision> listadoMisiones = new ObservableCollection<Mision>();

            listadoMisiones.Add(new Mision(1, "Rescate de Baby Yoda", "Debes hacerte con Grogu y llevárselo a Luke SkyWalker para su entrenamiento.", 5000));
            listadoMisiones.Add(new Mision(2, "Recuperar armadura Beskar", "La armadura de Beskar ha sido robada. Debes encontrarla. El Beskar fue utilizado en gran medida por los mandalorianos como parte de su iniciativa colectiva para el avance tecnológico. Se vieron obligados durante muchos años a enfrentarse a los Jedi en luchas de poder, pero no pudieron explicar cómo los Jedi usaron la Fuerza para frustrarlos. El Beskar ayudó a la causa, e incluso a defenderse de un golpe indirecto de un sable de luz.", 2000));
            listadoMisiones.Add(new Mision(3, "Planeta Sorgon", "Debes llevar a un niño de vuelta a su planeta natal “Sorgon”.", 500));
            listadoMisiones.Add(new Mision(4, "Renacuajos", "Debes llevar a una Dama Rana y sus huevos de Tatooine a la luna del estuario Trask, donde su esposo fertilizará los huevos.", 500));

            return listadoMisiones;
        }
        #endregion
    }
}
