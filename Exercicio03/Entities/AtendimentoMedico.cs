using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.Entities
{
    public class AtendimentoMedico
    {
        // Source: https://learn.microsoft.com/en-us/ef/core/modeling/relationships/many-to-many
        #region Properties

        public Guid Id { get; set; }
        public string DataHora { get; set; }
        public decimal Valor { get; set; }
        public Guid MedicoId { get; set; }
        public Guid PacienteId { get; set; }

        #endregion

        #region Associations

        public Medico Medico { get; set; } = null!;
        public Paciente Paciente { get; set; } = null!;
        public List<PrescricaoMedica> PrescricoesMedicas { get; set; } = [];

        #endregion
    }
}
