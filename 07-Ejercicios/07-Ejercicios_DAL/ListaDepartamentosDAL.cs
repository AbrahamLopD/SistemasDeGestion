using _07_Ejercicios_Entidades;

namespace _07_Ejercicios_DAL
{
    public class ListaDepartamentosDAL
    {
        /// <summary>
        /// Función que devuelve un listado de departamentos
        /// Precondición: La clase Departamento debe existir
        /// Postcondición: ninguna
        /// </summary>
        /// <returns></returns>
        public static List<Departamento> ListarDepartamentos()
        {
            List<Departamento> listaDepartamentos = new List<Departamento>();

            listaDepartamentos.Add(new Departamento(0, "Gestión de suministros"));
            listaDepartamentos.Add(new Departamento(1, "Marketing y Ventas"));
            listaDepartamentos.Add(new Departamento(2, "Finanzas y contabilidad"));
            listaDepartamentos.Add(new Departamento(3, "Recursos Humanos"));

            return listaDepartamentos;
        }
    }
}
