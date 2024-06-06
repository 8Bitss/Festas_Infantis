using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloItem; 

namespace FestasInfantis.WinApp.ModuloItem
{
    public partial class TelaCadastroItem : Form
    {
        public void InitializeComponent()
        {
            checkedListBoxItens = new CheckedListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            lblId = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // checkedListBoxItens
            // 
            checkedListBoxItens.FormattingEnabled = true;
            checkedListBoxItens.Items.AddRange(new object[] { "Cadeiras:", "Mesas:", "Decoração:", "Louças:", "Talheres:", "Toalhas:" });
            checkedListBoxItens.Location = new Point(12, 133);
            checkedListBoxItens.Name = "checkedListBoxItens";
            checkedListBoxItens.Size = new Size(233, 136);
            checkedListBoxItens.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(376, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(79, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(353, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 83);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(296, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(266, 189);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(166, 27);
            textBox4.TabIndex = 4;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(12, 17);
            lblId.Name = "lblId";
            lblId.Size = new Size(29, 23);
            lblId.TabIndex = 5;
            lblId.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 7;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 84);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 8;
            label1.Text = "Tema da Festa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(294, 163);
            label3.Name = "label3";
            label3.Size = new Size(94, 23);
            label3.TabIndex = 9;
            label3.Text = "Valor Total:";
            // 
            // TelaCadastroItem
            // 
            ClientSize = new Size(447, 288);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblId);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(checkedListBoxItens);
            Name = "TelaCadastroItem";
            Text = "Tela Cadastro Itens";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtTemaFesta;
        private CheckedListBox checkedListBoxItens;
        private TextBox txtId;
        private TextBox txtTotal;
    }
}
