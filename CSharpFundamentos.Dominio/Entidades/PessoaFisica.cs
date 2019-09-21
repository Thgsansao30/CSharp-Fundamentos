using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentos.Dominio.Entidades
{
    public class PessoaFisica : Pessoa
    {
        #region Properties
        public string CPF { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        #endregion
    }
}
