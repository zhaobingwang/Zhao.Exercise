using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhao.Exercise.Common
{
    public class TypeConverter
    {
        public static string ChangeString(object value,string defaultValue)
        {
            if (value==null)
            {
                return defaultValue;
            }
            return Convert.ToString(value);
        }
        public static string ChangeString(object value)
        {
            return ChangeString(value, string.Empty);
        }
    }
}
