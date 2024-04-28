using Exercicio03.Controllers;

namespace Exercicio03
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var atendimentoMedicoController = new AtendimentoMedicoController();

            atendimentoMedicoController.CadastrarAtendimento();

            Console.ReadKey();
        }

    }
}