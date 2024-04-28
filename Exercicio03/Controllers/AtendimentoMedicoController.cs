using Exercicio03.Entities;
using Exercicio03.Repositories;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.Controllers
{
    public class AtendimentoMedicoController
    {
        CultureInfo culture = new CultureInfo("pt-BR");

        public void CadastrarAtendimento()
        {
            try
            {
                Console.WriteLine("\n *** CADASTRO DE ATENDIMENTOS *** \n");

                #region Captura os dados específicos do atendimento médico

                var atendimentoMedico = new AtendimentoMedico();
                atendimentoMedico.Id = Guid.NewGuid();

                Console.Write("INFORME A DATA/HORA DO ATENDIMENTO...........: ");
                atendimentoMedico.DataHora = Console.ReadLine();

                Console.Write("INFORME O VALOR DO ATENDIMENTO...............: ");
                atendimentoMedico.Valor = decimal.Parse(Console.ReadLine(), culture);

                #endregion

                #region Captura os dados específicos do paciente vinculado ao atendimento

                Console.WriteLine("\n *** PACIENTE DO ATENDIMENTO *** \n");
                atendimentoMedico.PacienteId = Guid.NewGuid();

                atendimentoMedico.Paciente = new Paciente();
                atendimentoMedico.Paciente.Id = atendimentoMedico.PacienteId;

                Console.Write("INFORME O NOME DO PACIENTE...................: ");
                atendimentoMedico.Paciente.Nome = Console.ReadLine();

                Console.Write("INFORME SUA DATA DE NASCIMENTO...............: ");
                atendimentoMedico.Paciente.DataNascimento = DateTime.Parse(Console.ReadLine(), culture);

                #endregion

                #region Captura os dados específicos do médico vinculado ao atendimento

                Console.WriteLine("\n *** MÉDICO DO ATENDIMENTO *** \n");
                atendimentoMedico.MedicoId = Guid.NewGuid();

                atendimentoMedico.Medico = new Medico();
                atendimentoMedico.Medico.Id = atendimentoMedico.MedicoId;

                Console.Write("INFORME O NOME DO MÉDICO.....................: ");
                atendimentoMedico.Medico.Nome = Console.ReadLine();

                Console.Write("INFORME O CRM DO MÉDICO......................: ");
                atendimentoMedico.Medico.CRM = Console.ReadLine();

                #endregion

                #region Captura os dados dos medicamentos e finaliza vinculo entre os dados

                Console.WriteLine("\n *** PRESCRIÇÃO *** \n");

                var prescricoesMedicas = new List<PrescricaoMedica>();

                Console.Write("INFORME QUANTOS MEDICAMENTOS SERÃO PRESCRITOS: ");
                var quantMedicamentos = int.Parse(Console.ReadLine());

                for (int i = quantMedicamentos; i > 0; i--)
                {
                    var prescricaoMedica = new PrescricaoMedica();
                    prescricaoMedica.AtendimentoMedicoId = atendimentoMedico.Id;
                    prescricaoMedica.MedicamentoId = Guid.NewGuid();

                    var medicamento = new Medicamento();
                    medicamento.Id = prescricaoMedica.MedicamentoId;

                    Console.Write("INFORME O NOME DO MEDICAMENTO................: ");
                    medicamento.Nome = Console.ReadLine();

                    Console.Write("INFORME A DESCRIÇÃO DO MEDICAMENTO...........: ");
                    medicamento.Descricao = Console.ReadLine();

                    prescricaoMedica.Medicamento = medicamento;

                    prescricoesMedicas.Add(prescricaoMedica);
                    if (i > 0) Console.WriteLine($"\nFaltam adicionar: {i-1} medicamentos.\n");
                }

                atendimentoMedico.PrescricoesMedicas = prescricoesMedicas;

                #endregion

                #region Envia para serialização e persistência dos dados em XML / JSON

                Console.Write("\nINFORME (1)JSON ou (2)XML: ");
                var opcao = int.Parse(Console.ReadLine());

                AtendimentoRepository atendimentoRepository = null!;

                switch(opcao)
                {
                    case 1:
                        atendimentoRepository = new AtendimentoRepositoryJSON();
                        break;

                    case 2:
                        atendimentoRepository = new AtendimentoRepositoryXML();
                        break;

                    default:
                        Console.WriteLine("\nFORMATO INVÁLIDO!");
                        break;
                }

                if (atendimentoRepository != null)
                {
                    atendimentoRepository.ExportData(atendimentoMedico);

                    Console.WriteLine("\nDADOS GRAVADOS COM SUCESSO!");
                }

                #endregion

            }
            catch (Exception e)
            {
                Console.WriteLine($"Falha ao cadastrar atendimento: {e.Message}");
            }
        }
    }
}
