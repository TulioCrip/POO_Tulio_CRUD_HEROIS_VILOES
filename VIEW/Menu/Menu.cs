using TrabalhoHeroisViloes.VIEW.Parceiros;
using TrabalhoHeroisViloes.VIEW.Viloes;

namespace TrabalhoHeroisViloes.VIEW.Herois
{

    public partial class Menu : Form
    {
        public Form Form;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void aMIGOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form?.Close();

            Form = new Parceiros
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            ControlePainel.Controls.Add(Form);
            Form.Show();

        }

        private void cADASTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form?.Close();

            Form = new Viloes
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            ControlePainel.Controls.Add(Form);
            Form.Show();
        }

        private void hEROIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cONSULTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form = new ConsultaViloes
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            ControlePainel.Controls.Add(Form);
            Form.Show();
        }

        private void cADASTRARToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form?.Close();

            Form = new Herois
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            ControlePainel.Controls.Add(Form);
            Form.Show();
        }

        private void cONSULTAREXCLUIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form?.Close();

            Form = new consultaHerois
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            ControlePainel.Controls.Add(Form);
            Form.Show();
        }

        private void aTUALIZARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form?.Close();

            Form = new AtualizarHeroi
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            ControlePainel.Controls.Add(Form);
            Form.Show();
        }

        private void cADASTRARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form?.Close();

            Form = new Viloes
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            ControlePainel.Controls.Add(Form);
            Form.Show();
        }

        private void cONSULTAREXCLUIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form?.Close();

            Form = new ConsultaViloes
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            ControlePainel.Controls.Add(Form);
            Form.Show();
        }

        private void cADASTRARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form?.Close();

            Form = new Parceiros
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            ControlePainel.Controls.Add(Form);
            Form.Show();
        }

        private void cONSULTAREXCLUIRToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form?.Close();

            Form = new ConsultaAmigosHeroi
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            ControlePainel.Controls.Add(Form);
            Form.Show();
        }
    }
}
