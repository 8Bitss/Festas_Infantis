using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloItem
{
    public partial class TelaCadastroItem : Form
    {
        private Item item;

        public Item Item
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtDescricao.Text = value.Descricao;
                txtValor.Value = value.Valor;
            }

            get { return item; }
        }

        public TelaCadastroItem()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            decimal valor = decimal.Parse(txtValor.Text);

            item = new Item(descricao, valor);

            List<string> erros = item.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
