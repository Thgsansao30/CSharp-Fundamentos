using CSharpFundamentos.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentos.Dados.Contexto
{
    public class Contexto : DbContext
    {
        #region Propriedades
            public DbSet<Usuario> Usuario { get; set; }
            public DbSet<PessoaFisica> PessoaFisica { get; set; }
            public DbSet<PessoaJuridica> PessoaJuridica { get; set; }
        #endregion
        #region Metodos
        public Contexto() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maykon.granemann\Source\Repos\CSharpFundamentos\CSharpFundamentos.Dados\LocalDB\BancoDeDados.mdf;Integrated Security=True")
            {

            }
        #endregion
    }
}
