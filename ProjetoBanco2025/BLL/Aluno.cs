using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco2025.BLL
{
    class Aluno
    {
        private int codAluno;
        private string nome, cpf, rg, email;
        private DateTime data;

        public int getCodAluno()
        {
            return codAluno;
        }

        public string getNome()
        {
            return this.nome;
        }

        public string getCpf()
        {
            return this.cpf;
        }

        public string getRg()
        {
            return this.rg;
        }

        public string getEmail()
        {
            return this.email;
        }

        public DateTime getData()
        {
            return this.data;
        }

        

        public void setCodAluno(int codAluno)
        {
            this.codAluno = codAluno;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public void setRg(string rg)
        {
            this.rg = rg;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public void setData(DateTime data)
        {
            this.data = data;
        }
    }
}
