using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Aluguel : EntidadeBase
    {
        public bool Status { get; set; }
        public DateTime DataPagemento { get; set; }

        public decimal PorcentagemEntrada { get; set; }
        public decimal PorcentagemDesconto { get; set; }

        //public Tema Tema { get; set; }
        public Cliente Cliente { get; set; }
        public Festa Festa { get; set; }


        public Aluguel(decimal porcentagemEntrada, decimal porcentagemDesconto, Festa festa)
        {
            PorcentagemEntrada = porcentagemEntrada;
            PorcentagemDesconto = porcentagemDesconto;
            Festa = festa;
        }


        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Aluguel atualizado = (Aluguel) novoRegistro;

            Cliente = atualizado.Cliente;
            PorcentagemEntrada = atualizado.PorcentagemEntrada;
            PorcentagemDesconto = atualizado.PorcentagemDesconto;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            //if (Cliente == null)
            //    erros.Add("O campo \"cliente\" é obrigatório");

            return erros;
        }
    }
}
