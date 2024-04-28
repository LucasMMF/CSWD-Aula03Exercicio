using Exercicio03.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.Repositories
{
    public class AtendimentoRepositoryJSON : AtendimentoRepository
    {
        public override void ExportData(AtendimentoMedico atendimentoMedico)
        {
            #region Defining the name and location of a file

            var path = "D:\\temp\\csharp\\webdeveloper\\atendimentoMedico.json";

            #endregion

            #region Persisting the object state in a serialized file

            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, atendimentoMedico);
            }

            #endregion
        }
    }
}
