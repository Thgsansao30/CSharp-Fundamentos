using CSharpFundamentos.Dominio.Entidades;
using CSharpFundamentos.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentos.Dados.Repositorio
{
    public class RepositorioBase<T> : IRepositorio<T>  where T : EntidadeBase 
    {
        public void Alterar(T item)
        {
            using (var contexto = new Contexto.Contexto())
            {
                contexto.Entry<T>(item).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            using (var contexto = new Contexto.Contexto())
            {
                contexto.Set<T>().Remove( contexto.Set<T>().Find(id) );
                contexto.SaveChanges();
            }
        }


        public void Inserir(T item)
        {
            using (var contexto = new Contexto.Contexto())
            {
                contexto.Set<T>().Add(item);
                contexto.SaveChanges();
            }
        }

        public T ListarPorId(int id)
        {
            T t;
            using (var contexto = new Contexto.Contexto())
            {
                t = contexto.Set<T>().SingleOrDefault(e => e.Id == id);
            }
            return t;
        }

        public List<T> ListaTodos()
        {
            List<T> lista = new List<T>();
            using (var contexto = new Contexto.Contexto())
            {
                lista = contexto.Set<T>().ToList();
            }
            return lista;
        }
    }
}
