using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.Entities
{
    public class Medicamento
    {
        #region Properties

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        #endregion

        #region Associations

        public List<PrescricaoMedica> PrescricoesMedicas { get; set; } = [];

        #endregion
    }
}
