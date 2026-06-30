using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBanco2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAlunos_Click(object sender, EventArgs e)
        {
            FrmAluno telaAluno = new FrmAluno();
            telaAluno.ShowDialog();
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario telaUsuario = new FrmUsuario();
            telaUsuario.ShowDialog();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
