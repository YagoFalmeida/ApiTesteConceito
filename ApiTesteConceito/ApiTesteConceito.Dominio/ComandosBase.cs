namespace ApiTesteConceito.Dominio
{
    public interface ComandosBase<T> where T : class
    {
        public T Adicionar(T obj);
        public T Obter(long id);
        public T Atualizar(T obj);
        public Boolean Deletar(T obj);
        public List<T> Listar();
        public List<T> Listar(long id);
    }
}