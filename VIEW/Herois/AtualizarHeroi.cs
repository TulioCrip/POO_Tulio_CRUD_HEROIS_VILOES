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

namespace TrabalhoHeroisViloes.VIEW.Herois
{
    public partial class AtualizarHeroi : Form
    {
        heroisDAO DAO;
        SuperHeroi herois;
        public AtualizarHeroi()
        {
            InitializeComponent();
            DAO = new heroisDAO();
            herois = new SuperHeroi();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void AtualizarHeroi_Load(object sender, EventArgs e)
        {

        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            herois.IdPessoa = Convert.ToInt32(idHeroi.Text);
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

            DAO.atualizar(herois);
        }
    }
}
