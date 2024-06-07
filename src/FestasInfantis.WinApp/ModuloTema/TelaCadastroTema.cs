using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloTema;
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaCadastroTema : Form
    {
        private Tema tema;
        public Tema Tema
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome.ToString();
            }
            get
            {
                return tema;
            }
        }

        public TelaCadastroTema()
        {
            InitializeComponent();

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DialogResult == DialogResult.Cancel)
            {

            }
        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            decimal valorTotal = 0;

            tema = new Tema(nome, valorTotal);

            List<string> erros = tema.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
