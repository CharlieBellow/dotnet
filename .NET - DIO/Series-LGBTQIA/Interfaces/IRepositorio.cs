using System.Collections.Generic;

namespace Series_LGBTQIA.Interfaces
{
    public interface IRepositorio<Serie>
    {
        List<Serie> Lista();
        Serie RetornaPorId(int id);
        void Insere(Serie entidade);
        void Exclui(int id);
        void Atualiza(int id, Serie entidade);
        int ProximoId();
    }
}