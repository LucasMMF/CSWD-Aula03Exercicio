using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.Entities
{
    public class AtendimentoMedico
    {
        #region Properties

        public Guid Id { get; set; }
        public string DataHora { get; set; }
        public decimal Valor { get; set; }

        #endregion

        #region Associations

        public List<PrescricaoMedica> PrescricoesMedicas { get; set; }

        #endregion
    }
}
