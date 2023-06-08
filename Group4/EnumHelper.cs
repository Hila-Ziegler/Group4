using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;

namespace Group4
{
    class EnumHelper
    {
        public static string GetDescription(Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);

            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    DescriptionAttribute attr = field.GetCustomAttribute<DescriptionAttribute>();
                    if (attr != null)
                    {
                        return attr.Description;
                    }
                }
            }

            return value.ToString();
        }
    }
}
