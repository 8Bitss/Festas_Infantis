using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class Tema : EntidadeBase
    {
        public string Nome { get; set; }
        public string Valor { get; set; }
     // public string Itens { get; set; }
      //public Aluguel Aluguel { get; set; }

        public Tema(string nome, string valor, string itens)
        {
            Nome = Nome;
            Valor = Valor;
            //Itens = Itens;
            //Aluguel = Aluguel;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Tema novoCliente = (Tema) novoRegistro;

            Nome = novoCliente.Nome;
            Valor = novoCliente.Valor;
            //Itens = novoCliente.Itens;
            //Aluguel = novoCliente.Aluguel;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo nome deve ser preenchido");
            
            if (string.IsNullOrEmpty(Valor.Trim()))
                erros.Add("O campo do valor deve ser preenchido");

            //if (string.IsNullOrEmpty(Itens.Trim()))
            //    erros.Add("O campo item deve ser preenchido");
           
            //if (string.IsNullOrEmpty(Aluguel.Trim()))
            //    erros.Add("O campo aluguel deve ser preenchido");

            return erros;
        }
    }
}