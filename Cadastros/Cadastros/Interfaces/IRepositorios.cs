using System.Collections.Generic;
namespace Cadastros.Interfaces
{
    public interface IRepositorios<T>
    {
        List<T> Lista();

        void Inserir(T objeto);

        void Excluir(int i);

        void Atualizar(int i, T objeto);

        int Tamanho();
    }
}