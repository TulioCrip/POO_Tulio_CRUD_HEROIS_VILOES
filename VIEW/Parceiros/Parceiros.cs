using HeroisViloes.Model.Entities;
using TrabalhoHeroisViloes.MODEL.DAO;

namespace TrabalhoHeroisViloes.VIEW.Herois
{
    public partial class Parceiros : Form
    {
        ParceirosDAO DAO;
        AmigoSuper parceiro;
        public Parceiros()
        {
            InitializeComponent();
            DAO = new ParceirosDAO();
            parceiro = new AmigoSuper();
        }

        private void Parceiros_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            parceiro.NomePessoa = TXNP.Text;
            parceiro.AnoNasc = Convert.ToInt32(textBox10.Text);
            parceiro.Email = textBox7.Text;
            parceiro.AtividadeProfissional = textBox9.Text;
            parceiro.caminhoImagem = textBox11.Text;
            parceiro.Hobby = textBox3.Text;
            parceiro.calcularIdade();

            DAO.inserir(parceiro);

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
