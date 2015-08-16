using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Migi.Framework.Helper
{
    public class Types
    {
        public static Guid? GetNullableGuid(object value)
        {
            if (IsGuid(value))
            {
                return new Guid(value.ToString());
            }
            return null;
        }

        public static bool IsGuid(object value)
        {
            if (value != DBNull.Value && value != null)
            {
                Guid tryData;
                if (Guid.TryParse(value.ToString(), out tryData))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
