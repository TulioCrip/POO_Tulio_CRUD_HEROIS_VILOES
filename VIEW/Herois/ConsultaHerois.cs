using HeroisViloes.Model.Entities;
using System.Data.SqlClient;
using TrabalhoHeroisViloes.MODEL.DAO;

namespace TrabalhoHeroisViloes.VIEW.Herois
{
    public partial class consultaHerois : Form
    {
        heroisDAO DAO;
        SuperHeroi herois;
        public consultaHerois()
        {
            InitializeComponent();
            DAO = new heroisDAO();
            DAO.consultar(dataGridView1);
            herois = new SuperHeroi();
        }

        private void consultaHerois_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                herois.IdPessoa = Convert.ToInt32(textBox1.Text);
                DAO.consultarSeparado(dataGridView1, herois.IdPessoa);
            }
            else
            {
                MessageBox.Show("ID INVALIDO");
                DAO.consultar(dataGridView1);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                herois.IdPessoa = Convert.ToInt32(textBox1.Text);
                DAO.excluir(herois);
            }
            else
            {
                MessageBox.Show("ID INVALIDO");
                DAO.consultar(dataGridView1);
            }
        }
    }
}
