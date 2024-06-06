namespace FestasInfantis.WinApp.ModuloTema
{
    partial class TelaCadastroTema
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            label1 = new Label();
            listItensTema = new ListBox();
            label2 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtItens = new TextBox();
            txtValor = new TextBox();
            label3 = new Label();
            txtAlugueis = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 11.25F);
            txtNome.Location = new Point(82, 15);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(273, 32);
            txtNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(13, 19);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 9;
            label1.Text = "Nome:";
            // 
            // listItensTema
            // 
            listItensTema.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listItensTema.FormattingEnabled = true;
            listItensTema.ItemHeight = 25;
            listItensTema.Location = new Point(19, 194);
            listItensTema.Margin = new Padding(3, 4, 3, 4);
            listItensTema.Name = "listItensTema";
            listItensTema.Size = new Size(336, 154);
            listItensTema.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 98);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 12;
            label2.Text = "Itens:";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(121, 356);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(114, 49);
            btnGravar.TabIndex = 4;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(242, 356);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 49);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtItens
            // 
            txtItens.Font = new Font("Segoe UI", 11.25F);
            txtItens.Location = new Point(82, 95);
            txtItens.Margin = new Padding(3, 4, 3, 4);
            txtItens.Name = "txtItens";
            txtItens.Size = new Size(273, 32);
            txtItens.TabIndex = 2;
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Segoe UI", 11.25F);
            txtValor.Location = new Point(82, 55);
            txtValor.Margin = new Padding(3, 4, 3, 4);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(273, 32);
            txtValor.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 58);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 17;
            label3.Text = "Valor:";
            // 
            // txtAlugueis
            // 
            txtAlugueis.Font = new Font("Segoe UI", 11.25F);
            txtAlugueis.Location = new Point(104, 135);
            txtAlugueis.Margin = new Padding(3, 4, 3, 4);
            txtAlugueis.Name = "txtAlugueis";
            txtAlugueis.Size = new Size(251, 32);
            txtAlugueis.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 138);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 19;
            label4.Text = "Alugueis:";
            // 
            // TelaCadastroTema
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 415);
            Controls.Add(txtAlugueis);
            Controls.Add(label4);
            Controls.Add(txtValor);
            Controls.Add(label3);
            Controls.Add(txtItens);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            Controls.Add(listItensTema);
            Controls.Add(label1);
            Controls.Add(txtNome);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCadastroTema";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Tema da Festa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listItensTema;
        private System.Windows.Forms.Label label2;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtItens;
        private TextBox txtValor;
        private Label label3;
        private TextBox txtAlugueis;
        private Label label4;
    }
}