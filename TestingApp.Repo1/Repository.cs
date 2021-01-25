using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingApp.Model;

namespace TestingApp.Repo1
{
    public class Repository<T> : IRepository<T> where T : class , IMyEntity
    {
        private TestingAppDbContext _db;
        
        public Repository()
        {

            _db = new TestingAppDbContext();
        }
        public T Delete(long id)
        {
            T row = _db.Set<T>().Find(id);
            _db.Set<T>().Remove(row);
            return row;
           
        }

        public T Get(long id)
        {
            T row = _db.Set<T>().Find(id);
            return row;

        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public void Post(T entity)
        {
            _db.Set<T>().Add(entity);
            
        }

        public void Put(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified; 
        }
        public int Save()
        {

            return _db.SaveChanges();
        }

        public List<T> Search(string search)
        {
            var data = _db.Set<T>().Where(s => s.Name.StartsWith(search)).ToList();
            return data;
        }
    }
}
