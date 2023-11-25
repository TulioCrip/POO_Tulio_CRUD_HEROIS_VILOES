using HeroisViloes.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoHeroisViloes.MODEL.DAO;
using TrabalhoHeroisViloes.VIEW.Herois;

namespace TrabalhoHeroisViloes.VIEW.Viloes
{
    public partial class ConsultaViloes : Form
    {
        viloesDAO DAO;
        SuperViloes viloes;

        public ConsultaViloes()
        {
            InitializeComponent();
            DAO = new viloesDAO();
            DAO.consultar(dataGridView1);
            viloes = new SuperViloes();
        }

        private void ConsultaViloes_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                viloes.IdPessoa = Convert.ToInt32(textBox1.Text);
                DAO.consultarSeparado(dataGridView1, viloes.IdPessoa);
            }
            else
            {
                MessageBox.Show("ID INVALIDO");
                DAO.consultar(dataGridView1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                viloes.IdPessoa = Convert.ToInt32(textBox1.Text);
                DAO.excluir(viloes);
            }
            else
            {
                MessageBox.Show("ID INVALIDO");
                DAO.consultar(dataGridView1);
            }
        }
    }
}
