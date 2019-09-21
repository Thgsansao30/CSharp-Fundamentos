using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentos.Dominio.Entidades
{
    public abstract class EntidadeBase
    {
        #region Propriedades
        [Key]
        public int Id { get; set; }
        #endregion
    }
}
