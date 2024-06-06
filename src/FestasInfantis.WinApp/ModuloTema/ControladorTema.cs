
using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        private RepositorioItem repositorioTema;
            
        private TabelaTemaControl tabelaTema;

        public ControladorTema(RepositorioItem repositorio)
        {
            repositorioTema = repositorio;
        }

        public override string TipoCadastro { get { return "Tema"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo tema"; } }

        public override string ToolTipEditar { get { return "Editar um tema existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um tema existente"; } }


        public override void Adicionar()
        {
            TelaCadastroTema telaTema = new TelaCadastroTema();

            DialogResult resultado = telaTema.ShowDialog();
            
            if (resultado != DialogResult.OK)
                return;

            Item novoTema = telaTema.Tema;

            repositorioTema.Cadastrar(novoTema);

            CarregarTema();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novoTema.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaCadastroTema telaCadastroTema = new TelaCadastroTema (); 
          
            int idSelecionado = tabelaTema.ObterRegistroSelecionado();

            Item temaSelecionado =
                repositorioTema.SelecionarPorId(idSelecionado);

            if (temaSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação, selecione registro válido.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaCadastroTema.Tema = temaSelecionado;

            DialogResult resultado = telaCadastroTema.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Item temaEditado = telaCadastroTema.Tema;

            repositorioTema.Editar(temaSelecionado.Id,temaEditado);
            
            CarregarTema();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{temaEditado.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaTema.ObterRegistroSelecionado();

            Item temaSelecionado =
                repositorioTema.SelecionarPorId(idSelecionado);
                
            if (temaSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação, selecione registro válido.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{temaSelecionado.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioTema.Excluir(temaSelecionado.Id);

            CarregarTema();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{temaSelecionado.Nome}\" foi excluído com sucesso!");
        }

        private void CarregarTema()
        {
            List<Item> tema = repositorioTema.SelecionarTodos();
            tabelaTema.AtualizarRegistros(tema);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaTema == null)
                tabelaTema = new TabelaTemaControl();

            CarregarTema();

            return tabelaTema;
        }
    }
}


    