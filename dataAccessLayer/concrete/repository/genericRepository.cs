using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace dataAccessLayer.concrete.repository
{
    public class genericRepository<T> : IRepositoryDal<T> where T : class
    {
        public void delete(T p)
        {
            using var c = new context();    
            c.Remove(p);
            c.SaveChanges();
        }

        public T GetId(int Id)
        {
            using var c = new context();
            return c.Set<T>().Find(Id);
        }

        public void insert(T p)
        {
            using var c = new context();
            c.Add(p);
            c.SaveChanges();
        }

        public List<T> list()
        {
            using var c = new context();
            return c.Set<T>().ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            using var c = new context();
            return c.Set<T>().Where(filter).ToList();
        }

        public void update(T p)
        {
            using var c = new context();
            c.Update(p);
            c.SaveChanges();
        }
    }
}
