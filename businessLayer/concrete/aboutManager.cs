using dataAccessLayer.concrete;
using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer.concrete
{
    public class aboutManager : IAboutService
    {
        IAboutDal _About;

        public aboutManager(IAboutDal about)
        {
            _About = about;
        }

        public void delete(about p)
        {
            _About.delete(p);
        }

        public about GetId(int Id)
        {
            return _About.GetId(Id);
        }

        public void insert(about p)
        {
            _About.insert(p);
        }

        public List<about> list()
        {
            return _About.list();
        }

        public List<about> List(Expression<Func<about, bool>> filter)
        {
            return _About.List(filter);
        }

        public void update(about p)
        {
            _About.update(p);
        }
    }
}
