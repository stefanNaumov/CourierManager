using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierManager;
using System.ComponentModel;
using System.Windows.Markup;
using TeamWPF.Extensions;

namespace TeamWPF.Extensions
{
    public static class EnumDescriptionExtension
    {
        public static string GetDescription(this Enum value) {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attribute = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() as DescriptionAttribute;
            return attribute != null ? attribute.Description : value.ToString();
        }
    }
}
