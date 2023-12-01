using AplicacaoLanches.Models;

namespace AplicacaoLanches.Repository.InterfacesRepository
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
