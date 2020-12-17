using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

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
                DisplayAttribute nameAttr = info.GetCustomAttribute<DisplayAttribute>();
                return nameAttr?.Name ?? value.ToString();
            }
            else
            {
                return value.ToString();
            }
        }

        public static Dictionary<string, string> GetValueDictionary(this Enum group)
        {
            Type groupType = group.GetType();

            var result = new Dictionary<string, string>();
            var keys = Enum.GetValues(groupType).AsQueryable().Cast<int>().ToList();

            keys.ForEach(k => result.Add(k.ToString(), Enum.GetName(groupType, k)));

            return result;
        }
    }
}
