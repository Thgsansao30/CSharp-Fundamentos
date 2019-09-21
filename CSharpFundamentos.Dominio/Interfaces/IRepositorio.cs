using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentos.Dominio.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> ListaTodos();
        T ListarPorId(int id);
        void Inserir(T item);
        void Alterar(T item);
        void Deletar(int id);
    }
}
