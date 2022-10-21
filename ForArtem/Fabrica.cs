using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;

namespace ForArtem
{
    static class Fabrica
    {
        public static string GetCurrency(string valut,string url,string date)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader;
            switch (valut)
            {
                case "Usd":
                    reader = new XmlTextReader(url + "R01235");
                    break;
                case "Eur":
                    reader = new XmlTextReader(url + "R01239");
                    break;
                default: return "Возможно вы имели ввиду что то другое";
            } 
            int i = 0;
            while (reader.Read())
            {
                i++;
                if (i == 8)
                    return reader.Value;
            }
            return "Похоже, что-то не так";
        }
    }
}
