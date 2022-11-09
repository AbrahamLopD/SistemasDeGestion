using _08_Ejercicio_BL;
using _08_Ejercicio_Entidades;
using System.Collections.ObjectModel;

namespace _08_Ejercicio_MVC.Models.ViewModels
{
    public class EscogerMision
    {
        #region Atributos
        ObservableCollection<Mision> listadoMisiones;
        Mision mision;
        #endregion

        #region Constructor
        public EscogerMision()
        {
            this.listadoMisiones = ListadoMisionesBL.GetListadoMisiones();
            this.mision = new Mision();
        }
        #endregion


        #region Propiedades
        public ObservableCollection<Mision> ListadoMisiones { get => listadoMisiones; set => listadoMisiones = value; }
        public Mision Mision { get => mision; set => mision = value; }
        #endregion
    }
}
