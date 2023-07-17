using System;
using Entities;

namespace DataAccess
{
    //public interface IEntityRepository<T> where T: class,IEntity, new()
    public interface IEntityRepository<T> where T: IEntity
	{
        List<T> GetAll();

        T GetByID(int id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}


