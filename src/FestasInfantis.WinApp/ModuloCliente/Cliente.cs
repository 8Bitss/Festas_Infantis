using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class Cliente : EntidadeBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }

        //public Aluguel Aluguel { get; set; }

        public Cliente(string nome, string telefone, string cpf)
        {
            Nome = nome;
            Telefone = telefone;
            Cpf = cpf;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Cliente novoCliente = (Cliente) novoRegistro;

            Nome = novoCliente.Nome;
            Telefone = novoCliente.Telefone;
            Cpf = novoCliente.Cpf;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo nome deve ser preenchido");
            
            if (string.IsNullOrEmpty(Telefone.Trim()))
                erros.Add("O campo telefone deve ser preenchido");

            if (string.IsNullOrEmpty(Cpf.Trim()))
                erros.Add("O campo cpf deve ser preenchido");

            return erros;
        }
    }
}
