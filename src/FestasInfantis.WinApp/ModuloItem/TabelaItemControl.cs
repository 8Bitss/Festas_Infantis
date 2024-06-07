using FestasInfantis.WinApp.Compartilhado; 


namespace FestasInfantis.WinApp.ModuloItem
{
    public partial class TabelaItemControl : UserControl
    {
        public TabelaItemControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();

            
        }


        public void AtualizarRegistros(List<Item> item)
        {
            grid.Rows.Clear();
            
            foreach (Item I in item)
                grid.Rows.Add(I.Id, I.Descricao, I.Valor);
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Descricao", HeaderText = "Descrição" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor" },
            };

        }
    }
}
