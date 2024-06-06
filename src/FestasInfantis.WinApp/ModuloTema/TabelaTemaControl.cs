using FestasInfantis.WinApp.Compartilhado;


namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TabelaTemaControl : UserControl
    {

        public TabelaTemaControl()
        {
            InitializeComponent();

            DataGridTema.Columns.AddRange(ObterColunas());
            DataGridTema.ConfigurarGridSomenteLeitura();
            DataGridTema.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Tema> tema)
        {
          DataGridTema.Rows.Clear();

            foreach (Tema T in tema)
                DataGridTema.Rows.Add(T.Id, T.Nome, T.Valor); //T.Aluguel);
        }

        public int ObterRegistroSelecionado()
        {
            return DataGridTema.SelecionarId();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Aluguel", HeaderText = "Aluguel" },
            };
        }
    }
}