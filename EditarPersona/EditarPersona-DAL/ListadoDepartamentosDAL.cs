using EditarPersona_Entidades;

namespace EditarPersona_DAL
{
    public class ListadoDepartamentosDAL
    {
        /// <summary>
        /// Accedemos a la base de datos y devolvemos un listado commpleto de los departamentos
        /// Precondición: tener base de datos conectada
        /// Postcondición: ninguna
        /// </summary>
        /// <returns>LIST<Deapartamento></dEPARTAMENTO></returns>
        public List<Departamento> GetListadoDepartamentos()
        {
            List<Departamento> listaDepartamentos = new List<Departamento>();
            return listaDepartamentos;
        }
    }
}
