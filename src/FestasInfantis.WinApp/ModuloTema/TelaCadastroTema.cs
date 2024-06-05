using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloTema;
    
namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaCadastroTema : Form
    {
        private Tema tema;
        public Tema Tema
        {
            get
            {
                return tema;
            }
            set
            {
                tema = value;
            }
        }

        public TelaCadastroTema()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text; 
            string valor = txtValor.Text;
            string itens = txtItens.Text;
            string alugueis = txtAlugueis.Text;
         
            tema = new Tema(nome,valor,itens,alugueis); // <---- {verificar aqui}  

            List<string> erros = tema.Validar();
            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }

            return;
        }
    }
}
