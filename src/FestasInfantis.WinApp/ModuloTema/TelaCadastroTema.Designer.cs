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
            btnGravar = new Button();
            btnCancelar = new Button();
            tabItens = new TabControl();
            pageDadosBasicos = new TabPage();
            pageSelecaoItens = new TabPage();
            txtId = new TextBox();
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            clbItens = new CheckedListBox();
            tabItens.SuspendLayout();
            pageDadosBasicos.SuspendLayout();
            pageSelecaoItens.SuspendLayout();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(358, 373);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 37);
            btnGravar.TabIndex = 4;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(464, 373);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 37);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tabItens
            // 
            tabItens.Controls.Add(pageDadosBasicos);
            tabItens.Controls.Add(pageSelecaoItens);
            tabItens.Location = new Point(21, 42);
            tabItens.Name = "tabItens";
            tabItens.SelectedIndex = 0;
            tabItens.Size = new Size(543, 315);
            tabItens.TabIndex = 6;
            // 
            // pageDadosBasicos
            // 
            pageDadosBasicos.Controls.Add(txtNome);
            pageDadosBasicos.Controls.Add(label2);
            pageDadosBasicos.Controls.Add(txtId);
            pageDadosBasicos.Controls.Add(label1);
            pageDadosBasicos.Location = new Point(4, 24);
            pageDadosBasicos.Name = "pageDadosBasicos";
            pageDadosBasicos.Padding = new Padding(3);
            pageDadosBasicos.Size = new Size(535, 287);
            pageDadosBasicos.TabIndex = 0;
            pageDadosBasicos.Text = "Dados Básicos";
            pageDadosBasicos.UseVisualStyleBackColor = true;
            // 
            // pageSelecaoItens
            // 
            pageSelecaoItens.Controls.Add(clbItens);
            pageSelecaoItens.Location = new Point(4, 24);
            pageSelecaoItens.Name = "pageSelecaoItens";
            pageSelecaoItens.Padding = new Padding(3);
            pageSelecaoItens.Size = new Size(535, 287);
            pageSelecaoItens.TabIndex = 1;
            pageSelecaoItens.Text = "Seleção de Itens";
            pageSelecaoItens.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(79, 30);
            txtId.Name = "txtId";
            txtId.Size = new Size(76, 23);
            txtId.TabIndex = 5;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(48, 29);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 4;
            label1.Text = "Id:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(79, 72);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(303, 23);
            txtNome.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(20, 75);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 6;
            label2.Text = "Nome:";
            // 
            // clbItens
            // 
            clbItens.FormattingEnabled = true;
            clbItens.Location = new Point(3, 6);
            clbItens.Name = "clbItens";
            clbItens.Size = new Size(526, 274);
            clbItens.TabIndex = 0;
            // 
            // TelaCadastroTema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 422);
            Controls.Add(tabItens);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCadastroTema";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Temas";
            tabItens.ResumeLayout(false);
            pageDadosBasicos.ResumeLayout(false);
            pageDadosBasicos.PerformLayout();
            pageSelecaoItens.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnGravar;
        private Button btnCancelar;
        private TabControl tabItens;
        private TabPage pageDadosBasicos;
        private TabPage pageSelecaoItens;
        private TextBox txtId;
        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private CheckedListBox clbItens;
    }
}