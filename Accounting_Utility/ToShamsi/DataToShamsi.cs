using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Accounting_Utility.ToShamsi
{
    public static class DataToShamsi
    {
        public static string ToShamsi(this DateTime dateTime)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(dateTime).ToString() + "/" + pc.GetMonth(dateTime).ToString("00") +
                "/" + pc.GetDayOfMonth(dateTime).ToString("00");
        }

        public static DateTime Tomiladi(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, new System.Globalization.PersianCalendar());
        }

    }
}
