using HeroisViloes.Model.Entities;
using System.Data;
using System.Data.SqlClient;
using TrabalhoHeroisViloes.VIEW.Herois;

namespace TrabalhoHeroisViloes.MODEL.DAO
{
    public class ParceirosDAO : IDao 
    {
        //CRUD dos parceiros dos Herios


        private SqlConnection _conexao;

        //Método para atualizar as informações no banco de dados
        public object atualizar(object objeto)
        {
            _conexao = Conexao.obterConexao();
            AmigoSuper herois = new AmigoSuper();
            herois = (AmigoSuper)objeto;


            //String de update no banco de dados
            string UPDATE = "UPDATE AmigosHeroi set nome = '" + herois.NomePessoa +
                 "', anoNasc '" + herois.AnoNasc +
                 "', idade'" + herois.Idade +
                 "', email'" + herois.Email +
                 "', caminhoImagem'" + herois.caminhoImagem +
                 "', atividadeProfissional'" + herois.AtividadeProfissional +
                 "' Where idherois =" + herois.IdPessoa;

            try
            {
                SqlCommand command = new SqlCommand(UPDATE, _conexao);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sucesso na Atualização dos Dados");
                    command.Dispose();

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro na Atualização" + ex);
            }
            finally
            {
                Conexao.fecharConexao(_conexao);
            }
            return _conexao;

        }
        //Método para consultar as informações no banco de dados
        public void consultar(DataGridView grdData)
        {
            string query = "SELECT * FROM AmigosHeroi";
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
            string select = "SELECT * FROM AmigosHeroi WHERE idAmigo = " + consutaSeparado;
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
            AmigoSuper herois = new AmigoSuper();
            herois = (AmigoSuper)objeto;
            bool sucesso = false;
            string DELETE = "DELETE FROM AmigosHeroi WHERE idAmigoHeroi = " + herois.IdPessoa;
            try
            {
                _conexao = Conexao.obterConexao();
                SqlCommand Command = new SqlCommand(DELETE, _conexao);
                if (Command.ExecuteNonQuery() == 1)
                {
                    Command.Dispose();
                    sucesso = true;
                    MessageBox.Show("Entrou");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de exclusão" + ex);
            }
            finally
            {
                Conexao.fecharConexao(_conexao);
            }
            return sucesso;
        }
        //Método para inserir informações no banco de dados
        public object inserir(object objeto)
        {
            AmigoSuper parceiro = new AmigoSuper();
            parceiro = (AmigoSuper)objeto;


            string INSERT = "INSERT INTO AmigosHeroi (nome, anoNasc, idade, " +
                "email, caminhoImagem, atividadeProfissional) " +
                "values(' " + parceiro.NomePessoa +
                "', '" + parceiro.AnoNasc +
                "', '" + parceiro.Idade +
                "', '" + parceiro.Email +
                "', '" + parceiro.caminhoImagem +
                "', '" + parceiro.AtividadeProfissional +
                "' )";

            try
            {
                _conexao = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(INSERT, _conexao);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Salvo com êxito");
                    Console.WriteLine("Sucesso na Inscrição");
                    command.Dispose();
                }
                MessageBox.Show("Salvo com êxito");
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


