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
    public class contactManager : IContactService
    {
        IContactDal _contactDal;

        public contactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void delete(contact p)
        {
            _contactDal.delete(p);
        }

        public contact GetId(int Id)
        {
            return _contactDal.GetId(Id);
        }

        public void insert(contact p)
        {
            _contactDal.insert(p);
        }

        public List<contact> list()
        {
            return _contactDal.list();
        }

        public List<contact> List(Expression<Func<contact, bool>> filter)
        {
            return _contactDal.List(filter);
        }

        public void update(contact p)
        {
            _contactDal.update(p);
        }
    }
}
