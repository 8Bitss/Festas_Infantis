using FestasInfantis.WinApp.ModuloCliente;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        private Aluguel aluguel;

        public Aluguel Aluguel
        {
            get
            {
                return aluguel;
            }
        }

        public TelaAluguelForm()
        {
            InitializeComponent();
        }

        public void CarregarClientes(List<Cliente> clientes)
        {
            cmbClientes.Items.Clear();

            foreach (Cliente c in clientes)
                cmbClientes.Items.Add(c);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            decimal porcenagemEntrada = 0;
            decimal porcenagemDesconto = 0;


            string cidade = txtCidade.Text;
            string rua = txtRua.Text;
            string estado = txtEstado.Text;
            string bairro = txtBairro.Text;
            string numero = txtNumero.Text;

            Festa.Endereco endereco = new Festa.Endereco(cidade, rua, estado, bairro, numero);

            DateTime dataTeste = DateTime.Now;

            Festa festa = new Festa(endereco, dataTeste, dataTeste, dataTeste);

            aluguel = new Aluguel(porcenagemEntrada, porcenagemDesconto, festa);

            List<string> erros = aluguel.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }

        }
    }
}
