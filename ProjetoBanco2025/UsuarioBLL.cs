using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco2025
{
    class UsuarioBLL
    {
        private int codUsuario;
        private string nomeUsuario, senha, tipo;

        public int CodUsuario { get => codUsuario; set => codUsuario = value; }
        public string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
