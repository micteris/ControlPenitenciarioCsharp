using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPenitenciario
{
    public partial class Form1 : Form
    {
        connect c = new connect();
        DataAccess Data = new DataAccess();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            

        }

        private void Vergueo()
        {
            var password = c.contras(txtUser.Text);
            if (password == txtPassword.Text)
            {
                MessageBox.Show("Correcto");
            }
            else
            {
                MessageBox.Show("tas pendejo");
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            var usuarioUi = new Usuarios { Nick = txtUser.Text, contra = txtPassword.Text };
            var usuarioResult = Data.Auth(usuarioUi);
            if (usuarioUi.Nick == usuarioResult.Nick && usuarioUi.contra == usuarioResult.contra)
                MessageBox.Show("Correcto");
            else
                MessageBox.Show("tas pendejo");
        }
    }
}
