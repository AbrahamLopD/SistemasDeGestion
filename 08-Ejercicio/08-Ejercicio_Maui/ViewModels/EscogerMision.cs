using _08_Ejercicio_BL;
using _08_Ejercicio_Entidades;
using _08_Ejercicio_Maui.ViewModels.Utilities;
using System.Collections.ObjectModel;

namespace _08_Ejercicio_MVC.Models.ViewModels
{
    public class EscogerMision : BaseVM
    {
        #region Atributos
        private ObservableCollection<Mision> listadoMisiones;
        private Mision mision;
        private bool visibilidadDescripcion;
        private DelegateCommand mostrarDetallesCommand;
        #endregion

        #region Constructor
        public EscogerMision()
        {
            this.listadoMisiones = ListadoMisionesBL.GetListadoMisiones();
            this.mision = new Mision(); 
            this.visibilidadDescripcion = false;
        }
        #endregion


        #region Propiedades
        public ObservableCollection<Mision> ListadoMisiones { get => listadoMisiones; set => listadoMisiones = value; }
        public Mision Mision { get => mision; set
            {
                mision = value;
                //visibilidadDescripcion = true;
                //NotifyPropertyChanged("VisibilidadDescripcion");
            } 
        }

        public bool VisibilidadDescripcion { get
            {

                return visibilidadDescripcion;
            }
        }
        public DelegateCommand MostrarDetallesCommand { get
            {
                mostrarDetallesCommand = new DelegateCommand(MostrarDetallesCommandExecute, MostrarDetallesCommandCanExecute);

                return mostrarDetallesCommand;
            }
        }
        #endregion

        #region Commands
        /// <summary>
        /// Evento que muestra los detalles de la misión seleccionada haciendo visible el texto mediante el booleano VisibilidadDescripción
        /// </summary>
        private void MostrarDetallesCommandExecute()
        {
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Evento que muestra los detalles de la misión seleccionada
        /// </summary>
        private bool MostrarDetallesCommandCanExecute()
        {
            //throw new NotImplementedException();
            return true;
        }
        #endregion
    }
}
