namespace eAgenda.WinApp.ModuloTarefa
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
            txtTituloItem = new TextBox();
            label1 = new Label();
            listItensTema = new ListBox();
            btnAdicionar = new Button();
            label2 = new Label();
            labelTema = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtTituloItem
            // 
            txtTituloItem.Font = new Font("Segoe UI", 11.25F);
            txtTituloItem.Location = new Point(78, 72);
            txtTituloItem.Margin = new Padding(3, 4, 3, 4);
            txtTituloItem.Name = "txtTituloItem";
            txtTituloItem.Size = new Size(273, 32);
            txtTituloItem.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(14, 76);
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
            listItensTema.Location = new Point(14, 135);
            listItensTema.Margin = new Padding(3, 4, 3, 4);
            listItensTema.Name = "listItensTema";
            listItensTema.Size = new Size(438, 204);
            listItensTema.TabIndex = 10;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Segoe UI", 11.25F);
            btnAdicionar.Location = new Point(358, 72);
            btnAdicionar.Margin = new Padding(3, 4, 3, 4);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(95, 36);
            btnAdicionar.TabIndex = 11;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 25);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 12;
            label2.Text = "Tema:";
            // 
            // labelTema
            // 
            labelTema.AutoSize = true;
            labelTema.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTema.Location = new Point(80, 25);
            labelTema.Name = "labelTema";
            labelTema.Size = new Size(72, 25);
            labelTema.TabIndex = 13;
            labelTema.Text = "[Tema]";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(217, 395);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(114, 49);
            btnGravar.TabIndex = 15;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(338, 395);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 49);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaCadastroTema
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 457);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(labelTema);
            Controls.Add(label2);
            Controls.Add(btnAdicionar);
            Controls.Add(listItensTema);
            Controls.Add(label1);
            Controls.Add(txtTituloItem);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCadastroTema";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro do Tema da Festa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox txtTituloItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listItensTema;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTema;
        private Button btnGravar;
        private Button btnCancelar;
    }
}