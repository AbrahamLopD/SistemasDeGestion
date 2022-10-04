using System;
using System.Reflection;

namespace _05_HolaMundo_Entidades
{
    /// <summary>
    /// Esta clase contiene los atributos y métodos que hacen el objeto Persona
    /// </summary>
    /// <param name="nombre">Nombre de la persona</param>
    public class clsPersona
    {

        #region atributos
        string nombre;
        #endregion

        #region Constructores
        public clsPersona()
        {
            this.Nombre = "";
        }

        public clsPersona(string nombre)
        {
            this.Nombre = nombre;
        }
        #endregion

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        #endregion
    }
}
