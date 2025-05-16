namespace Frontend_Form_
{
    partial class FormCriarPaciente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtNIF = new TextBox();
            txtMorada = new TextBox();
            txtDataNascimento = new TextBox();
            btnCriarPaciente = new Button();
            btnVerPacientes = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(488, 174);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(423, 31);
            txtNome.TabIndex = 0;
            txtNome.Text = "Nome ";
            txtNome.TextAlign = HorizontalAlignment.Center;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // txtNIF
            // 
            txtNIF.Location = new Point(488, 234);
            txtNIF.Name = "txtNIF";
            txtNIF.Size = new Size(423, 31);
            txtNIF.TabIndex = 1;
            txtNIF.Text = "NIF";
            txtNIF.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMorada
            // 
            txtMorada.Location = new Point(488, 296);
            txtMorada.Name = "txtMorada";
            txtMorada.Size = new Size(423, 31);
            txtMorada.TabIndex = 2;
            txtMorada.Text = "Morada";
            txtMorada.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.AcceptsReturn = true;
            txtDataNascimento.Location = new Point(488, 361);
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(423, 31);
            txtDataNascimento.TabIndex = 3;
            txtDataNascimento.Text = "Data de Nascimento";
            txtDataNascimento.TextAlign = HorizontalAlignment.Center;
            txtDataNascimento.TextChanged += txtDataNascimento_TextChanged;
            // 
            // btnCriarPaciente
            // 
            btnCriarPaciente.Location = new Point(347, 476);
            btnCriarPaciente.Name = "btnCriarPaciente";
            btnCriarPaciente.Size = new Size(331, 109);
            btnCriarPaciente.TabIndex = 4;
            btnCriarPaciente.Text = "Criar Paciente";
            btnCriarPaciente.UseVisualStyleBackColor = true;
            btnCriarPaciente.Click += btnCriarPaciente_Click;
            // 
            // btnVerPacientes
            // 
            btnVerPacientes.Location = new Point(749, 476);
            btnVerPacientes.Name = "btnVerPacientes";
            btnVerPacientes.Size = new Size(331, 109);
            btnVerPacientes.TabIndex = 5;
            btnVerPacientes.Text = "Ver Paciente";
            btnVerPacientes.UseVisualStyleBackColor = true;
            btnVerPacientes.Click += this.btnVerPacientes_Click;
            // 
            // FormCriarPaciente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1418, 769);
            Controls.Add(btnVerPacientes);
            Controls.Add(btnCriarPaciente);
            Controls.Add(txtDataNascimento);
            Controls.Add(txtMorada);
            Controls.Add(txtNIF);
            Controls.Add(txtNome);
            Name = "FormCriarPaciente";
            Text = "Paciente";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtNIF;
        private TextBox txtMorada;
        private TextBox txtDataNascimento;
        private Button btnCriarPaciente;
        private Button btnVerPacientes;
    }
}
