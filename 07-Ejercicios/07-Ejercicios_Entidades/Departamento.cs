namespace _07_Ejercicios_Entidades
{
    public class Departamento
    {
        #region Atributos
        private int id;
        private string nombre;
        #endregion

        #region Constructor
        public Departamento(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        #endregion

        #region getters y setters
        public int Id { get => id; }
        public string Nombre { get => nombre; set => nombre = value; }
        #endregion
    }
}
