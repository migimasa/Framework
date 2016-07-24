using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Migi.Framework.Helper
{
    public class StringHelper
    {
        public static string TrimStringForSaving(string value)
        {
            return value.Trim();
        }

        public static string TrimStringReplaceNulls(string value)
        {
            if (value == null)
            {
                return string.Empty;
            }
            else
            {
                string trimmedValue = value.Replace(Environment.NewLine, string.Empty);
                trimmedValue = trimmedValue.Replace("\t", "");

                trimmedValue = trimmedValue.Trim();

                return System.Text.Encoding.ASCII.GetString(System.Text.Encoding.ASCII.GetBytes(trimmedValue));
            }
        }
    }
}
