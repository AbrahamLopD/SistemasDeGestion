using _07_Ejercicios_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Ejercicios_DAL
{
    public class DepartamentoDAL
    {
        /// <summary>
        /// Función que recibe una id y devuelve el departamento con dicho id
        /// Precondición: El id dado debe ser válido
        /// Postcondición: La salida del departamento será nula si la persona no existe
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Departamento GetPersonaById(int id)
        {
            List<Departamento> listaDepartamentos = ListaDepartamentosDAL.ListarDepartamentos();

            return listaDepartamentos.Find(departamento => departamento.Id == id);
        }
    }
}
