using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using FestasInfantis.WinApp.Compartilhado;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public void AtualizarRegistros(List<Item> tema)
        {
          DataGridTema.Rows.Clear();

            foreach (Item T in tema)
                DataGridTema.Rows.Add(T.Id, T.Nome, T.Valor); //T.Aluguel);
        }

        public int ObterRegistroSelecionado()
        {
            return DataGridTema.SelecionarId();
        }

        internal void AtualizarRegistros(List<Tema> tema)
        {
            throw new NotImplementedException();
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