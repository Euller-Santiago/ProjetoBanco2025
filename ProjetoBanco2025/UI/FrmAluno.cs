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
    public partial class FrmAluno : Form
    {
        BLL.Aluno aluno = new BLL.Aluno();
        DAL.AlunoDAL alunoDAL = new DAL.AlunoDAL();
        bool cadastra = true;
        public FrmAluno()
        {
            InitializeComponent();
        }


        //O Campo abaixo não deveria existir... Por favor, ignore-o. :)
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmAluno_Load(object sender, EventArgs e)
        {
            dgvAluno.DataSource = alunoDAL.ConsultaTodos();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            aluno.setCodAluno(Convert.ToInt16(dgvAluno[0, dgvAluno.CurrentRow.Index].Value));
            aluno = alunoDAL.Retornar(aluno);
            txtNome.Text = aluno.getNome();
            txtCPF.Text = aluno.getCpf();
            txtRG.Text = aluno.getRg();    
            txtEmail.Text = aluno.getEmail();
            txtNascimento.Value = aluno.getData();

            tabControl1.SelectedTab = tabPage1;
            cadastra = false;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            aluno.setNome(txtNome.Text);
            aluno.setCpf(txtCPF.Text);
            aluno.setRg(txtRG.Text);
            aluno.setEmail(txtEmail.Text);
            aluno.setData(txtNascimento.Value);

            
            if (cadastra == true)
            {
                alunoDAL.Cadastrar(aluno);
                MessageBox.Show("Dados cadastrados com sucesso!");
            }
            else
            {
                alunoDAL.Atualizar(aluno);
                MessageBox.Show("Dados atualizados com sucesso!");
                cadastra = true;
                tabControl1.SelectedTab = tabPage2;
            }
            LimpaTodos();
            dgvAluno.DataSource = alunoDAL.ConsultaTodos();
            txtNome.Focus();
        }

        public void LimpaTodos()
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtRG.Clear();
            txtEmail.Clear();
            cadastra = true;
        }


        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este registro?",
                "Excluir",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                //pegar o código do produto a ser excluído
                aluno.setCodAluno(Convert.ToInt16(dgvAluno[0, dgvAluno.CurrentRow.Index].Value));
                alunoDAL.Excluir(aluno);

                //atualizar a consulta
                dgvAluno.DataSource = alunoDAL.ConsultaTodos();
            }
        }

        private void TxtNomeConsulta_TextChanged(object sender, EventArgs e)
        {
            aluno.setNome(txtNomeConsulta.Text);
            dgvAluno.DataSource = alunoDAL.PesquisarNome(aluno);
        }
    }
}