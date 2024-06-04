namespace FestasInfantis.WinApp.ModuloTema
{
    partial class TelaCadastroValor
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
            listValores = new ListBox();
            label2 = new Label();
            label1 = new Label();
            btnAdicionar = new Button();
            label3 = new Label();
            txtTituloItem = new TextBox();
            textBox1 = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // listValores
            // 
            listValores.FormattingEnabled = true;
            listValores.Location = new Point(12, 126);
            listValores.Name = "listValores";
            listValores.Size = new Size(418, 184);
            listValores.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
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
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Segoe UI", 11.25F);
            btnAdicionar.Location = new Point(335, 43);
            btnAdicionar.Margin = new Padding(3, 4, 3, 4);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(95, 36);
            btnAdicionar.TabIndex = 17;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
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
            // txtTituloItem
            // 
            txtTituloItem.Font = new Font("Segoe UI", 11.25F);
            txtTituloItem.Location = new Point(78, 46);
            txtTituloItem.Margin = new Padding(3, 4, 3, 4);
            txtTituloItem.Name = "txtTituloItem";
            txtTituloItem.Size = new Size(254, 32);
            txtTituloItem.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 27);
            textBox1.TabIndex = 18;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(197, 316);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(114, 49);
            btnGravar.TabIndex = 20;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(318, 316);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 49);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11.25F);
            textBox2.Location = new Point(78, 86);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(254, 32);
            textBox2.TabIndex = 21;
            // 
            // TelaCadastroValor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 375);
            Controls.Add(textBox2);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(textBox1);
            Controls.Add(btnAdicionar);
            Controls.Add(label3);
            Controls.Add(txtTituloItem);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(listValores);
            Name = "TelaCadastroValor";
            Text = "Cadastro de Valores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listValores;
        private Label label2;
        private Label label1;
        private Button btnAdicionar;
        private Label label3;
        private TextBox txtTituloItem;
        private TextBox textBox1;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox textBox2;
    }
}