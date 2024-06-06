using FestasInfantis.WinApp.Compartilhado;
using System.Drawing;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class Item : EntidadeBase
    {
        public string Nome { get; set; }
        public string Tema { get; set; }
        public string Item { get; set; }
        public string Quantidade { get; set; }
        public string valorUnitario { get; set; }
      //public Aluguel Aluguel { get; set; }

        public Item(string nome,string tema, string item, string quantidade, string valorunitario)
        {
            Nome = Nome;
            Tema = Tema;
            Item = Item;
            Quantidade = Quantidade;
            valorunitario = valorunitario;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Item novoCliente = (Item) novoRegistro;

            Nome = novoCliente.Nome;
            Tema = novoCliente.Tema;
            Item = novoCliente.Item;
            Quantidade = novoCliente.Quantidade;
            ValorUnitario = novoCliente.ValorUnitario;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo nome deve ser preenchido");

            if (string.IsNullOrEmpty(Tema.Trim()))
                erros.Add("O campo Tema deve ser preenchido");
            
            if (string.IsNullOrEmpty(Item.Trim()))
                erros.Add("O campo item deve ser preenchido");

            if (string.IsNullOrEmpty(Quantidade.Trim()))
                erros.Add("O campo quantidade deve ser preenchido");

            if (string.IsNullOrEmpty(ValorUnitario.Trim()))
                erros.Add("O campo valor unitário deve ser preenchido");

             return erros;
        }
    }
}