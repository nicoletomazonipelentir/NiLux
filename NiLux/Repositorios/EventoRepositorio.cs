using Microsoft.EntityFrameworkCore;
using NiLux.Context;
using NiLux.Models;
using NiLux.Repositorios.Interfaces;

namespace NiLux.Repositorios
{
    public class EventoRepositorio : IEventoRepository
    {
        private readonly AppDbContext _context;

        public EventoRepositorio(AppDbContext contexto)
        {
            _context= contexto;
        }
        public IEnumerable<Evento> Eventos => _context.Eventos.Include(c=> c.Categoria);

        public IEnumerable<Evento> EventosPreferidos => _context.Eventos.Where(l => l.EventoPreferido).Include(c => c.Categoria);

        public Evento GetEventoByID(int eventoId)
        {
            return _context.Eventos.FirstOrDefault(l=>l.EventoId==eventoId);
        }
    }
}
