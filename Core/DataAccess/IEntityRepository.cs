using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{

    //GENERIC REPOSITORY DESING PATTERN
    // GENERIC CONSTRAINT where T : class yani referans tip olabilir ve Ientity nesne olabilir ve new() lenebilir olmalı yani IEntity veremiyz ICategory,,,içerisinde
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {     ////Expression<Func<T,bool>> filter = null  Linq kullanarak herşeyi değilde istediğimiz şeyi filtrelememizi sağlar
        List<T> GetAll(Expression<Func<T,bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

       

    }
}
