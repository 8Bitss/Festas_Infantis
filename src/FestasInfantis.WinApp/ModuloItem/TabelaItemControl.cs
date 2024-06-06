using FestasInfantis.WinApp.Compartilhado; 


namespace FestasInfantis.WinApp.ModuloItem
{
    public partial class TabelaItemControl : UserControl
    {
        public TabelaItemControl()
        {
            InitializeComponent();

            DataGridItem.Columns.AddRange(ObterColunas());
            DataGridItem.ConfigurarGridSomenteLeitura();
            DataGridItem.ConfigurarGridZebrado();
        }

        public object DataGridItem { get; }

        public void AtualizarRegistros(List<Item> item)
        {
            DataGridItem.Rows.Clear();
            
            foreach (Item I in item)
                DataGridItem.Rows.Add(I.Id, I.Tema, I.Nome, I.Valor, I.Quantidade);
        } 

        public int ObterRegistroSelecionado()
        {
            return dataGridItem.SelecionarId();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Tema", HeaderText = "Tema" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Quantidade", HeaderText = "Quantidade" },
            };

        }
    }
}
