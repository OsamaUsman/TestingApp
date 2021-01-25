using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingApp.Model;

namespace TestingApp.Repo1
{ 
    public interface IRepository<TEntity> where TEntity : class , IMyEntity
    {
        List<TEntity> GetAll();
        TEntity Get(long id);
        void Post(TEntity entity);
        void Put(TEntity entity);
        TEntity Delete(long id);
        int Save();
        List<TEntity> Search(string search);
    }
}
