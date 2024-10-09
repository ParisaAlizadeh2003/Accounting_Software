using Accounting_DataLayer.Repository;
using Accounting_DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        Accounting_DBEntities db = new Accounting_DBEntities();

        private ICustomerRepository _customerRepository;
        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(db);
                }
                return _customerRepository;
            }
        }

        private GenericRepositoty<Accounting> _genericrepository;
        public GenericRepositoty<Accounting> GenericRepositoty
        {
            get
            {
                if (_genericrepository == null)
                {
                    _genericrepository = new GenericRepositoty<Accounting>(db);
                }
                return _genericrepository;
            }
        }

       
        public void save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
