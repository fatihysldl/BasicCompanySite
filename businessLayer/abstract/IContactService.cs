using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace dataAccessLayer.concrete
{
    public interface IContactService
    {
        List<contact> list();
        void insert(contact p);

        contact GetId(int Id);
        void update(contact p);
        void delete(contact p);

        List<contact> List(Expression<Func<contact, bool>> filter);
    }
}

