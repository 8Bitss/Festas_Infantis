using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class Tema : EntidadeBase
    {
        public string Nome { get; set; }
        public decimal ValorTotal { get; set; }
      //public Aluguel Aluguel { get; set; }

        public Tema(string nome, decimal valorTotal)
        {
            Nome = nome;
            ValorTotal = valorTotal;
          //Aluguel = Aluguel;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Tema novoCliente = (Tema) novoRegistro;

            Nome = novoCliente.Nome;
            //Itens = novoCliente.Itens;
            //Aluguel = novoCliente.Aluguel;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo nome deve ser preenchido");
            
            if (ValorTotal == null)
                erros.Add("O campo do valor deve ser preenchido");

            //if (string.IsNullOrEmpty(Itens.Trim()))
            //    erros.Add("O campo item deve ser preenchido");
           
            //if (string.IsNullOrEmpty(Aluguel.Trim()))
            //    erros.Add("O campo aluguel deve ser preenchido");

            return erros;
        }
    }
}