using System.Text;
using System.Text.Json;

namespace Frontend_Form_
{
    public partial class FormPaciente : Form
    {
        public FormPaciente()
        {
            InitializeComponent();
        }
        private async void btnCriarPaciente_Click(object sender, EventArgs e)
        {
            var paciente = new
            {
                Nome = txtNome.Text,
                NIF = int.Parse(txtNIF.Text),
                Morada = txtMorada.Text,
                DataNascimento = DateTime.Parse(txtDataNascimento.Text)
            }; 
            
            var json = JsonSerializer.Serialize(paciente);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using var client = new HttpClient();
            var response = await client.PostAsync("https://localhost:7179/api/Pacientes", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Paciente criado com sucesso!");
                txtNome.Clear();
                txtNIF.Clear();
                txtMorada.Clear();
                txtDataNascimento.Clear();
            }
            else
            {
                var erro = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Erro: {erro}");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDataNascimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
