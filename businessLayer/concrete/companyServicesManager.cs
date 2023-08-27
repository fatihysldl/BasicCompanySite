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
    public class companyServicesManager : ICompanyServicesService
    {
        ICompanyServicesDal _companyServices;

        public companyServicesManager(ICompanyServicesDal companyServices)
        {
            _companyServices = companyServices;
        }

        public void delete(companyServices p)
        {
            _companyServices.delete(p);
        }

        public companyServices GetId(int Id)
        {
            return _companyServices.GetId(Id);
        }

        public void insert(companyServices p)
        {
            _companyServices.insert (p);
        }

        public List<companyServices> list()
        {
            return _companyServices.list();
        }

        public List<companyServices> List(Expression<Func<companyServices, bool>> filter)
        {
            return _companyServices.List(filter);   
        }

        public void update(companyServices p)
        {
            _companyServices.update (p);
        }
    }
}
