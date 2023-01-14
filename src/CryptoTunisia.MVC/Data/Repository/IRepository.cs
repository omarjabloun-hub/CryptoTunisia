namespace CryptoTunisia.MVC.Data.Repository;

public interface IRepository<TEntity> where TEntity : class
{
    IEnumerable<TEntity> GetAll();
    TEntity Get(int id);
    void Add(TEntity entity);
    void Update(TEntity entity);
    bool Remove(TEntity entity);
    
}