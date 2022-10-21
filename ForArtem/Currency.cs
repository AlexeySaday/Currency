using System.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ForArtem
{
    static class Currency
    {
        static string date;
        static string url;
        static Currency()
        {
            date = DateTime.Now.Add(TimeSpan.FromDays(1)).ToString("dd/MM/yyyy");
            url = @"http://www.cbr.ru/scripts/XML_dynamic.asp?date_req1=" + date + "&date_req2=" + date + "&VAL_NM_RQ=";
        }
        static public string FubricOfCurrency(string currency)
        {
            return Fabrica.GetCurrency(currency,url,date);
        } 
    }
     
}  