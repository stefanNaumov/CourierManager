using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CourierManager
{
    public static class EnumHelper
    {
        public static string ReturnDescription(Location location)
        {
            Type type = location.GetType();

            MemberInfo[] memInfo = type.GetMember(location.ToString());

            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }
            return location.ToString();
        }

        public static Location? ReturnValue(string description)
        {
            FieldInfo[] fields = typeof(Location).GetFields();

            foreach (FieldInfo field in fields)
            {
                if (field.GetCustomAttributes(typeof(DescriptionAttribute), false).Count() > 0)
                {
                    if (((DescriptionAttribute)field.GetCustomAttributes(typeof(DescriptionAttribute), false)[0]).Description == description)
                    {
                        return (Location)field.GetRawConstantValue();
                    }
                }
            }
            return null;
        }
    }
}
