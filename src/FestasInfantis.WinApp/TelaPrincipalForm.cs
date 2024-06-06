using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloTema;
using FestasInfantis.WinApp.ModuloItem;


namespace FestasInfantis.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;
        RepositorioItem repositorioItem;
        RepositorioTema repositorioTema;

        public static TelaPrincipalForm Instancia { get; private set; }

        public TelaPrincipalForm()
        {
            InitializeComponent();
            repositorioTema = new RepositorioTema();
            repositorioItem = new RepositorioItem();

            lblTipoCadastro.Text = string.Empty;
            Instancia = this;
        }

        public void AtualizarRodape(string texto)
        {
            statusLabelPrincipal.Text = texto;
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
        {
            lblTipoCadastro.Text = "Cadastro de " + controladorSelecionado.TipoCadastro;

            ConfigurarToolBox(controladorSelecionado);
            ConfigurarListagem(controladorSelecionado);
        }

        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = controladorSelecionado is ControladorBase;
            btnEditar.Enabled = controladorSelecionado is ControladorBase;
            btnExcluir.Enabled = controladorSelecionado is ControladorBase;

            btnFiltrar.Enabled = controladorSelecionado is IControladorFiltravel;

            ConfigurarToolTips(controladorSelecionado);
        }

        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;

            if (controladorSelecionado is IControladorFiltravel controladorFiltravel)
                btnFiltrar.ToolTipText = controladorFiltravel.ToolTipFiltrar;
        }

        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemContato = controladorSelecionado.ObterListagem();
            listagemContato.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemContato);
        }

        private void temasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTema(repositorioTema);
            ConfigurarTelaPrincipal(controlador);

            controlador = new ControladorItem(repositorioItem);
            ConfigurarTelaPrincipal(controlador);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
            TelaCadastroItem telaCadastroItem = new TelaCadastroItem();
        }

        private void toolStripMenuTema_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
            TelaCadastroTema telaCadastroTema = new TelaCadastroTema();
        }
    }
}
