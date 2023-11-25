namespace HeroisViloes.Model.Entities
{
    public class SuperViloes : Pessoa
    {
        //Atributos
        private string nomeVilao;
        private string planetaOrigem;
        private string atividadeProfissional;
        private string parceiro;
        private string superPoder;
        private string grupo;
        private string pontoFraco;

        //Construtor
        public SuperViloes() : base()
        {
            nomeVilao = null;
            planetaOrigem = null;
            atividadeProfissional = null;
            parceiro = null;
            superPoder = null;
            grupo = null;
            pontoFraco = null;
        }

        //Propriedades

        public string NomeVilao
        {
            get { return nomeVilao; }
            set { nomeVilao = value; }
        }

        public string PlanetaOrigem
        {
            get { return planetaOrigem; }
            set { planetaOrigem = value; }
        }

        public string AtividadeProfissional
        {
            get { return atividadeProfissional; }
            set { atividadeProfissional = value; }
        }

        public string Parceiro
        {
            get { return parceiro; }
            set { parceiro = value; }
        }

        public string SuperPoder
        {
            get { return superPoder; }
            set { superPoder = value; }
        }

        public string Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }

        public string PontoFraco
        {
            get { return pontoFraco; }
            set { pontoFraco = value; }
        }

        public void calcularIdade()
        {
            base.Idade = (DateTime.Today.Year - base.AnoNasc);
        }
    }
}
