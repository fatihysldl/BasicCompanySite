using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace dataAccessLayer.concrete
{
    public interface ICompanyServicesService
    {
        List<companyServices> list();
        void insert(companyServices p);

        companyServices GetId(int Id);
        void update(companyServices p);
        void delete(companyServices p);

        List<companyServices> List(Expression<Func<companyServices, bool>> filter);
    }
}

