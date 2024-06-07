using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class Item : EntidadeBase
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }


        public Item(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Item novoItem = (Item) novoRegistro;

            Descricao = novoItem.Descricao;
            Valor = novoItem.Valor;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Descricao.Trim()))
                erros.Add("O campo Descrição deve ser preenchido");

            if (Valor == 0)
                erros.Add("O campo valor unitário deve ser preenchido");

             return erros;
        }
    }
}