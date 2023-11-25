namespace HeroisViloes.Model.Entities
{
    class AmigoSuper : Pessoa
    {
        private string hobby;
        private string atividadeProfissional;


        //Construtor

        public AmigoSuper() : base()
        {
            hobby = "";
            atividadeProfissional = "";
        }
        //Propriedades

        public string Hobby
        {
            get { return hobby; }
            set { hobby = value; }
        }

        public string AtividadeProfissional
        {
            get { return atividadeProfissional; }
            set { atividadeProfissional = value; }
        }
        public void calcularIdade()
        {
            base.Idade = (DateTime.Today.Year - base.AnoNasc);
        }
    }//amigoSuper
}//namespace
