using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Migi.Framework.Helper
{
    public class Search
    {
        public static DateTime GetUTCEndOfDaySearchDate(DateTime localSearchDate)
        {
            return localSearchDate.Date.AddDays(1).AddMilliseconds(-20).ToUniversalTime();
        }
    }
}
