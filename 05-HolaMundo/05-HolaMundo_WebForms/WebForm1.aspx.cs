using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _05_HolaMundo_Entidades;

namespace _05_HolaMundo_WebForms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        /// <summary>
        /// comentarios: Evento saludar que mostrará un saludo al nombre que se introduzca
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void onBtnSaludoClick(object sender, EventArgs e)
        {
            string endResult;
            clsPersona persona;

            if (inputName.Text.Length > 0)
            {
                persona = new clsPersona(inputName.Text);

                endResult = $"Hola {persona.Nombre}";
                lblSaludo.Text = endResult;

                lblError.Visible = false;

                lblSaludo.Visible = true;

            }
            else
            {
                lblError.Text = "Debes insertar un nombre";
                lblError.Visible = true;

                lblSaludo.Visible = false;

            }
        }
    }
}