using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormTesteRH
{
    class DiaUtil
    {
        public static DateTime GetQuintoDiaUtil(DateTime dt)
        {
            int Count = 1;
            int Mes = dt.Month;
            int Year = dt.Year;
            DateTime[] Feriados = {new DateTime(Year, 1,1), new DateTime(Year, 5, 1), new DateTime(Year, 9, 7), new DateTime(Year, 11, 2)};
            DateTime dtUtil = new DateTime(Year, Mes, 1);
            while (Count < 5)
            {
                if (dtUtil.DayOfWeek == DayOfWeek.Saturday || dtUtil.DayOfWeek == DayOfWeek.Sunday)
                {
                    //adicionar um dia
                    dtUtil = dtUtil.AddDays(1);
                }
                else
                {
                    //adicionar um dia
                    if (!Feriados.Contains(dtUtil))
                    {
                        dtUtil = dtUtil.AddDays(1);
                        Count++;
                    }
                    else
                    {
                        dtUtil = dtUtil.AddDays(1);
                    }
                }
            }

            if (dtUtil.DayOfWeek == DayOfWeek.Saturday)
            {
                dtUtil = dtUtil.AddDays(2);
            }
            else if (dtUtil.DayOfWeek == DayOfWeek.Sunday)
            {
                dtUtil = dtUtil.AddDays(1);
            }

            if (Feriados.Contains(dtUtil)) 
            {
                dtUtil = dtUtil.AddDays(1);
            }

            return dtUtil;
        }
    }
}
