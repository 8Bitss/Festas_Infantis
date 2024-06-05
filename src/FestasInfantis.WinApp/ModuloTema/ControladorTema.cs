using FestasInfantis.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
    
        public ControladorTema(RepositorioTema repositorio)
        {
            repositorioTema = repositorio;
        }

        public override string TipoCadastro { get { return "Nome"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo tema"; } }

        public override string ToolTipEditar { get { return "Editar um tema existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um tema existente"; } }


        public override void Adicionar()
        {
            TelaCadastroTemaForm telaCadastroTema = new TelaCadastroTemaForm();
          
            DialogResult resultado = telaCadastroTema.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Tema novoTema = telaCadastroTema.Tema;

            repositorioTema.CadastrarTema();
            CarregarTema();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novoTema.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaCadastroTema telaCadastroTema = new TelaCadastroTemaForm(); 
           
          int idSelecionado = TabelaTemaControl.ObterRegistroSelecionado(); 

            Tema temaSelecionado =
                repositorioTema.SelecionarPorId(idSelecionado);

            if (temaSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação, selecione um registro para proceguir.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaCadastroTema.tema = temaSelecionado;

            DialogResult resultado = telaCadastroTema.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Tema temaEditado = telaCadastroTema.tema;

            repositorioTema.Editar(temaSelecionado.Id, temaEditado);

            CarregarClientes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{temaEditado.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaTema.ObterRegistroSelecionado();

            Tema temaSelecionado =
                repositorioTema.SelecionarPorId(idSelecionado);

            if (temaSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação, selecione um registro para proceguir.",
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

            CarregarClientes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{temaSelecionado.Nome}\" foi excluído com sucesso!");
        }

        private void CarregarClientes()
        {
            List<Tema> tema = repositorioTema.SelecionarTodos();

            tabelaTemaControl.AtualizarRegistros(tema);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaTemaControl == null)
                tabelaTemaControl = new TabelaTemaControl();

            CarregarTema();

            return tabelaTemaControl;
        }
    }
}