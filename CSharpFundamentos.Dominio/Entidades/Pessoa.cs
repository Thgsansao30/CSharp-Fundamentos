using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentos.Dominio.Entidades
{
    public abstract class Pessoa : EntidadeBase
    {
        #region Propriedades
        public string NomeCompleto { get; set; }
        public DateTime Nascimento { get; set; }
        #endregion
    }
}
