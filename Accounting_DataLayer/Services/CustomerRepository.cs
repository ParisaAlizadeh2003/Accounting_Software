using Accounting_DataLayer.Repository;
using Accounting_ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting_ViewModel;
using System.Data.Common;

namespace Accounting_DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private Accounting_DBEntities db;
        public CustomerRepository(Accounting_DBEntities context)
        {
            db = context;
        }

        public bool DeleteCustomer(Customers customer)
        {
            try
            {
                db.Customers.Remove(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(int id)
        {
            try
            {
                var result = GetCustomersById(id);
                DeleteCustomer(result);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Customers> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public Customers GetCustomersById(int CustomerId)
        {
            return db.Customers.Find(CustomerId);
        }

        public int GetIdCustomerByName(string name)
        {
            return db.Customers.First(n => n.fullname == name).id;
        }

        public string GetNameById(int id)
        {
            return db.Customers.Find(id).fullname;
        }

        public bool InsertCustomer(Customers customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool UpdateCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = System.Data.Entity.EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        List<Customers> ICustomerRepository.CustomerFilter(string context)
        {
            return db.Customers.Where(n => n.fullname.Contains(context) || n.email.Contains(context) || n.mobile.Contains(context)).ToList();
        }

        List<ListCustomerViewModel> ICustomerRepository.GetCustomerByName(string filter)
        {
            if (filter == null)
            {
                //return db.Customers.Select(name => name.fullname).ToList<>();
                return db.Customers.Select(name => new ListCustomerViewModel()
                {
                    ID = name.id,
                    Fullname = name.fullname
                }).ToList();
            }
            return db.Customers.Where(name => name.fullname.Contains(filter))
                .Select(name => new ListCustomerViewModel()
                {
                    ID = name.id,
                    Fullname = name.fullname
                }).ToList();
        }
    }
}
