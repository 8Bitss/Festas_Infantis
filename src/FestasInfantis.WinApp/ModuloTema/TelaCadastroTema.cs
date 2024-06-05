using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloTema;
    
namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaCadastroTema : Form
    {
        private Tema tema;

        public Tema tema;
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

        public List<ItemTema> ItensAdicionados
        {
            get
            {
                return listItensTema.Items.Cast<ItemTema>().ToList();
            }
        }

        public TelaCadastroTema(Tema temaSelecionado)
        {
            InitializeComponent();

            Tema = temaSelecionado;

            labelTema.Text = temaSelecionado.Titulo;

            foreach (ItemTema item in temaSelecionado.Itens)
                listItensTema.Items.Add(item);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            List<string> titulos = ItensAdicionados.Select(x => x.Titulo).ToList();

            if (titulos.Contains(txtTituloItem.Text))
                return;

            ItemTema itemTema = new ItemTema(txtTituloItem.Text);

            listItensTema.Items.Add(itemTema);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}
