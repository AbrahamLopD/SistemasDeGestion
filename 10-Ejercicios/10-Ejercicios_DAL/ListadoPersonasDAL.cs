using _10_Ejercicios_Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Ejercicios_DAL
{
    public static class ListadoPersonasDAL
    {
        #region Atributos
        private static List<Persona> listadoPersonas = new List<Persona>();
        #endregion

        static ListadoPersonasDAL()
        {
            listadoPersonas.Add(new Persona("Jose Miguel", "Ferreira", "654321978", "Calle una, 34", "https://kiokids.net/3910-thickbox_default/banera-rosa-evolutiva-para-bebe.jpg", DateTime.Now, 1));
            listadoPersonas.Add(new Persona("Enrique", "Hurtado", "654321978", "Calle una, 34", "https://kiokids.net/3910-thickbox_default/banera-rosa-evolutiva-para-bebe.jpg", DateTime.Now, 1));
            listadoPersonas.Add(new Persona("Raúl", "Benavides", "654321978", "Calle una, 34", "https://kiokids.net/3910-thickbox_default/banera-rosa-evolutiva-para-bebe.jpg", DateTime.Now, 1));
            listadoPersonas.Add(new Persona("Jorge", "Dayoub", "654321978", "Calle una, 34", "https://kiokids.net/3910-thickbox_default/banera-rosa-evolutiva-para-bebe.jpg", DateTime.Now, 1));
            listadoPersonas.Add(new Persona("Celia", "Martín-Fontecha", "654321978", "Calle una, 34", "https://kiokids.net/3910-thickbox_default/banera-rosa-evolutiva-para-bebe.jpg", DateTime.Now, 1));
            listadoPersonas.Add(new Persona("Ana", "Pereira", "654321978", "Calle una, 34", "https://kiokids.net/3910-thickbox_default/banera-rosa-evolutiva-para-bebe.jpg", DateTime.Now, 1));
            listadoPersonas.Add(new Persona("Abraham", "López", "654321978", "Calle una, 34", "https://kiokids.net/3910-thickbox_default/banera-rosa-evolutiva-para-bebe.jpg", DateTime.Now, 1));
            listadoPersonas.Add(new Persona("Alonso", "Pérez", "654321978", "Calle una, 34", "https://kiokids.net/3910-thickbox_default/banera-rosa-evolutiva-para-bebe.jpg", DateTime.Now, 1));
            listadoPersonas.Add(new Persona("Gloria", "Reina", "654321978", "Calle una, 34", "https://kiokids.net/3910-thickbox_default/banera-rosa-evolutiva-para-bebe.jpg", DateTime.Now, 1));
            listadoPersonas.Add(new Persona("Carla", "Manzano", "654321978", "Calle una, 34", "https://kiokids.net/3910-thickbox_default/banera-rosa-evolutiva-para-bebe.jpg", DateTime.Now, 1));
        }

        #region Propiedad
        public static List<Persona> ListadoPersonas { set => listadoPersonas = value; }
        #endregion

        #region Métodos
        /// <summary>
        /// Función que accede a la base de datos y devuelve un listado de personas
        /// Precondición: La clase Persona debe existir
        /// Postcondición: ninguna
        /// </summary>
        /// <returns></returns>
        public static List<Persona> ListarPersonas()
        {

            SqlConnection miConexion = new SqlConnection();

            List<Persona> listadoPersonas = new List<Persona>();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            Persona oPersona;

            miConexion.ConnectionString = "server=rlindes.database.windows.net;database=rubenDB;uid=fernando;pwd=Mandaloriano69;";
            try
            {

                miConexion.Open();

                miComando.CommandText = "SELECT * FROM personas";

                miComando.Connection = miConexion;

                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {

                        oPersona = new Persona();

                        oPersona.Id = (int)miLector["ID"];

                        oPersona.Nombre = (string)miLector["Nombre"];

                        oPersona.Apellidos = (string)miLector["Apellidos"];

                        oPersona.Telefono = (string)miLector["Telefono"];
                        oPersona.Direccion = (string)miLector["Direccion"];
                        oPersona.Foto = (string)miLector["Foto"];

                        //Si sospechamos que el campo puede ser Null en la BBDD
                        if (miLector["FechaNacimiento"] != System.DBNull.Value)
                        {
                            oPersona.FechaNacimiento = (DateTime)miLector["FechaNacimiento"];
                        }

                        oPersona.IdDepartamento = (int)miLector["IDDepartamento"];

                        listadoPersonas.Add(oPersona);

                    }

                }
                miLector.Close();

            }
            catch (Exception e)
            {
                // Poner página de error
            }
            finally
            {
                miConexion.Close();
            }

            return listadoPersonas;
        }

        /// <summary>
        /// Función que devuelve un listado de personas filtrado por una búsqueda hecha
        /// Precondición: La clase Persona debe existir
        /// Postcondición: ninguna
        /// </summary>
        /// <returns></returns>
        public static List<Persona> ListarPersonasBySearch(string search)
        {
            List<Persona> listaPersonas = new List<Persona>();

            foreach (Persona persona in listadoPersonas)
            {
                if(persona.Nombre.ToLower().Contains(search) || persona.Apellidos.ToLower().Contains(search))
                {
                    listaPersonas.Add(persona);
                }
            }

            return listaPersonas;
        }
        #endregion
    }
}
