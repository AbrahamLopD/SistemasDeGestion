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
        public DelegateCommand mostrarDetallesCommand;
        #endregion

        #region Constructor
        public EscogerMision()
        {
            this.listadoMisiones = ListadoMisionesBL.GetListadoMisiones();
            this.mision = null; 
            this.visibilidadDescripcion = false;
        }
        #endregion


        #region Propiedades
        public ObservableCollection<Mision> ListadoMisiones { get => listadoMisiones; set => listadoMisiones = value; }
        public Mision Mision { get => mision; set
            {
                if(mision == value) return;

                mision = value;
                mostrarDetallesCommand.RaiseCanExecuteChanged();

                if(visibilidadDescripcion)
                {
                    visibilidadDescripcion = false;
                    NotifyPropertyChanged(nameof(VisibilidadDescripcion));
                }
            } 
        }

        public bool VisibilidadDescripcion { get
            {
                return visibilidadDescripcion;
            }
        }
        public DelegateCommand MostrarDetallesCommand { get
            {
                this.mostrarDetallesCommand = new DelegateCommand(MostrarDetallesCommandExecute, MostrarDetallesCommandCanExecute);
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
            visibilidadDescripcion = true;

            NotifyPropertyChanged("VisibilidadDescripcion");
            NotifyPropertyChanged("Mision");
        }

        /// <summary>
        /// Evento que habilita o deshabilida el botón para mostrar los detalles de la misión seleccionada
        /// </summary>
        private bool MostrarDetallesCommandCanExecute()
        {
            bool isAvailable = true;
            if(mision == null) isAvailable = false;

            return isAvailable;
        }
        #endregion
    }
}
