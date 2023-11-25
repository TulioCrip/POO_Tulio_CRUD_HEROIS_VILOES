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

namespace TrabalhoHeroisViloes.VIEW.Parceiros
{
    public partial class ConsultaAmigosHeroi : Form
    {
        ParceirosDAO DAO;
        AmigoSuper parceiro;

        public ConsultaAmigosHeroi()
        {
            InitializeComponent();
            DAO = new ParceirosDAO();
            parceiro = new AmigoSuper();
            DAO.consultar(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                parceiro.IdPessoa = Convert.ToInt32(textBox1.Text);
                DAO.consultarSeparado(dataGridView1, parceiro.IdPessoa);
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
                parceiro.IdPessoa = Convert.ToInt32(textBox1.Text);
                DAO.excluir(parceiro);
            }
            else
            {
                MessageBox.Show("ID INVALIDO");
                DAO.consultar(dataGridView1);
            }
        }

        private void ConsultaAmigosHeroi_Load(object sender, EventArgs e)
        {

        }
    }
}
