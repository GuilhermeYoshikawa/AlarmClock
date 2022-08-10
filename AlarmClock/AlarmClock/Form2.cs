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
    public partial class frmForm2 : Form
    {
        public frmForm2()
        {
            InitializeComponent();
        }

        private void Alarm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            // Abrir o Form do Despertador
            frmForm3 Despertador = new frmForm3();
            Despertador.ShowDialog();
        }
    }
}
