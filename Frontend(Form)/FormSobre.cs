using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend_Form_
{
    public partial class FormSobre : Form
    {
        public FormSobre()
        {
            InitializeComponent();
            InicializarUI();
        }

        private void InicializarUI()
        {
            this.Text = "Sobre - hospital_api";
            this.BackColor = Color.Black;
            this.Size = new Size(900, 600);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;

            labelSobre = new Label();
            labelSobre.ForeColor = Color.White;
            labelSobre.Font = new Font("Consolas", 14, FontStyle.Bold);
            labelSobre.AutoSize = true;
            labelSobre.Text = ObterTextoReadme();
            labelSobre.Location = new Point(50, this.Height); // Começa fora do ecrã
            labelSobre.MaximumSize = new Size(this.Width - 100, 0);

            this.Controls.Add(labelSobre);

            timerSobre = new System.Windows.Forms.Timer();
            timerSobre.Interval = 40; // Mais baixo = mais rápido
            timerSobre.Tick += Timer_Tick;
            timerSobre.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelSobre.Top -= 2;

            if (labelSobre.Bottom < 0)
            {
                timerSobre.Stop();
                MessageBox.Show("Apresentação concluída. A iniciar aplicação...");
                this.Close();
            }
        }

        private string ObterTextoReadme()
        {
            return
@"hospital_api

Esta é uma API REST simples desenvolvida em .NET Core que permite o registo, edição e consulta de pacientes. 
A aplicação segue uma estrutura MVC básica e foi criada para fins de aprendizagem e evolução contínua.

🚀 Funcionalidades atuais:
- Criar paciente com validações básicas (data de nascimento e NIF).
- Editar informações de um paciente existente.
- Ver detalhes de um paciente específico (com cálculo automático da idade).
- Listar todos os pacientes.
- Separação clara entre Models, ViewModels e Controllers.
- Validação de NIF com regras personalizadas.

🏗 Estrutura do Projeto:
- Model/: Entidades como Paciente, Medico, Enfermeiro, etc.
- ViewModel/: Dados para input/output da API.
- Controllers/: Endpoints RESTful.
- DB/: Reservado para base de dados futura.

💡 Futuras melhorias:
- 🔌 Base de dados relacional (SQL Server, PostgreSQL).
- 🧱 Arquitetura de microserviços:
  - Serviço de Pacientes
  - Serviço de Profissionais
  - Serviço de Autenticação
- 🔐 Autenticação com JWT.
- 🖥 Interface gráfica em WinForms.
- 🧪 Testes automatizados.

🛠 Tecnologias:
- .NET Core 7+
- ASP.NET Web API
- C#
- WinForms (cliente)

📦 Como executar:
git clone https://github.com/rmluz2904/hospital-api.git

Desenvolvido com dedicação para fins educativos e melhoria contínua.";
        }
    }
}
