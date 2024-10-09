using Accounting_DataLayer.Context;
using Accounting_ViewModel.Accounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_Bussines
{
    public class Account
    {
        public static ReportViewModel report()
        {
            ReportViewModel rp = new ReportViewModel();
            using (UnitOfWork db = new UnitOfWork())
            {
                var paying = db.GenericRepositoty.Get(n => n.C_Type_Id == 1).Select(n => n.Amount).ToList();
                var incoming = db.GenericRepositoty.Get(n => n.C_Type_Id == 2).Select(n => n.Amount).ToList();

                rp.Payeing = paying.Sum();
                rp.Incoming = incoming.Sum();
                rp.Remain = (incoming.Sum() - paying.Sum());
            }
            return rp;
        }


    }
}
