using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class ControladorItem : ControladorBase
    {
        private RepositorioItem repositorioItem;

        private TabelaItemControl tabelaItem;

        public ControladorItem(RepositorioItem repositorio)
        {
            repositorioItem = repositorio;
        }

        public override string TipoCadastro { get { return "Item"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo Item"; } }

        public override string ToolTipEditar { get { return "Editar um Item existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um Item existente"; } }


        public override void Adicionar()
        {
            TelaCadastroItem telaItem = new TelaCadastroItem();

            DialogResult resultado = telaItem.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Item novoItem = telaItem.Item;

            repositorioItem.Cadastrar(novoItem);

            CarregarItem();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novoItem.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaCadastroItem telaCadastroItem = new TelaCadastroItem();

            int idSelecionado = tabelaItem.ObterRegistroSelecionado();

            Item itemSelecionado =
                repositorioItem.SelecionarPorId(idSelecionado);

            if (itemSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação, selecione um registro válido.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaCadastroItem.Item = itemSelecionado;

            DialogResult resultado = telaCadastroItem.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Item itemEditado = telaCadastroItem.Item;

            repositorioItem.Editar(itemSelecionado.Id, itemEditado);

            CarregarItem();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{itemEditado.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaItem.ObterRegistroSelecionado();

            Item itemSelecionado =
                repositorioItem.SelecionarPorId(idSelecionado);

            if (itemSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação, selecione um registro válido.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{itemSelecionado.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioItem.Excluir(itemSelecionado.Id);

            CarregarItem();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{itemSelecionado.Nome}\" foi excluído com sucesso!");
        }

        private void CarregarItem()
        {
            List<Item> item = repositorioItem.SelecionarTodos();
            tabelaItem.AtualizarRegistros(item);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaItem == null)
                tabelaItem = new TabelaItemControl();

            CarregarItem();

            return tabelaItem;
        }
    }
}
