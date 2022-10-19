using EditarPersona_Entidades;
using EditarPersona_DAL;

namespace EditarPersona_UI_MVC.Models.ViewModels
{
    public class PersonaConListadoDepartamento
    {
        Persona persona;
        List<Departamento> listadoDepartamentos;

        public Persona Persona { get => persona; set => persona = value; }
        public List<Departamento> ListadoDepartamentos { get => listadoDepartamentos; }

        PersonaConListadoDepartamento()
        {
            listadoDepartamentos = new List<Departamento>();
            persona = new Persona();
        }
    }
}
