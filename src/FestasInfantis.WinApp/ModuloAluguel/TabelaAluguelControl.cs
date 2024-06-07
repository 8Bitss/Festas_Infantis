using FestasInfantis.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TabelaAluguelControl : UserControl
    {
        public TabelaAluguelControl()
        {
            InitializeComponent();


            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Aluguel> alugueis)
        {
            grid.Rows.Clear();

            foreach (Aluguel aluguel in alugueis)
                grid.Rows.Add(
                    aluguel.Id,
                    aluguel.Cliente,
                    aluguel.PorcentagemEntrada,
                    aluguel.PorcentagemDesconto
                    );
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Cliente", HeaderText = "Nome do Cliente" },
                new DataGridViewTextBoxColumn { DataPropertyName = "PorcentagemEntrada", HeaderText = "Porcentagem de Entrada" },
                new DataGridViewTextBoxColumn { DataPropertyName = "PorcentagemDesconto", HeaderText = "Porcentagem de Desconto" }
            };
        }


    }
}
