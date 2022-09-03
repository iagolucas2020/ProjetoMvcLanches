using LanchesMac.Models;

namespace LanchesMac.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public IEnumerable<Categoria> Categorias { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
