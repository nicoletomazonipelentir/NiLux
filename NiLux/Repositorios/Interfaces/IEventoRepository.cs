using NiLux.Models;

namespace NiLux.Repositorios.Interfaces
{
    public interface IEventoRepository
    {
        IEnumerable<Evento> Eventos { get; }
        IEnumerable<Evento> EventosPreferidos { get; }
        Evento GetEventoByID(int eventoId);
    }
}
