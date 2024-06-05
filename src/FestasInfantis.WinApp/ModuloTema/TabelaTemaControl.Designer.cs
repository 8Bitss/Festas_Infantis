namespace FestasInfantis.WinApp.ModuloTema
{
    partial class TabelaTemaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridTema = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGridTema).BeginInit();
            SuspendLayout();
            // 
            // DataGridTema
            // 
            DataGridTema.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridTema.Location = new Point(0, 3);
            DataGridTema.Name = "DataGridTema";
            DataGridTema.RowHeadersWidth = 51;
            DataGridTema.Size = new Size(287, 200);
            DataGridTema.TabIndex = 0;
            // 
            // TabelaTemaControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DataGridTema);
            Name = "TabelaTemaControl";
            Size = new Size(287, 206);
            ((System.ComponentModel.ISupportInitialize)DataGridTema).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridTema;
    }
}
