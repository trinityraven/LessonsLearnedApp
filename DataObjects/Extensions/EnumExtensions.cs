using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Linq;

namespace DataObjects.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            Type type = value.GetType();
            MemberInfo info = type.GetMember(value.ToString())[0];

            if (info?.CustomAttributes.Any() == true)
            {
                var nameAttr = info.GetCustomAttribute<DisplayAttribute>();
                return nameAttr?.Name ?? value.ToString();
            }
            else
            {
                return value.ToString();
            }
        }
    }
}
