using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class frmForm1 : Form
    {
        public frmForm1()
        {
            InitializeComponent();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            // Abrir o Form do Horário de Início
            frmForm2 HorarioDeInicio = new frmForm2();
            HorarioDeInicio.ShowDialog();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://app.pmovel.com.br/");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
