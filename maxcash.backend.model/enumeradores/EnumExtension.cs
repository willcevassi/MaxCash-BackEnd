using System;
using System.ComponentModel;

namespace maxcash.backend.model.enumeradores
{
    public class EnumExtension
    {
         public static string ToDescriptionString(Enum value)
         {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])value
                .GetType()
                .GetField(value.ToString())
                .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
         }
       
    }
    }
}
