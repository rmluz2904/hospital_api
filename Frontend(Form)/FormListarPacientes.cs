using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend_Form_
{
    public partial class FormListarPacientes : Form
    {
        public FormListarPacientes()
        {
            InitializeComponent();
        }
        private async void FormListarPacientes_Load(object sender, EventArgs e)
        {
            using var client = new HttpClient();
            var response = await client.GetAsync("https://localhost:7179/api/Pacientes/ListarPacientes");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var pacientes = JsonSerializer.Deserialize<List<PacienteVM>>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                dataGridViewVerPacientes.DataSource = pacientes;
            }
            else
            {
                MessageBox.Show("Erro ao carregar pacientes.");
            }
        }

        public class PacienteVM
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public DateTime DataNascimento { get; set; }
            public int Age { get; set; }
            public int NIF { get; set; }
            public string Morada { get; set; }
        }

        private void dataGridViewVerPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
