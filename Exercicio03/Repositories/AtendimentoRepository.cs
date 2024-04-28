using Exercicio03.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.Repositories
{
    public abstract class AtendimentoRepository
    {
        #region Abstract methods

        public abstract void ExportData(AtendimentoMedico atendimentoMedico);

        #endregion
    }
}
