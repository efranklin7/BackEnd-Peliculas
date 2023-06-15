namespace PeliculasAPI.Model.Repositorio
{
    public class RepositorioEnMemoria :IRepositorio
    {
        public List<Genero> generos;
        public RepositorioEnMemoria()
        {
            generos = new List<Genero>() 
            {
                    new Genero() { Id=1,Nombre="Accion"},
                    new Genero() { Id=2,Nombre="Terror"}       
            };
                    
        }
        public List<Genero> obtenerGeneros()
        {
            return generos;
        }
        public Genero obtenerGenerosId(int id)
        {
            var genero= generos.FirstOrDefault(x=>x.Id==id);
            return genero;
        }
    }
}
