using HeroisViloes.Model.Entities;

namespace TrabalhoHeroisViloes.MODEL.DAO
{
    interface IDao
    {
        public object atualizar(object objeto);
        public bool excluir(object objeto);
        public object inserir(object objeto);
    }
}
