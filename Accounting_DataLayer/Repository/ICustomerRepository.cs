using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting_ViewModel;

namespace Accounting_DataLayer.Repository
{
    public interface ICustomerRepository
    {
        List<Customers> GetAllCustomers();
        Customers GetCustomersById(int CustomerId);
        List<ListCustomerViewModel> GetCustomerByName(string filter = "");
        int GetIdCustomerByName(string name);
        List<Customers> CustomerFilter(string context);
        bool InsertCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);
        bool DeleteCustomer(Customers customer);
        bool DeleteCustomer(int id);
        string GetNameById(int id);
    }
}
