using HeroisViloes.Model.Entities;
using System.Data.SqlClient;
using TrabalhoHeroisViloes.MODEL.DAO;


namespace TrabalhoHeroisViloes.VIEW.Herois
{
    public partial class Herois : Form
    {
        heroisDAO DAO;
        SuperHeroi herois;
        public Herois()
        {
            InitializeComponent();
            DAO = new heroisDAO();
            herois  = new SuperHeroi();

        }
        public Conexao _conexao;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            herois.NomePessoa = TXNP.Text;
            herois.NomeHeroi = textBox2.Text;
            herois.AnoNasc = Convert.ToInt32(textBox10.Text);
            herois.Email = textBox3.Text;
            herois.SuperPoder = textBox6.Text;
            herois.Grupo = textBox7.Text;
            herois.AtividadeProfissional = textBox9.Text;
            herois.PontoFraco = textBox8.Text;
            herois.caminhoImagem = textBox11.Text;
            herois.PlanetaOrigem = textBox4.Text;
            herois.Parceiro = textBox5.Text;
            herois.calcularIdade();

            DAO.inserir(herois);
        }

        private void Herois_Load(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
