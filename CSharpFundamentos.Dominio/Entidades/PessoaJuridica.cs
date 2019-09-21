using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentos.Dominio.Entidades
{
    public class PessoaJuridica : Pessoa
    {
        #region Properties
        public string CNPJ { get; set; }
        #endregion
    }
}
