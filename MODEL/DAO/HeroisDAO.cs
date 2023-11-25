using HeroisViloes.Model.Entities;
using System.Data;
using System.Data.SqlClient;

namespace TrabalhoHeroisViloes.MODEL.DAO
{
    public class heroisDAO : IDao //Separação criada para fazer fazer as funções solitadas (cadastrar, excluir, inserir e consultar) CRUD
    {

        private SqlConnection _conexao;


        //
        public object atualizar(object objeto)
        {
            _conexao = Conexao.obterConexao();
            SuperHeroi herois = new SuperHeroi();
            herois = (SuperHeroi)objeto;

            //String update dos Herois
            string UPDATE = "UPDATE Herois set nome = '" + herois.NomePessoa +
                 "', anoNasc '" + herois.AnoNasc +
                 "', idade'" + herois.Idade +
                 "', email'" + herois.Email +
                 "', caminhoImagem'" + herois.caminhoImagem +
                 "', nomeviloes'" + herois.NomeHeroi +
                 "', planetaOrigem'" + herois.PlanetaOrigem +
                 "', atividadeProfissional'" + herois.AtividadeProfissional +
                 "', parceiro '" + herois.Parceiro +
                 "', superPoder '" + herois.SuperPoder +
                 "', grupo '" + herois.Grupo +
                 "', pontoFraco'" + herois.PontoFraco +
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

        //Read dos herois
        public void consultar(DataGridView grdData)
        {
            string query = "SELECT * FROM Herois";
            try
            {
                _conexao = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(query, _conexao);

                //dataReader ira receber o resultado da consulta
                SqlDataAdapter dataReader = new SqlDataAdapter(command);

                DataSet DataSet= new DataSet();

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

        //Um método simples de pesquisa utilisei para selecioanr o heroi, possibilitando consultar separadamente e realizar as ações desejadas
        public void consultarSeparado(DataGridView grdData, int consutaSeparado)
        {
            string select = "SELECT * FROM Herois WHERE idHeroi = " + consutaSeparado;
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

        //Delete do Banco
        public bool excluir(object objeto)
        {
            SuperHeroi herois = new SuperHeroi();
            herois = (SuperHeroi)objeto;
            bool sucesso = false;
            string DELETE = "DELETE FROM Herois WHERE idHeroi = " + herois.IdPessoa;
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

        //Inset do banco 
        public object inserir(object objeto)
        {
            SuperHeroi herois = new SuperHeroi();
            herois = (SuperHeroi)objeto;

            //String de inserção no banco de dados
            string INSERT = "INSERT INTO Herois (nome, anoNasc, idade, " +
                "email, caminhoImagem, nomeHeroi, planetaOrigem, atividadeProfissional, " +
                "parceiro, superPoder, grupo, pontoFraco) " +
                "values (' " + herois.NomePessoa +
                "', '" + herois.AnoNasc +
                "', '" + herois.Idade +
                "', '" + herois.Email +
                "', '" + herois.caminhoImagem +
                "', '" + herois.NomeHeroi +
                "', '" + herois.PlanetaOrigem +
                "', '" + herois.AtividadeProfissional +
                "', '" + herois.Parceiro +
                "', '" + herois.SuperPoder +
                "', '" + herois.Grupo +
                "', '" + herois.PontoFraco +
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


