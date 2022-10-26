using _07_Ejercicios_DAL;
using _07_Ejercicios_Entidades;

namespace _07_Ejercicios_MVC.Models.ViewModels
{
    public class EditorPersonaVM
    {
        #region Atributos
        private Persona persona;
        private List<Departamento> listadoDepartamentos;
        #endregion

        #region Contructores
        public EditorPersonaVM()
        {
            this.persona = ManejadoraPesonaDAL.GetPersonaById(2);
            this.listadoDepartamentos = ListaDepartamentosDAL.ListarDepartamentos();
        }
        #endregion

        #region Propiedades
        public Persona Persona { get => persona; set => persona = value; }
        public List<Departamento> ListadoDepartamentos { get => listadoDepartamentos; }
        #endregion
    }
}
