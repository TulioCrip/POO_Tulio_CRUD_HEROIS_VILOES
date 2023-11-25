namespace HeroisViloes.Model.Entities
{
    public class SuperHeroi : Pessoa
    {
        //Atributos
        private string nomeHeroi;
        private string planetaOrigem;
        private string atividadeProfissional;
        private string parceiro;
        private string superPoder;
        private string grupo;
        private string pontoFraco;

        //Construtor
        public SuperHeroi() : base()
        {
            nomeHeroi = null;
            planetaOrigem = null;
            atividadeProfissional = null;
            parceiro = null;
            superPoder = null;
            grupo = null;
            pontoFraco = null;
        }

        //Propriedades

        public string NomeHeroi
        {
            get { return nomeHeroi; }
            set { nomeHeroi = value; }
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
