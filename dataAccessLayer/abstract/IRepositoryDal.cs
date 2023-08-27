using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace dataAccessLayer.concrete
{
    public interface IRepositoryDal<T> where T : class
    {
        List<T> list();
        void insert(T p);
      
        T GetId(int Id);
        void update(T p);
        void delete(T p);

        List<T> List(Expression<Func<T, bool>> filter);
    }
}
