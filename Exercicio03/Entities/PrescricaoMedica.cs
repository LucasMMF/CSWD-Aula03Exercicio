using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.Entities
{
    public class PrescricaoMedica
    {
        // Source: https://learn.microsoft.com/en-us/ef/core/modeling/relationships/many-to-many
        #region Properties

        public Guid AtendimentoMedicoId { get; set; }
        public Guid MedicamentoId { get; set; }

        #endregion

        #region Associations

        public AtendimentoMedico AtendimentoMedico { get; set; } = null!;
        public Medicamento Medicamento { get; set; } = null!;

        #endregion
    }
}
