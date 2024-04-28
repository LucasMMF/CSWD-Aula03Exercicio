using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.Entities
{
    public class PrescricaoMedica
    {
        #region Associations

        public AtendimentoMedico AtendimentoMedico { get; set; }
        public Medicamento Medicamento { get; set; }

        #endregion
    }
}
