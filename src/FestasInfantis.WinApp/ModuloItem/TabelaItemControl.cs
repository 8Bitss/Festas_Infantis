using FestasInfantis.WinApp.Compartilhado; 


namespace FestasInfantis.WinApp.ModuloItem
{
    public partial class TabelaItemControl : UserControl
    {
        public TabelaItemControl()
        {
            InitializeComponent();

            DataGridItem.Columns.AddRange(ObterColunas());
            DataGridItem.ConfurarGridSomenteLeitura();
            DataGridItem.ConfurarGridZebrado();
        }

        public void AtualizarRegistros(List<Item> item)
        {
            DataGridItem.Rows.Clear();
            
            foreach (Item I in item)
                DataGridItem.Rows.Add(I.Id, I.Tema, I.Nome, I.valorUnitario, I.Quantidade);
        } 

        public int ObterRegistroSelecionado()
        {
            return dataGridItem.SelecionarId();
        }

        private DataFormatsColumn[] ObterColunas()
        {
            return new DataGridViewColums[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Tema", HeaderText = "Tema" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" },
                new DataGridViewTextBoxColumn { DataPropertyName = "ValorUnitario", HeaderText = "ValorUnitario" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Quantidade", HeaderText = "Quantidade" },
            };

        }
    }
}
