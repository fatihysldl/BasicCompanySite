using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace dataAccessLayer.concrete
{
    public interface IAboutService
    {
        List<about> list();
        void insert(about p);

        about GetId(int Id);
        void update(about p);
        void delete(about p);

        List<about> List(Expression<Func<about, bool>> filter);
    }
}
