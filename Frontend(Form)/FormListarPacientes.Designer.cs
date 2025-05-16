namespace Frontend_Form_
{
    partial class FormListarPacientes
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
            dataGridViewVerPacientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVerPacientes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewVerPacientes
            // 
            dataGridViewVerPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVerPacientes.Location = new Point(138, 100);
            dataGridViewVerPacientes.Name = "dataGridViewVerPacientes";
            dataGridViewVerPacientes.RowHeadersWidth = 62;
            dataGridViewVerPacientes.Size = new Size(1045, 528);
            dataGridViewVerPacientes.TabIndex = 0;
            dataGridViewVerPacientes.CellContentClick += dataGridViewVerPacientes_CellContentClick;
            // 
            // FormListarPacientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1429, 768);
            Controls.Add(dataGridViewVerPacientes);
            Name = "FormListarPacientes";
            Text = "Listar Pacientes";
            Load += FormListarPacientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewVerPacientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewVerPacientes;
    }
}