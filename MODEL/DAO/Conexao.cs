using System.Data.SqlClient;

namespace TrabalhoHeroisViloes.MODEL.DAO
{
    public class Conexao
    {
        public Conexao() { }


        private static string connString = "Data Source = DESKTOP-KLGEPDN\\BANCO_TULIO; Initial Catalog = DB_Herois_viloes3; User ID = conctor; Password = 123@qwe;";

        //Representa a conexao do Banco
        private static SqlConnection conn = null;

        public static string ConnString { get => connString; set => connString = value; }

        //Métodos que permitem obter conexao
        public static SqlConnection obterConexao()
        {
            //vamos Criar a conexao
            conn = new SqlConnection(ConnString);

            //a conexao foi feita com sucesso?
            try
            {
                conn.Open();
                Console.WriteLine("Conexão OK");
            }
            catch (SqlException sqle)
            {
                conn = null;
                MessageBox.Show("Conexão Error :" + sqle);
                Console.WriteLine("Conexão Error :" + sqle);
                //Mostra o erro que ocorreu no campo
            }
            finally
            {
                Console.WriteLine("Executado Sempre");
            }
            return conn;
        }
        public static void fecharConexao(SqlConnection connexao)
        {
            if (connexao != null)
            {
                connexao.Close();
            }
        }
    }
}

