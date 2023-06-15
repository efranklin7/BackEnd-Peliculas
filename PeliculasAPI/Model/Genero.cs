using PeliculasAPI.Validations;

namespace PeliculasAPI.Model
{
    public class Genero
    {
        public int Id { get; set; }
        [PrimerLetraMayus]
        public string Nombre { get; set; }
    }
}
