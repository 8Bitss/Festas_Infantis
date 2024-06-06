namespace FestasInfantis.WinApp.ModuloItem

{
    partial class TelaCadastroItem
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
        {
            listValores = new ListBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtTemaDaFesta = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtValor = new TextBox();
            label4 = new Label();
            txtQuantidades = new TextBox();
            // 
            // listValores
            // 
            listValores.FormattingEnabled = true;
            listValores.Location = new Point(4, 165);
            listValores.Name = "listValores";
            listValores.Size = new Size(413, 144);
            listValores.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 7);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 13;
            label2.Text = "Tema da Festa:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 89);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 14;
            label1.Text = "Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(12, 49);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 16;
            label3.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 11.25F);
            txtNome.Location = new Point(78, 46);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(339, 32);
            txtNome.TabIndex = 1;
            // 
            // txtTemaDaFesta
            // 
            txtTemaDaFesta.Location = new Point(139, 7);
            txtTemaDaFesta.Name = "txtTemaDaFesta";
            txtTemaDaFesta.Size = new Size(278, 27);
            txtTemaDaFesta.TabIndex = 0;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(150, 316);
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
            btnCancelar.Location = new Point(271, 316);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 49);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Segoe UI", 11.25F);
            txtValor.Location = new Point(78, 86);
            txtValor.Margin = new Padding(3, 4, 3, 4);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(339, 32);
            txtValor.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 129);
            label4.Name = "label4";
            label4.Size = new Size(123, 25);
            label4.TabIndex = 22;
            label4.Text = "Quantidades:";
            // 
            // txtQuantidades
            // 
            txtQuantidades.Font = new Font("Segoe UI", 11.25F);
            txtQuantidades.Location = new Point(139, 126);
            txtQuantidades.Margin = new Padding(3, 4, 3, 4);
            txtQuantidades.Name = "txtQuantidades";
            txtQuantidades.Size = new Size(278, 32);
            txtQuantidades.TabIndex = 3;
private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label lblId;
        private Label label2;
        private Label label1;
        private Label label3;
        // 
        // TelaCadastroValor
        // 
    }

        #endregion

        private ListBox listValores;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtTemaDaFesta;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtValor;
        private Label label4;
        private TextBox txtQuantidades;
    }
}