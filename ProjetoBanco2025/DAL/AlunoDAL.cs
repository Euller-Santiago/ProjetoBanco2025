using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections;

namespace ProjetoBanco2025.DAL
{
    class AlunoDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.Aluno aluno)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"INSERT INTO ALUNO
            (nome, cpf, rg, email, datanascimento)
            VALUES
            (@nome, @cpf, @rg, @email, @datanascimento)";

            cmd.Parameters.AddWithValue("@nome", aluno.getNome());
            cmd.Parameters.AddWithValue("@cpf", aluno.getCpf());
            cmd.Parameters.AddWithValue("@rg", aluno.getRg());
            cmd.Parameters.AddWithValue("@email", aluno.getEmail());
            cmd.Parameters.AddWithValue("@datanascimento", aluno.getData());

            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void Excluir(BLL.Aluno aluno)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"DELETE FROM aluno WHERE codaluno = @codaluno";
            cmd.Parameters.AddWithValue("@codaluno", aluno.getCodAluno());
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void Atualizar(BLL.Aluno aluno)
        {
            MySqlCommand cmd = new MySqlCommand(
                @"UPDATE aluno
                    SET nome = @nome,
                        cpf = @cpf,
                        rg = @rg,
                        email = @email,
                        datanascimento = @datanascimento
                        WHERE codaluno = @codaluno",
                        con.Conectar()
            );

            cmd.Parameters.AddWithValue("@nome", aluno.getNome());
            cmd.Parameters.AddWithValue("@cpf", aluno.getCpf());
            cmd.Parameters.AddWithValue("@rg", aluno.getRg());
            cmd.Parameters.AddWithValue("@email", aluno.getEmail());
            cmd.Parameters.AddWithValue("@datanascimento", aluno.getData());
            cmd.Parameters.AddWithValue("@codaluno", aluno.getCodAluno());

            cmd.ExecuteNonQuery();
            con.Desconectar();

        }

        public DataTable ConsultaTodos()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM aluno", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable PesquisarNome(BLL.Aluno aluno)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(@"SELECT * FROM aluno WHERE nome LIKE @nome", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@nome", "%" + aluno.getNome() + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public BLL.Aluno Retornar(BLL.Aluno aluno)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM aluno WHERE codaluno = @codaluno";
            cmd.Parameters.AddWithValue("@codaluno", aluno.getCodAluno());
            cmd.Connection = con.Conectar();
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                aluno.setCodAluno(Convert.ToInt32(dr["codaluno"]));
                aluno.setNome(dr["nome"].ToString());
                aluno.setCpf(dr["cpf"].ToString());
                aluno.setRg(dr["rg"].ToString());
                aluno.setEmail(dr["email"].ToString());
                aluno.setData(Convert.ToDateTime(dr["datanascimento"].ToString()));

            }

            dr.Close();
            con.Desconectar();
            return aluno;
        }
    }
}