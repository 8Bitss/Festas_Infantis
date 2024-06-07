namespace FestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaAluguelForm
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
            txtId = new TextBox();
            label1 = new Label();
            tabAluguel = new TabControl();
            PageDadosFesta = new TabPage();
            gpDadosEndereco = new GroupBox();
            txtNumero = new TextBox();
            label9 = new Label();
            txtEstado = new TextBox();
            label8 = new Label();
            txtBairro = new TextBox();
            txtRua = new TextBox();
            txtCidade = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            gpDateHora = new GroupBox();
            txtHoraTermino = new MaskedTextBox();
            txtHoraInicio = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            txtData = new DateTimePicker();
            label2 = new Label();
            PageDadosAluguel = new TabPage();
            groupBox1 = new GroupBox();
            btnCalcular = new Button();
            textBox6 = new TextBox();
            label13 = new Label();
            txtValorTemaDesconto = new TextBox();
            label14 = new Label();
            txtValorEntrada = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            cmbTemas = new ComboBox();
            cmbSinal = new ComboBox();
            cmbClientes = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            tabAluguel.SuspendLayout();
            PageDadosFesta.SuspendLayout();
            gpDadosEndereco.SuspendLayout();
            gpDateHora.SuspendLayout();
            PageDadosAluguel.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F);
            txtId.Location = new Point(69, 51);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(114, 27);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(38, 54);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 2;
            label1.Text = "Id:";
            // 
            // tabAluguel
            // 
            tabAluguel.Controls.Add(PageDadosFesta);
            tabAluguel.Controls.Add(PageDadosAluguel);
            tabAluguel.Location = new Point(38, 104);
            tabAluguel.Name = "tabAluguel";
            tabAluguel.SelectedIndex = 0;
            tabAluguel.Size = new Size(572, 391);
            tabAluguel.TabIndex = 3;
            // 
            // PageDadosFesta
            // 
            PageDadosFesta.Controls.Add(gpDadosEndereco);
            PageDadosFesta.Controls.Add(gpDateHora);
            PageDadosFesta.Location = new Point(4, 24);
            PageDadosFesta.Name = "PageDadosFesta";
            PageDadosFesta.Padding = new Padding(3);
            PageDadosFesta.Size = new Size(564, 363);
            PageDadosFesta.TabIndex = 0;
            PageDadosFesta.Text = "Dados da Festa";
            PageDadosFesta.UseVisualStyleBackColor = true;
            // 
            // gpDadosEndereco
            // 
            gpDadosEndereco.Controls.Add(txtNumero);
            gpDadosEndereco.Controls.Add(label9);
            gpDadosEndereco.Controls.Add(txtEstado);
            gpDadosEndereco.Controls.Add(label8);
            gpDadosEndereco.Controls.Add(txtBairro);
            gpDadosEndereco.Controls.Add(txtRua);
            gpDadosEndereco.Controls.Add(txtCidade);
            gpDadosEndereco.Controls.Add(label3);
            gpDadosEndereco.Controls.Add(label6);
            gpDadosEndereco.Controls.Add(label7);
            gpDadosEndereco.Location = new Point(27, 186);
            gpDadosEndereco.Name = "gpDadosEndereco";
            gpDadosEndereco.Size = new Size(497, 148);
            gpDadosEndereco.TabIndex = 10;
            gpDadosEndereco.TabStop = false;
            gpDadosEndereco.Text = "Dados do Endereço:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(359, 108);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(132, 23);
            txtNumero.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.Location = new Point(285, 111);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 13;
            label9.Text = "Número:";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(359, 33);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(132, 23);
            txtEstado.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.Location = new Point(294, 32);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 11;
            label8.Text = "Estado:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(82, 104);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(157, 23);
            txtBairro.TabIndex = 10;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(82, 69);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(409, 23);
            txtRua.TabIndex = 9;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(82, 33);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(132, 23);
            txtCidade.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(24, 103);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 6;
            label3.Text = "Bairro:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(39, 68);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 7;
            label6.Text = "Rua:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(17, 32);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 4;
            label7.Text = "Cidade:";
            // 
            // gpDateHora
            // 
            gpDateHora.Controls.Add(txtHoraTermino);
            gpDateHora.Controls.Add(txtHoraInicio);
            gpDateHora.Controls.Add(label5);
            gpDateHora.Controls.Add(label4);
            gpDateHora.Controls.Add(txtData);
            gpDateHora.Controls.Add(label2);
            gpDateHora.Location = new Point(27, 32);
            gpDateHora.Name = "gpDateHora";
            gpDateHora.Size = new Size(497, 148);
            gpDateHora.TabIndex = 0;
            gpDateHora.TabStop = false;
            gpDateHora.Text = "Data e Hora:";
            // 
            // txtHoraTermino
            // 
            txtHoraTermino.CutCopyMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txtHoraTermino.Location = new Point(385, 92);
            txtHoraTermino.Mask = "00:00";
            txtHoraTermino.Name = "txtHoraTermino";
            txtHoraTermino.Size = new Size(106, 23);
            txtHoraTermino.TabIndex = 9;
            txtHoraTermino.ValidatingType = typeof(DateTime);
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.CutCopyMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txtHoraInicio.Location = new Point(133, 95);
            txtHoraInicio.Mask = "00:00";
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.Size = new Size(106, 23);
            txtHoraInicio.TabIndex = 8;
            txtHoraInicio.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(251, 95);
            label5.Name = "label5";
            label5.Size = new Size(138, 20);
            label5.TabIndex = 6;
            label5.Text = "Horário deTérmino:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(9, 95);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 7;
            label4.Text = "Horário de Início:";
            // 
            // txtData
            // 
            txtData.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(126, 27);
            txtData.Name = "txtData";
            txtData.Size = new Size(113, 27);
            txtData.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(17, 32);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 4;
            label2.Text = "Data da Festa:";
            // 
            // PageDadosAluguel
            // 
            PageDadosAluguel.Controls.Add(groupBox1);
            PageDadosAluguel.Controls.Add(cmbTemas);
            PageDadosAluguel.Controls.Add(cmbSinal);
            PageDadosAluguel.Controls.Add(cmbClientes);
            PageDadosAluguel.Controls.Add(label12);
            PageDadosAluguel.Controls.Add(label11);
            PageDadosAluguel.Controls.Add(label10);
            PageDadosAluguel.Location = new Point(4, 24);
            PageDadosAluguel.Name = "PageDadosAluguel";
            PageDadosAluguel.Padding = new Padding(3);
            PageDadosAluguel.Size = new Size(564, 363);
            PageDadosAluguel.TabIndex = 1;
            PageDadosAluguel.Text = "Dados do Aluguel";
            PageDadosAluguel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtValorTemaDesconto);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txtValorEntrada);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(textBox10);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label17);
            groupBox1.Location = new Point(27, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(497, 182);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados de Pagamento:";
            // 
            // btnCalcular
            // 
            btnCalcular.Image = Properties.Resources.btnCalcular1;
            btnCalcular.Location = new Point(6, 22);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(485, 48);
            btnCalcular.TabIndex = 15;
            btnCalcular.Text = "Calcular";
            btnCalcular.TextAlign = ContentAlignment.MiddleRight;
            btnCalcular.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(385, 147);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(103, 23);
            textBox6.TabIndex = 14;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F);
            label13.Location = new Point(268, 146);
            label13.Name = "label13";
            label13.Size = new Size(111, 20);
            label13.TabIndex = 13;
            label13.Text = "Valor Pendente:";
            // 
            // txtValorTemaDesconto
            // 
            txtValorTemaDesconto.Location = new Point(385, 112);
            txtValorTemaDesconto.Name = "txtValorTemaDesconto";
            txtValorTemaDesconto.Size = new Size(103, 23);
            txtValorTemaDesconto.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F);
            label14.Location = new Point(270, 91);
            label14.Name = "label14";
            label14.Size = new Size(109, 40);
            label14.TabIndex = 11;
            label14.Text = "Valor do Tema \r\ncom Desconto:";
            // 
            // txtValorEntrada
            // 
            txtValorEntrada.Location = new Point(146, 146);
            txtValorEntrada.Name = "txtValorEntrada";
            txtValorEntrada.Size = new Size(104, 23);
            txtValorEntrada.TabIndex = 10;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(145, 112);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(105, 23);
            textBox9.TabIndex = 9;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(145, 76);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(77, 23);
            textBox10.TabIndex = 8;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.25F);
            label15.Location = new Point(18, 146);
            label15.Name = "label15";
            label15.Size = new Size(122, 20);
            label15.TabIndex = 6;
            label15.Text = "Valor de Entrada:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.25F);
            label16.Location = new Point(31, 111);
            label16.Name = "label16";
            label16.Size = new Size(108, 20);
            label16.TabIndex = 7;
            label16.Text = "Valor do Tema:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11.25F);
            label17.Location = new Point(27, 79);
            label17.Name = "label17";
            label17.Size = new Size(112, 20);
            label17.TabIndex = 4;
            label17.Text = "% de Desconto:";
            // 
            // cmbTemas
            // 
            cmbTemas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTemas.Enabled = false;
            cmbTemas.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTemas.FormattingEnabled = true;
            cmbTemas.Location = new Point(341, 14);
            cmbTemas.Name = "cmbTemas";
            cmbTemas.Size = new Size(145, 28);
            cmbTemas.TabIndex = 14;
            // 
            // cmbSinal
            // 
            cmbSinal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSinal.Enabled = false;
            cmbSinal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSinal.FormattingEnabled = true;
            cmbSinal.Location = new Point(91, 68);
            cmbSinal.Name = "cmbSinal";
            cmbSinal.Size = new Size(148, 28);
            cmbSinal.TabIndex = 13;
            // 
            // cmbClientes
            // 
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientes.Enabled = false;
            cmbClientes.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(91, 14);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(148, 28);
            cmbClientes.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F);
            label12.Location = new Point(287, 17);
            label12.Name = "label12";
            label12.Size = new Size(48, 20);
            label12.TabIndex = 11;
            label12.Text = "Tema:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F);
            label11.Location = new Point(22, 71);
            label11.Name = "label11";
            label11.Size = new Size(63, 20);
            label11.TabIndex = 10;
            label11.Text = "Entrada:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F);
            label10.Location = new Point(27, 17);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 9;
            label10.Text = "Cliente:";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(428, 515);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 37);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(534, 515);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 37);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 564);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(tabAluguel);
            Controls.Add(txtId);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaAluguelForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Aluguéis";
            tabAluguel.ResumeLayout(false);
            PageDadosFesta.ResumeLayout(false);
            gpDadosEndereco.ResumeLayout(false);
            gpDadosEndereco.PerformLayout();
            gpDateHora.ResumeLayout(false);
            gpDateHora.PerformLayout();
            PageDadosAluguel.ResumeLayout(false);
            PageDadosAluguel.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label1;
        private TabControl tabAluguel;
        private TabPage PageDadosFesta;
        private GroupBox gpDateHora;
        private Label label2;
        private TabPage PageDadosAluguel;
        private Label label5;
        private Label label4;
        private DateTimePicker txtData;
        private GroupBox gpDadosEndereco;
        private TextBox txtNumero;
        private Label label9;
        private TextBox txtEstado;
        private Label label8;
        private TextBox txtBairro;
        private TextBox txtRua;
        private TextBox txtCidade;
        private Label label3;
        private Label label6;
        private Label label7;
        private MaskedTextBox txtHoraTermino;
        private MaskedTextBox txtHoraInicio;
        private Button btnGravar;
        private Button btnCancelar;
        private GroupBox groupBox1;
        private TextBox textBox6;
        private Label label13;
        private TextBox txtValorTemaDesconto;
        private Label label14;
        private TextBox txtValorEntrada;
        private TextBox textBox9;
        private TextBox textBox10;
        private Label label15;
        private Label label16;
        private Label label17;
        private ComboBox cmbTemas;
        private ComboBox cmbSinal;
        private ComboBox cmbClientes;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button btnCalcular;
    }
}