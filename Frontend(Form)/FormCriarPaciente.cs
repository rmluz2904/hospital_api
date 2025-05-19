using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Frontend_Form_
{
    public partial class FormCriarPaciente : Form
    {
        public FormCriarPaciente()
        {
            InitializeComponent();

            pictureBoxCriarPaciente.AllowDrop = true;
            pictureBoxCriarPaciente.DragEnter += pictureBoxCriarPaciente_DragEnter;
            pictureBoxCriarPaciente.DragDrop += pictureBoxCriarPaciente_DragDrop;
        }
        private void pictureBoxCriarPaciente_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBoxCriarPaciente_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                pictureBoxCriarPaciente.Image = Image.FromFile(files[0]);
            }
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
            var response = await client.PostAsync("https://localhost:7179/api/Pacientes/CriarPaciente", content);

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
        private void btnVerPacientes_Click(object sender, EventArgs e)
        {
            var formLista = new FormListarPacientes();
            formLista.ShowDialog();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDataNascimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCriarPaciente_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void tiposDeRegistosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
