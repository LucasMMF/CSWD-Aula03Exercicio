using Exercicio03.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercicio03.Repositories
{
    public class AtendimentoRepositoryXML : AtendimentoRepository
    {
        public override void ExportData(AtendimentoMedico atendimentoMedico)
        {
            #region Defining the name and location of a file

            var path = "D:\\temp\\csharp\\webdeveloper\\atendimentoMedico.xml";

            #endregion

            #region Persisting the object state in a serialized file

            using (StreamWriter file = File.CreateText(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AtendimentoMedico));
                serializer.Serialize(file, atendimentoMedico);
            }

            #endregion
        }
    }
}
