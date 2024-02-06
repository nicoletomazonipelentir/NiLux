using NiLux.Context;
using NiLux.Models;
using NiLux.Repositorios.Interfaces;

namespace NiLux.Repositorios
{
    public class CategoriaRepositorio: ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias =>_context.Categorias;
    }

}
