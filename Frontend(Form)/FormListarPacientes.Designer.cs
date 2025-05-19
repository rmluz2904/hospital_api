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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVerPacientes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewVerPacientes
            // 
            dataGridViewVerPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVerPacientes.Location = new Point(187, 156);
            dataGridViewVerPacientes.Name = "dataGridViewVerPacientes";
            dataGridViewVerPacientes.RowHeadersWidth = 62;
            dataGridViewVerPacientes.Size = new Size(1045, 528);
            dataGridViewVerPacientes.TabIndex = 0;
            dataGridViewVerPacientes.CellContentClick += dataGridViewVerPacientes_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.Location = new Point(486, 47);
            label1.Name = "label1";
            label1.Size = new Size(444, 67);
            label1.TabIndex = 1;
            label1.Text = "Lista de pacientes";
            // 
            // FormListarPacientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1429, 768);
            Controls.Add(label1);
            Controls.Add(dataGridViewVerPacientes);
            Name = "FormListarPacientes";
            Text = "Listar Pacientes";
            Load += FormListarPacientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewVerPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewVerPacientes;
        private Label label1;
    }
}