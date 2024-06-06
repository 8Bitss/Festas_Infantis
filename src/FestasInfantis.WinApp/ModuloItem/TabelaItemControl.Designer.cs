namespace FestasInfantis.WinApp.ModuloItem
{
    partial class TabelaItemControl
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
            dataGridItem = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridItem).BeginInit();
            SuspendLayout();
            // 
            // dataGridItem
            // 
            dataGridItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridItem.Location = new Point(0, 0);
            dataGridItem.Name = "dataGridItem";
            dataGridItem.RowHeadersWidth = 51;
            dataGridItem.Size = new Size(396, 291);
            dataGridItem.TabIndex = 0;
            // 
            // TabelaItemControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridItem);
            Name = "TabelaItemControl";
            Size = new Size(394, 292);
            ((System.ComponentModel.ISupportInitialize)dataGridItem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridItem;
    }
}
