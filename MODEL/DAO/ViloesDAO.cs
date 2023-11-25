using HeroisViloes.Model.Entities;
using System.Data;
using System.Data.SqlClient;

namespace TrabalhoHeroisViloes.MODEL.DAO
{
    public class viloesDAO : IDao
    {
        private SqlConnection _conexao;

        //Método para atualizar as informações no banco de dados
        public object atualizar(object objeto)
        {
            _conexao = Conexao.obterConexao();
            SuperViloes viloes = new SuperViloes();
            viloes = (SuperViloes)objeto;

            bool sucesso = false;

            //String de update no banco de dados

            string UPDATE = "UPDATE viloesS set nome = '" + viloes.NomePessoa +
                 "', anoNasc '" + viloes.AnoNasc +
                 "', idade'" + viloes.Idade +
                 "', email'" + viloes.Email +
                 "', caminhoImagem'" + viloes.caminhoImagem +
                 "', nomeviloes'" + viloes.NomeVilao +
                 "', planetaOrigem'" + viloes.PlanetaOrigem +
                 "', atividadeProfissional'" + viloes.AtividadeProfissional +
                 "', parceiro '" + viloes.Parceiro +
                 "', superPoder '" + viloes.SuperPoder +
                 "', grupo '" + viloes.Grupo +
                 "', pontoFraco'" + viloes.PontoFraco +
                 "' Where idviloes =" + viloes.IdPessoa;
            try
            {
                SqlCommand command = new SqlCommand(UPDATE, _conexao);

                if (command.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("Sucesso na Atualização dos Dados");
                    command.Dispose();
                    sucesso = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro na Atualização" + ex);
            }
            finally { Conexao.fecharConexao(_conexao); }
            return _conexao;

        }
        //Método para consultar as informações no banco de dados
        public void consultar(DataGridView grdData)
        {
            string query = "SELECT * FROM Viloes";
            try
            {
                _conexao = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(query, _conexao);

                //dataReader ira receber o resultado da consulta
                SqlDataAdapter dataReader = new SqlDataAdapter(command);

                DataSet DataSet = new DataSet();

                dataReader.Fill(DataSet);

                grdData.ReadOnly = true;

                grdData.DataSource = DataSet.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro na Consulta: " + ex);
            }
            finally
            {
                Conexao.fecharConexao(_conexao);
            }
        }
        //Método para consultar separadamente cada parceiro no banco de dados
        public void consultarSeparado(DataGridView grdData, int consutaSeparado)
        {
            string select = "SELECT * FROM Viloes WHERE idVilao = " + consutaSeparado;
            try
            {
                _conexao = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(select, _conexao);

                //dataReader ira receber o resultado da consulta
                SqlDataAdapter dataReader = new SqlDataAdapter(command);

                DataSet DataSet = new DataSet();

                dataReader.Fill(DataSet);

                grdData.ReadOnly = true;

                grdData.DataSource = DataSet.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro na Consulta: " + ex);
            }
            finally
            {
                Conexao.fecharConexao(_conexao);
            }
        }
        //Método para deletar as informações no banco de dados

        public bool excluir(object objeto)
        {
            SuperViloes viloes = new SuperViloes();
            viloes = (SuperViloes)objeto;
            bool sucesso = false;
            string DELETE = "DELETE FROM viloess WHERE idviloes = " + viloes.IdPessoa;
            try
            {
                _conexao = Conexao.obterConexao();
                SqlCommand Command = new SqlCommand(DELETE, _conexao);
                if (Command.ExecuteNonQuery() == 1)
                {
                    Command.Dispose();
                    sucesso = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro de exclusão" + ex);
            }
            finally
            {
                Conexao.fecharConexao(_conexao);
            }
            return sucesso;
        }

        //Um método simples de pesquisa utilisei para selecioanr o heroi, possibilitando consultar separadamente e realizar as ações desejadas
        public object inserir(object objeto)
        {
            SuperViloes viloes = new SuperViloes();
            viloes = (SuperViloes)objeto;

            bool sucesso = false;

            string INSERT = "INSERT INTO Viloes (nome, anoNasc, idade, " +
                "email, caminhoImagem, nomeVilao, planetaOrigem, " +
                "parceiro, superPoder) " +
                "values (' " + viloes.NomePessoa +
                "', '" + viloes.AnoNasc +
                "', '" + viloes.Idade +
                "', '" + viloes.Email +
                "', '" + viloes.caminhoImagem +
                "', '" + viloes.NomeVilao +
                "', '" + viloes.PlanetaOrigem +
                "', '" + viloes.Parceiro +
                "', '" + viloes.SuperPoder +
                "' )";

            try
            {
                _conexao = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(INSERT, _conexao);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sucesso na Inscrição");
                    command.Dispose();
                    sucesso = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de Inserção " + ex);
            }

            finally
            {
                Conexao.fecharConexao(_conexao);
            }
            return _conexao;
        }
    }
}


