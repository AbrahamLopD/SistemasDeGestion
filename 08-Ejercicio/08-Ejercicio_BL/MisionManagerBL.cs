using _08_Ejercicio_DAL;
using _08_Ejercicio_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Ejercicio_BL
{
    /// <summary>
    /// Función que llama a GetMisionById de la capa DAL
    /// Precondición: El id dado debe ser válido
    /// Postcondición: La salida de la misión será nula si la persona no existe
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Devuelve una persona, si la persona no existe, devolverá nulo</returns>
    public class MisionManagerBL
    {
        public static Mision GetMisionById(int id)
        {
            return MisionManagerDAL.GetMisionById(id);
        }
    }
}
