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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            timerWelcome.Interval = 1000; // Intervalo de 1 segundo
            timerWelcome.Start();            
        }
        private void Welcome_Load(object sender, EventArgs e)
        {
            labelTimer.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            // Confirmação antes de fechar
            DialogResult result = MessageBox.Show("Deseja sair da aplicação?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();  // Fecha o formulário se o user confirmar
            }
        }
    }
}
