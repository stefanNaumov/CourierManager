using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Markup;
using CourierManager;

namespace TeamWPF.Extensions
{
    public class EnumExtension: MarkupExtension
    {
        private readonly Type _enumType;

        public EnumExtension(Type enumtype)
        {
            _enumType = enumtype;
        }
        
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
          return (from object enumValue in Enum.GetValues(_enumType) select
                  new {Value = enumValue, Description = ((Enum)enumValue).GetDescription()}).ToArray();
        }

        public class EnumMember
        {
            public string Description { get; set; }
            public object Value { get; set; }
        }
    }
}
