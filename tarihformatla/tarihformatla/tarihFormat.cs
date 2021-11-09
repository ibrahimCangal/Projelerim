using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarihformatla
{
    class tarihFormat
    {
        public String tarihTR(DateTime dt,String format)
        {
            if(format=="Short")
            {
                return String.Format("{0:dd.MM.yyyy}", dt);
            }else if(format == "Long")
            {
                return String.Format("{0:d MMMM yyyy}", dt);
            }
            else if(format == "Full")
            {
                return String.Format("{0:d MMMM yyyy dddd}", dt);
            }
            else
            {
                return "wrong date format parameter (Short,Long or Full)";
            }
            return "";//hiç bir zaman çalışamaz
        }

        public String tarihUSA(DateTime dt, String format)
        {
            if (format == "Full")
            {
                return String.Format("{0:MMMM d,yyyy}", dt);
            }
            else if (format == "NumericYF")
            {
                return String.Format("{0:yyyy-MM-dd}", dt);
            }
            else if (format == "NumericYL")
            {
                return String.Format("{0:MM'/'dd'/'yyyy}", dt);
            }
            else
            {
                return "wrong date format parameter (NumericYF,NumericYL or Full)";
            }
            return "";//hiç bir zaman çalışamaz
        }

        public String tarihAR(DateTime dt, String format)
        {
            if (format == "Numeric")
            {
                return String.Format("{0:yyyyMMdd}", dt);
            }
            else if (format == "Short")
            {
                return String.Format("{0:dd'/'MM'/'yy}", dt);
            }
            else if (format == "Medium")
            {
                return String.Format("{0:dd'/'MM'/'yyyy}", dt);
            }
            else if (format == "Long")
            {
                return String.Format("{0:d MMMM yyyy}", dt);
            }
            else if (format == "Full")
            {
                return String.Format("{0:dddd d MMMM yyyy}", dt);
            }
            else
            {
                return "wrong date format parameter (Numeric,Short,Medium,Long or Full)";
            }
            return "";//hiç bir zaman çalışamaz
        }
    }
}
