namespace PeliculasAPI.Model.Repositorio
{
    public interface IRepositorio
    {
        List<Genero> obtenerGeneros();
        Genero obtenerGenerosId(int id);
    }
}
