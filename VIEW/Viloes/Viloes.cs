using HeroisViloes.Model.Entities;
using System.Windows.Forms;
using TrabalhoHeroisViloes.MODEL.DAO;

namespace TrabalhoHeroisViloes.VIEW.Herois
{
    public partial class Viloes : Form
    {
        viloesDAO DAO;
        SuperViloes viloes;
        public Viloes()
        {
            InitializeComponent();
            DAO = new viloesDAO();
            viloes = new SuperViloes();
        }
        public Conexao _conexao;
        private void Viloes_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _conexao = new Conexao();


            viloes.NomePessoa = textBox1.Text;
            viloes.NomeVilao = textBox2.Text;
            viloes.AnoNasc = Convert.ToInt32(textBox10.Text);
            viloes.Email = textBox3.Text;
            viloes.SuperPoder = textBox6.Text;
            viloes.caminhoImagem = textBox11.Text;
            viloes.PlanetaOrigem = textBox4.Text;
            viloes.Parceiro = textBox5.Text;
            viloes.calcularIdade();

            DAO.inserir(viloes);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
