using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.Entities
{
    public class Paciente
    {
        #region Properties

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        #endregion

        #region Associations

        public List<AtendimentoMedico> AtendimentosMedicos;

        #endregion
    }
}
